using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.BL
{
    [Serializable]
    public class Address
    {
        public int ID { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}
