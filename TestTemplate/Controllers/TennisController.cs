using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestTemplate.Controllers
{
    public class TennisController : Controller
    {
        // GET: Tennis
        public ActionResult Index()
        {
            return View();
        }
    }
}