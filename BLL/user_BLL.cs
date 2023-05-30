using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL
{
   public class user_BLL
    {

        user_DAL dal = new user_DAL();

        //public bool sql()
        //{

        //    dal.sql();
        //    return true;

        //}

        public int ReadIDUser(string username)
        {
            return dal.ReadIDUser(username);
        }
        public byte Login(string username, string password)
        {
            return dal.Login(username, password);
        } 
        public bool read(User_Login h)
        {
            return dal.read(h);
        }
        public bool update(int id,User_Login user)
        {
                dal.update(id,user);
                return true;
        }
        public bool readPassOld(int id,string password)
        {
            return dal.readPassOld(id,password);
        }
        public void Register(User_Login u)
        {
            dal.Register(u);
        }

    }
}
