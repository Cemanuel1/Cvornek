using Cvornek.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cvornek.Areas.Admin.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: Admin/DashBoard
        public ActionResult Index()
        {
            BusinessData BD = new BusinessData();
            Business.Business BS = new Business.Business();
            BD = BS.GetFormTb();
            return View(BD);
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            BusinessData BD = new BusinessData();
            Business.Business BS = new Business.Business();
            BD = BS.DeleteFormTb(ID);
            return Json(BD.ErrorCode);
        }


    }
}