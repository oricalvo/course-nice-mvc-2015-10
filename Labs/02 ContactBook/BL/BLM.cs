using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AddressBook.BL
{
    [Serializable]
    public class BLM
    {
        private Group root;
        private int nextId;

        private BLM()
        {
            this.root = new Group() { Name = "~" };
            root.Name = "~";

            Seed();
        }

        public Group Root
        {
            get
            {
                return this.root;
            }
        }

        public static BLM Load()
        {
            if (!File.Exists(DBFilePath))
            {
                BLM blm = new BLM();

                blm.Save();

                return blm;
            }

            using (FileStream fs = new FileStream(DBFilePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                BLM context = (BLM)formatter.Deserialize(fs);
                return context;
            }
        }

        private void Seed()
        {
            Group friends = new Group() { ID = GenerateID(), Name = "Friends" };
            root.AddItem(friends);

            Person udi = new Person() { ID = GenerateID(), FirstName = "Udi", LastName = "Cohen" };
            friends.AddItem(udi);

            Group bestFriends = new Group() { ID = GenerateID(), Name = "Best Friends" };
            friends.AddItem(bestFriends);

            Group coWorkers = new Group() { ID = GenerateID(), Name = "Co Workers" };
            root.AddItem(coWorkers);

            Person shlomi = new Person() { ID = GenerateID(), FirstName = "Shlomi", LastName = "Agiv" };
            coWorkers.AddItem(shlomi);

            Group family = new Group() { ID = GenerateID(), Name = "Family" };
            root.AddItem(family);

            Person adva = new Person() { ID = GenerateID(), FirstName = "Adva", LastName = "Mor" };
            family.AddItem(adva);

            Person ori = new Person() { ID = GenerateID(), FirstName = "Ori", LastName = "Calvo" };
            root.AddItem(ori);
        }

        public void Save()
        {
            using (FileStream fs = new FileStream(DBFilePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, this);
            }
        }

        public BookItem FindItemByID(int? id)
        {
            if (id == null)
            {
                return this.Root;
            }

            if (this.root.ID == id.Value)
            {
                return this.root;
            }

            return FindItemByID(this.root, id.Value);
        }

        public BookItem FindItemByID(Group group, int id)
        {
            foreach (BookItem item in group.Items)
            {
                if (item.ID == id)
                {
                    return item;
                }

                if (item is Group)
                {
                    Group subGroup = (Group)item;
                    BookItem res = FindItemByID(subGroup, id);
                    if (res != null)
                    {
                        return res;
                    }
                }
            }

            return null;
        }

        public BookItem GetItemByID(int? id)
        {
            BookItem res = FindItemByID(id);
            if (res == null)
            {
                throw new ArgumentException("Item with id: " + id.Value + " was not found");
            }

            return res;
        }

        public void DeleteItem(BookItem item)
        {
            item.Parent.DeleteItem(item);

            Save();
        }

        private int GenerateID()
        {
            return ++this.nextId;
        }

        private static string DBFilePath
        {
            get
            {
                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/DB.dat");
                Helpers.EnsureDirectory(filePath);
                return filePath;
            }
        }

        public void AddGroup(int parentId, Group newGroup)
        {
            Group parent = (Group)GetItemByID(parentId);

            newGroup.ID = GenerateID();
            parent.AddItem(newGroup);

            Save();
        }
    }
}
