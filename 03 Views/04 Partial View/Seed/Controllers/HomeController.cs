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
            IndexModel model = new IndexModel()
            {
                UserName = "Ori",
            };

            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Menu(string name)
        {
            MenuModel model = new MenuModel()
            {
                UserName = name,
            };

            return View(model);
        }
    }

    public class IndexModel
    {
        public string UserName { get; set; }
    }

    public class MenuModel
    {
        public string UserName { get; set; }
    }
}