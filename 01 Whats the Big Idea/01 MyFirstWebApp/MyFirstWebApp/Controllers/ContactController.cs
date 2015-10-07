using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            ContactRepository repos = new ContactRepository();
            Contact[] contacts = repos.GetAll();

            return View(contacts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string name, string email)
        {
            ContactRepository repos = new ContactRepository();
            repos.Create(name, email);

            //return View("~/Views/Contact/Index.cshtml", repos.GetAll());
            return RedirectToAction("Index");
        }
    }
}