using Cvornek.Business;
using Cvornek.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cvornek.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account ac)
        {
            BusinessData BD = new BusinessData();
            Business.Business BS = new Business.Business();
            BD = BS.GetAccount();
            var account = BD.AccountList.Where(x => x.UserName == ac.UserName && x.Password == ac.Password);
            if (account.Count()>0 && account != null)
            {
                return RedirectToAction("Index", "Admin/DashBoard");
            }
            else
            {
                return Json("Basarisiz");
            }
        }
    }
}