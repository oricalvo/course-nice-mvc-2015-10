using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.BL
{
    [Serializable]
    public class Group : BookItem
    {
        [Required(ErrorMessage = "Name must be non empty")]
        [StringLength(25, ErrorMessage="Name must be less than 25 characters")]
        public string Name { get; set; }

        public virtual ICollection<BookItem> Items { get; set; }

        public Group()
        {
            this.Items = new List<BookItem>();
        }

        public override string DisplayName
        {
            get
            {
                return this.Name;
            }
        }

        public void AddItem(BookItem item)
        {
            this.Items.Add(item);
            item.Parent = this;
        }

        public void DeleteItem(BookItem item)
        {
            this.Items.Remove(item);
            item.Parent = null;
        }
    }
}
