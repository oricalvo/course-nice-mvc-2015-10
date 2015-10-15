using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularWithTypescript.ApiControllers
{
    public class ContactController : ApiController
    {
        public Contact[] Get()
        {
            return new Contact[]
                {
                    new Contact() {id=1, name="Ori" },
                };
        }
    }

    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
