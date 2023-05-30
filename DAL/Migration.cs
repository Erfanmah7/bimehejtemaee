using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//مایگریشن
using System.Data.Entity.Migrations;

namespace DAL
{
    //تغییرات مایگریشن رو کدوم کلاس دیتابیس انجام بشه
    class Migration : DbMigrationsConfiguration<db>
    {

        public Migration()
        {
            //افزودنی
            AutomaticMigrationsEnabled = true;
            //حذفیدنی
            AutomaticMigrationDataLossAllowed = true;
        }

    }
}
//اگه خطا خوردی یبار دیتابیس رو تو اسکیوال پاک کن
