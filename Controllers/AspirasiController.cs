using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using barugaWeb.Models;
using X.PagedList;
using X.PagedList.Mvc;
using System.Diagnostics;

namespace barugaWeb.Controllers
{
    public class AspirasiController : Controller
    {

        barugaContext db = new barugaContext();

        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 10;

            var duk = db.trLilkes.GroupBy(x => x.idComplaint).Select(g => new { g.Key, dukungan = g.Count() });

            var AllComplaint = (from a in db.trComplaintLv1s
                                where (a.deletedby == "" || a.deletedby == null) && a.allocatedDate != null
                                join b in db.msTopicsDetails on a.idTopics equals b.idTopicsDetail
                                join c in duk on a.idComplaintLv1 equals c.Key into x from xd in x.DefaultIfEmpty()
                                orderby a.idComplaintLv1 descending
                                select new listAduan
                                {
                                    ID = a.idComplaintLv1,
                                    allocatedDate = a.complaintDate,
                                    Topics = b.name,
                                    Desc = a.desc,
                                    Hide = a.hideUser,
                                    NamaDepan = a.namaDepan,
                                    NamaBelakang = a.namaBelakang,
                                    Status = a.status,
                                    dukungan = (xd == null ? 0 : xd.dukungan)

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
            var duk = db.trLilkes.Where(a => a.idComplaint == id).GroupBy(x => x.idComplaint).Select(g => new { g.Key, dukungan = g.Count() }).ToList();
            if (duk.Count() > 0)
            {
                ViewData["dukungan"] = duk[0].dukungan;
            } else
            {
                ViewData["dukungan"] = 0;
            }

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("_Name")))
            {
                var chkduk = db.trLilkes.Where(a => a.idComplaint == id && a.idUser == HttpContext.Session.GetInt32("_IDUser").Value).ToList();
                if (chkduk.Count() > 0)
                {
                    ViewData["chk"] = chkduk[0].idUser;
                } 
            }

            // konten detail
            var oneCase = from a in db.trComplaintLv1s
                          where (a.deletedby == "" || a.deletedby == null) && a.idComplaintLv1 == id
                          join b in db.msTopicsDetails on a.idTopics equals b.idTopicsDetail into gj
                          from x in gj.DefaultIfEmpty()
                          select new listAduan
                          {
                              ID = a.idComplaintLv1,
                              createdDate = a.complaintDate,
                              allocatedDate = a.allocatedDate,
                              progressDate = a.progressDate,
                              solvedDate = a.solvedDate,
                              Topics = (x == null ? "Topik Aspirasi Sedang Tahap Moderasi" : x.name),
                              Desc = a.desc,
                              Hide = a.hideUser,
                              NamaDepan = a.namaDepan,
                              NamaBelakang = a.namaBelakang,
                              Status = a.status
                          };

            if (oneCase.Count() < 1)
            {
                ViewData["id"] = id;
                return PartialView("_detailnotfound", ViewData["id"]);
            }
            else
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

        [HttpGet]
        public IActionResult dukung(int? idUser, int? idAduan)
        {
            if (db.trLilkes.Where(a => a.idUser == idUser && a.idComplaint == idAduan).Count() > 0) 
            {
                return Content("Anda Sudah Mendukung Aspirasi Ini.");
            }
            else
            {
                trLilke data = new trLilke();

                data.idComplaint = idAduan;
                data.idUser = idUser;

                db.trLilkes.Add(data);
                db.SaveChanges();

                return Content("00");
            }
            
        }
    }
}