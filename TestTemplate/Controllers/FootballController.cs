using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTemplate.Models;

namespace TestTemplate.Controllers
{
    public class FootballController : Controller
    {
        // GET: About
        QuanLyDatSanEntities db = new QuanLyDatSanEntities();
        public ActionResult Index()
        {
            var lstCSBongDa = db.cosoes.Where(n => n.mals == "f");
            //ViewBag.CsBongDa = lstCSBongDa;
            return View(lstCSBongDa);
        }


    }
}