using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using BE;

namespace DAL
{
   public class user_DAL
    {

        db db = new db();
        public byte Login(string username, string password)
        {
            if (db.Users.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (db.Users.Any(i => i.UserName == username && i.Password == password))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

       //public void sql()
       // {



       //     //DROP TABLE User_Login GO DROP TABLE __MigrationHistory GO DROP TABLE Model1 GO DROP TABLE Models
       //     SqlConnection sqlcon = new SqlConnection("Data Source=.;Initial Catalog=bimyar;Integrated Security=true");
       //     SqlCommand sqlcom = new SqlCommand();
       //     sqlcom.Connection = sqlcon;
       //     sqlcom.CommandText = "DROP TABLE [dbo].[User_Login] GO DROP TABLE[dbo].[__MigrationHistory] GO DROP TABLE[dbo].[Models] GO DROP TABLE[dbo].[Model1]";

       //     if (sqlcon.State == System.Data.ConnectionState.Closed)
       //     {

       //         sqlcon.Open();
       //         sqlcom.ExecuteNonQuery();

       //     }


       // }

        public void Register(User_Login u)
        {
            db.Users.Add(u);
            db.SaveChanges();
        }


        //////////////////////////////////////////////////////////////////////


        public bool read(User_Login h)
        {

            var q = db.Users.Where(x => x.id == h.id).Single();
            if (q.id == 1)
            {
                return true;
            }
            return false;
        }
        public int ReadIDUser(string username)
        {
            return db.Users.Where(i => i.UserName == username).Select(i=>i.id).SingleOrDefault();
        }
        public bool readPassOld(int id,string password)
        {
            return db.Users.Any(i => i.id == id && i.Password==password);
        }
        public string update(int id,User_Login user)
        {
            var q = from i in db.Users where i.id == id select i;
            if (q.Count() == 1)
            {
                User_Login h = new User_Login();
                h = q.Single();
                h.Name = user.Name;
                h.UserName = user.UserName;
                h.Password = user.Password;
                db.SaveChanges();
                return "اطلاعات کاربری با موفقیت تغییر یافت";

            }

            return "اطلاعات انجام نشد";



            }



        }
}
