using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using barugaWeb.Models;
using System.Diagnostics;
using X.PagedList;
using X.PagedList.Mvc;

namespace barugaWeb.Controllers
{
    public class ProfileController : Controller
    {

        barugaContext db = new barugaContext();

        public IActionResult Index()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("_Name")))
            {
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ViewBag.Profil = db.msUsersPelapors.Where(a => a.idUserPelapor == HttpContext.Session.GetInt32("_IDUser")).ToList();
                return View();
            }
        }

        public IActionResult AspirasiSaya(int? page)
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("_Name")))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var pageNumber = page ?? 1;
                var pageSize = 10;

                var AllComplaint = (from a in db.trComplaintLv1s
                                    where (a.deletedby == "" || a.deletedby == null) && a.idUser == HttpContext.Session.GetInt32("_IDUser")
                                    join b in db.msTopicsDetails on a.idTopics equals b.idTopicsDetail into gj
                                    from x in gj.DefaultIfEmpty()
                                    orderby a.idComplaintLv1 descending
                                    select new listAduan
                                    {
                                        ID = a.idComplaintLv1,
                                        allocatedDate = a.complaintDate,
                                        Topics = (x == null ? "Topik Aspirasi Sedang Tahap Moderasi" : x.name),
                                        Desc = a.desc,
                                        Hide = a.hideUser,
                                        NamaDepan = a.namaDepan,
                                        NamaBelakang = a.namaBelakang,
                                        Status = a.status
                                    }).ToList();

                ViewBag.AllComplaint = AllComplaint.ToPagedList(pageNumber, pageSize);
                return View();
            }
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}