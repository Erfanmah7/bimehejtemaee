using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE;

namespace DAL
{
    class db:DbContext
    {

        public db():base("bime")  {
            //اتصال مایگریشن به دیتابیس
            //برو به آخرین تغییرات مایگریشن دیتابیس
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<db, Migration>());
        }
        public DbSet<Model> bimetable { get; set; }
        public DbSet<Model1> bimekargah { get; set; }
        public DbSet<User_Login> Users { get; set; }

    }
}
