using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
    }

    public class ContactRepository
    {
        private static List<Contact> contacts = new List<Contact>()
        {
            new Contact() {ID=1, Name="Ori", EMail="ori@gmail.com" },
            new Contact() {ID=2, Name="Roni", EMail="roni@gmail.com" },
        };

        public Contact[] GetAll()
        {
            return contacts.ToArray();
        }

        public void Create(string name, string email)
        {
            contacts.Add(new Contact()
            {
                ID = -1,
                Name = name,
                EMail = email,
            });
        }
    }
}
