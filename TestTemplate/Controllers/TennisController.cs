using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTemplate.Models;

namespace TestTemplate.Controllers
{
    public class TennisController : Controller
    {
        // GET: Tennis
        QuanLyDatSanEntities db = new QuanLyDatSanEntities();
        public ActionResult Index()
        {
            var lstCsTennis = db.cosoes.Where(n => n.mals == "tennis");
            return View(lstCsTennis);
        }
    }
}