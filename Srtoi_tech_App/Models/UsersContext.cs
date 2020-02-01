using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Srtoi_tech_App.Models
{
    public class UsersContext: DbContext
    {
        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<MyAdmin> MyAdmins { get; set; }
    }

    public class UsersDbInitializer: DropCreateDatabaseAlways<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            context.MyUsers.Add(new MyUser { UserName = "Nathalie", UserPswd = "natprot" });
            context.MyAdmins.Add(new MyAdmin { AdminName = "Alex", AdminPswd = "zartdru" });

            base.Seed(context);
        }
    }
}