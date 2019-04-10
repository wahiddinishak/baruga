using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using barugaWeb.Models;
using X.PagedList;
using X.PagedList.Mvc;
using System.Diagnostics;

namespace barugaWeb.Controllers
{
    public class AduanController : Controller
    {

        barugaContext db = new barugaContext();
        
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 10;

            var AllComplaint = (from a in db.trComplaintLv1s
                               where (a.deletedby == "" || a.deletedby == null) && a.allocatedDate != null
                               join b in db.msTopicsDetails on a.idTopics equals b.idTopicsDetail
                               orderby a.idComplaintLv1 descending
                               select new listAduan
                               {
                                   ID = a.idComplaintLv1,
                                   allocatedDate = a.allocatedDate,
                                   Topics = b.name,
                                   Desc = a.desc,
                                   Hide = a.hideUser,
                                   NamaDepan = a.namaDepan,
                                   NamaBelakang = a.namaBelakang,
                                   Status = a.status
                               }).ToList();

            ViewBag.AllComplaint = AllComplaint.ToPagedList(pageNumber, pageSize);

            ViewData["total"] = db.trComplaintLv1s.Where(a => a.deletedby == "").Count();
            ViewData["baru"] = db.trComplaintLv1s.Where(a => a.deletedby == "" && a.status == "0").Count();
            ViewData["proses"] = db.trComplaintLv1s.Where(a => a.deletedby == "" && a.status == "1").Count();
            ViewData["selesai"] = db.trComplaintLv1s.Where(a => a.deletedby == "" && a.status == "2").Count();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult detail(int? id)
        {
            // konten detail
            var oneCase = from a in db.trComplaintLv1s
                          where (a.deletedby == "" || a.deletedby == null) && a.allocatedDate != null && a.idComplaintLv1 == id
                          join b in db.msTopicsDetails on a.idTopics equals b.idTopicsDetail
                          select new listAduan
                          {
                              ID = a.idComplaintLv1,
                              createdDate = a.complaintDate,
                              allocatedDate = a.allocatedDate,
                              progressDate = a.progressDate,
                              solvedDate = a.solvedDate,
                              Topics = b.name,
                              Desc = a.desc,
                              Hide = a.hideUser,
                              NamaDepan = a.namaDepan,
                              NamaBelakang = a.namaBelakang,
                              // response = a.response,
                              Status = a.status
                          };            

            if ( oneCase.Count() < 1 )
            {
                ViewData["id"] = id;
                return PartialView("_detailnotfound", ViewData["id"]);
            } else
            {
                ViewBag.oneCase = oneCase.ToList();

                //disposisi
                var CaseLv2 = (from a in db.trComplaintLv2s
                               where (a.deletedBy == "" || a.deletedBy == null) && a.idComplaintLv1 == id && a.allocationType == "Prov"
                               join b in db.msOPDProvs on a.idOPD equals b.idOPDProv
                               select new
                               {
                                   OPD = b.name
                               })
                              .Union
                              (from a in db.trComplaintLv2s
                               where (a.deletedBy == "" || a.deletedBy == null) && a.idComplaintLv1 == id && a.allocationType == "KabKot"
                               join b in db.msKabKots on a.idOPD equals b.idKabKot
                               select new
                               {
                                   OPD = b.name
                               });

                var op = "";
                foreach (var idComplaintLv2 in CaseLv2)
                {
                    if (op == "")
                    {
                        op = idComplaintLv2.OPD;
                    }
                    else
                    {
                        op += String.Concat(", ", idComplaintLv2.OPD);
                    }
                }
                ViewData["opd"] = op;

                // proses
                var CaseLv3 = (from a in db.trComplaintLv2s
                               where (a.deletedBy == "" || a.deletedBy == null) && a.idComplaintLv1 == id && a.allocationType == "Prov" && a.allocationStatus == "DT"
                               join b in db.msOPDProvs on a.idOPD equals b.idOPDProv
                               select new
                               {
                                   a.idComplaintLv1,
                                   OPD = b.name
                               })
                              .Union
                              (from a in db.trComplaintLv3s
                               where (a.deletedBy == "" || a.deletedBy == null) && a.idComplaintLv1 == id
                               join b in db.msOPDKabKots on a.idOPDKabKot equals b.idOPDkabKot
                               select new
                               {
                                   a.idComplaintLv1,
                                   OPD = b.name
                               });

                var op1 = "";
                foreach (var idComplaintLv1 in CaseLv3)
                {
                    if (op1 == "")
                    {
                        op1 = idComplaintLv1.OPD;
                    }
                    else
                    {
                        op1 += String.Concat(", ", idComplaintLv1.OPD);
                    }
                }
                ViewData["opd1"] = op1;

                ViewBag.imgSebelum = db.trComplaintPictures.Where(a => a.imgStatus == 0 && a.idComplaint == id).ToList();
                ViewBag.imgSesudah = db.trComplaintPictures.Where(a => a.imgStatus == 1 && a.idComplaint == id).ToList();

                return View();
            }             
        }

        


    }
}