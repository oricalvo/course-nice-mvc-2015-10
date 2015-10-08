using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact, IContactRepository contacts)
        {
            if (contact.Name != "123")
            {
                this.ModelState.AddModelError("Name", "Must be 123");
            }

            if (!this.ModelState.IsValid)
            {
                return View();
            }

            //Contact contact = new Contact();

            //UpdateModel(contact);

            //if (string.IsNullOrEmpty(contact.Name))
            //{
            //}

            //
            //  Update database
            //

            return View();
        }
    }

    public class Contact
    {
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(Seed.Resources.Contact),
                    ErrorMessageResourceName = "NameIsRequired")]
        //[Required(ErrorMessage = "Please specify a message")]
        public string Name { get; set; }
    }

    public interface IContactRepository
    {
        Contact[] GetAll();
    }

    public class ContactReposImpl : IContactRepository
    {
        public Contact[] GetAll()
        {
            return new Contact[0];
        }
    }
}