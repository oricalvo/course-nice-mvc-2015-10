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
        public ActionResult Index(int? id)
        {
            MyModel model = new MyModel()
            {
                Data = id
            };

            return View(model);
        }
    }

    public class MyModel
    {
        public object Data { get; set; }
    }
}