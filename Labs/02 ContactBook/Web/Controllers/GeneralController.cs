using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Web.Controllers
{
    public class GeneralController : Controller
    {
        public ActionResult Header()
        {
            this.ViewBag.IsAuthenticated = this.User.Identity.IsAuthenticated;

            return PartialView();
        }
    }
}
