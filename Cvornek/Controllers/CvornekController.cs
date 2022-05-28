using Cvornek.Business;
using Cvornek.Database;
using Cvornek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cvornek.Controllers
{
    public class CvornekController : Controller
    {
        // GET: Cvornek
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]

        public ActionResult PostData(CvornekModel com)
        {
            BusinessData BD = new BusinessData();
            Business.Business BS = new Business.Business();
            FormTb FT = new FormTb();
            FT.Id = com.Id;
            FT.Name = com.Name;
            FT.Surname = com.Surname;
            FT.Skills = com.Skills;
            FT.PhoneNumber = com.PhoneNumber;
            if (com.PImage != null)
            {
                string DosyaAdi = Guid.NewGuid().ToString().Replace("-", "");
                string Uzanti = System.IO.Path.GetExtension(Request.Files[0].FileName);
                string TamYol = "~/Images/" + DosyaAdi + Uzanti;
                Request.Files[0].SaveAs(Server.MapPath(TamYol));
                FT.PImage = TamYol.Substring(2);
            }
            if (com.Documents != null)
            {
                string DosyaAdi = Guid.NewGuid().ToString().Replace("-", "");
                string Uzanti = System.IO.Path.GetExtension(Request.Files[0].FileName);
                string TamYol = "~/Documents/" + DosyaAdi + Uzanti;
                Request.Files[0].SaveAs(Server.MapPath(TamYol));
                FT.Documents = TamYol.Substring(2);
            }
            BD = BS.InsertFormTb(FT);
            return Json(BD.ErrorCode);

        }
    }
}