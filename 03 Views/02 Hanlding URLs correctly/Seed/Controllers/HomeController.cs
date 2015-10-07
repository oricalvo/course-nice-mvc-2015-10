using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewData["blabla"] = 8;

            ViewBag.blabla = 8;

            return View();
        }
    }

    public class MyModel
    {
        public string EMail { get; set; }
    }
}