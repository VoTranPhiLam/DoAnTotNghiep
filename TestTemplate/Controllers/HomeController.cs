using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            //return RedirectToAction("DangNhap", "HomeAdmin", new { area = "Admin" });
        }

        
    }
}