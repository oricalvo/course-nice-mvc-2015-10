﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook.Web.Models
{
    public class LogonModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string RememberMe { get; set; }
    }
}
