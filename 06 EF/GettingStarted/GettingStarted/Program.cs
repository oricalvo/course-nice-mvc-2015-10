using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    class UserDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext context = new MyContext())
            {
                context.Users.ToArray();

                //UpdateWithSelecting(context);

                //foreach (Group group in context.Groups.Include("Users"))
                //{
                //    Console.WriteLine(group.Name);

                //    foreach (var user in group.Users)
                //    {
                //        Console.WriteLine("    " + user.Name);
                //    }
                //}

            }
        }

        private static void UpdateWithSelecting(MyContext context)
        {
            UserDTO dto = new UserDTO()
            {
                id = 2,
                name = "XXX",
            };

            User user = new User()
            {
                ID = dto.id,
            };

            DbEntityEntry entry = context.Entry(user);
            entry.State = EntityState.Unchanged;

            user.Name = dto.name;

            context.SaveChanges();
        }

        private static void AddMoreData(MyContext context)
        {
            //Group group = context.Groups.Where(g => g.Name == "Friends").Single();

            Group group = (from g in context.Groups where g.Name == "Friends" select g).Single();

            User user = new User()
            {
                Name = "Roni",
            };
            group.Users.Add(user);

            context.SaveChanges();
        }

        private static void CreateData(MyContext context)
        {
            User user = new User()
            {
                Name = "Ori"
            };

            Group group = new Group()
            {
                Name = "Friends",
                Users = new List<User>(),
            };
            context.Groups.Add(group);

            group.Users.Add(user);

            context.SaveChanges();
        }
    }

    class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public MyContext() : base("MyDB")
        {
        }
    }

    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public Group()
        {
            this.Users = new List<User>();
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }

        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
