using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.BL
{
    [Serializable]
    public class Person : BookItem
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }

        public Person()
        {
            this.Addresses = new List<Address>();
        }

        public override string DisplayName
        {
            get
            {
                return this.FirstName + ", " + this.LastName;
            }
        }
    }
}
