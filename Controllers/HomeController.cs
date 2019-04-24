using System;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using barugaWeb.Models;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.IO;

namespace barugaWeb.Controllers
{
    public class HomeController : Controller
    {
        barugaContext db = new barugaContext();

        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IHostingEnvironment environment)
        {
            _hostingEnvironment = environment;
        }
        
        public const string SessionKeyName = "_Name";
        public const string SessionKeyID = "_IDUser";


        [HttpPost]
        public async Task<IActionResult> UploadFiles(IFormFile file)
        {
            //var filePath = String.Concat(Path.Combine(_hostingEnvironment.WebRootPath, "temp"),"\\");
            var uploads = String.Concat(Path.Combine(_hostingEnvironment.WebRootPath, "temp"), "\\", file.FileName);
            //var ext = Path.GetExtension(uploads);
            //var newName = String.Concat(filePath, Convert.ToString(Guid.NewGuid()), ext);

            if (file.Length > 0)
            {
                // var file_name = String.Concat(HttpContext.Session.GetString("_IDUser").ToString(), "_");

                using (var fileStream = new FileStream(Path.Combine(uploads), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                    //System.IO.File.Copy(uploads, newName);
                    //System.IO.File.Delete(uploads);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult aduanPost()
        {
            trComplaintLv1 Data = new trComplaintLv1();

            return PartialView("_aduanPost", Data);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult aduanProses([Bind("idComplaintSource,desc,hideUser,idUser,prov,kabkot,kec,descLocation,allocated")] trComplaintLv1 Data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (string.IsNullOrEmpty(HttpContext.Session.GetString("_Name")))
                    {
                        return Content("01");
                    }
                    else
                    {
                        var idusr = HttpContext.Session.GetInt32("_IDUser").Value;

                        var userInfo = db.msUsersPelapors.Where(a => a.idUserPelapor == idusr).ToList();                        
                        Data.idUser = idusr;
                        Data.namaDepan = userInfo[0].namaDepan;
                        Data.namaBelakang = userInfo[0].namaBelakang;
                        Data.email = userInfo[0].email;
                        Data.complaintDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        Data.allocated = 0;
                        Data.prov = 1;
                        Data.idComplaintSource = 2;
                        Data.createdBy = HttpContext.Session.GetString("_Name").ToString();

                        if (Data.hideUser == "true")
                        {
                            Data.hideUser = "1";
                        }else
                        {
                            Data.hideUser = "0";
                        }
                        
                        db.trComplaintLv1s.Add(Data);
                        db.SaveChanges();

                        return Content("00");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return View(Data);
        }

        public IActionResult wizard()
        {
             return View();
        }

        private static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }


        [HttpPost]
        public IActionResult login(string Email, string Password)
        {

            MD5 md5Hash = MD5.Create();
            var hash = GetMd5Hash(md5Hash, Password);
            var model = db.msUsersPelapors.Where(a => a.email == Email && a.password == hash).ToList();

            if (model.Count > 0)
            {
                HttpContext.Session.SetString(SessionKeyName, String.Concat(model[0].namaDepan, " ", model[0].namaBelakang));
                HttpContext.Session.SetInt32(SessionKeyID, model[0].idUserPelapor);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult register()
        {

            msUsersPelapor Data = new msUsersPelapor();

            return PartialView("_register", Data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult register([Bind("namaDepan,namaBelakang,address,phone,email,password")] msUsersPelapor Data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MD5 md5Hash = MD5.Create();
                    Data.password = GetMd5Hash(md5Hash, Data.password);

                    db.msUsersPelapors.Add(Data);
                    db.SaveChanges();
                    return Content("00");
                }
                catch
                {
                    return Content("99");
                }
            }

            return View(Data);
        }

        public IActionResult Index()
        {

            ViewData["totalCase"] = db.trComplaintLv1s.Where(a => a.deletedby == "" || a.deletedby == null).Count();
            ViewData["OPDProv"] = db.msOPDProvs.Where(a => a.deletedBy == "" || a.deletedBy == null).Count();
            ViewData["Pemkabkot"] = db.msKabKots.Where(a => a.deletedBy == "" || a.deletedBy == null).Count();
            ViewData["OPDKabkot"] = db.msOPDKabKots.Where(a => a.deletedBy == "" || a.deletedBy == null).Count();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult getCaseTop3()
        {
            var duk = db.trLilkes.GroupBy(x => x.idComplaint).Select(g => new { g.Key, dukungan = g.Count() });

            var caseTop3 = from a in db.trComplaintLv1s
                           where (a.deletedby == "" || a.deletedby == null) && a.allocatedDate != null
                           join b in db.msTopicsDetails on a.idTopics equals b.idTopicsDetail
                           join c in duk on a.idComplaintLv1 equals c.Key into x from xd in x.DefaultIfEmpty()
                           orderby xd.dukungan descending
                           select new
                           {
                               ID = a.idComplaintLv1,
                               Topics = b.name,
                               Desc = a.desc,
                               Hide = a.hideUser,
                               NamaDepan = a.namaDepan,
                               NamaBelakang = a.namaBelakang,
                               Dukungan = (xd == null ? 0 : xd.dukungan),
                               Status = a.status
                           };
            var limitCase = caseTop3.Take(3);
            return new JsonResult(limitCase.ToList());
        }

        [HttpGet]
        public IActionResult getKabKot()
        {
            return new JsonResult(db.msKabKots.Where(a => (a.deletedBy == "" || a.deletedBy == null)).OrderBy(a => a.idKabKot).ToList());
        }

        [HttpGet]
        public IActionResult getKec(int idKabKot)
        {
            return new JsonResult(db.msKecs.Where(a => (a.deletedBy == "" || a.deletedBy == null) && a.idKabKot == idKabKot).OrderBy(a => a.idKec).ToList());
        }

        public IActionResult direct()
        {
            ViewData["Title"] = "Direct";
            ViewData["Text"] = "ABC";
            return View();
        }


    }
}
