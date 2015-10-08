using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AddressBook.Web.Models;

namespace AddressBook.Web.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Logon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(LogonModel details)
        {
            if (Membership.ValidateUser(details.UserName, details.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(details.UserName, details.RememberMe != null);

                return null;
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Group");
        }
    }
}
