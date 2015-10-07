using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seed.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            string filePath = this.Server.MapPath("~/App_Data/1.txt");

            return File(filePath, "application/text", "1.txt");
        }
    }
}