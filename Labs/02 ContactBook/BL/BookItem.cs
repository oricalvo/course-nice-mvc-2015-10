using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBook.BL
{
    [Serializable]
    public abstract class BookItem
    {
        public int ID { get; set; }

        public virtual Group Parent { get; set; }

        public abstract string DisplayName { get; }

        public string Path
        {
            get
            {
                if (this.Parent == null)
                {
                    return "~";
                }

                return this.Parent.Path + "/" + this.DisplayName;
            }
        }
    }
}
