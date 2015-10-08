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
            IndexModel model = new IndexModel()
            {
                UserName = "Ori",
            };

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult SiteMenu()
        {
            return PartialView();
        }
    }

    public class IndexModel
    {
        public string UserName { get; set; }
    }
}