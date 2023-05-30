using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using DAL;

namespace BLL
{
    public class crud_BLL
    {

        public int age;
        crud_DAL dal = new crud_DAL();
        public int datechangeage(string date)
        {
            #region date
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //}
            //else
            //{
            //MessageBox.Show("سنتان را درست وارد کنید");
            //}

            //try
            //{
            //    //کد تبدیل تاریخ تولد به سن
            //string yearnow = DateTime.Now.ToString("yyyy");
            //string datetavalodshams = date;
            //string[] date3 = datetavalodshams.Split('/');
            //int datetavalodmilad = int.Parse(date3[0]) + 621;
            //int datenow = int.Parse(yearnow);
            //age = datenow - datetavalodmilad;
            //}
            //catch (Exception) { }
            #endregion

            string d = date;
            string mm = d.Substring(0, 4);
            string yearnow = DateTime.Now.ToString("yyyy");
            string datetavalodshams = mm;
            string[] date3 = datetavalodshams.Split('/');
            int datetavalodmilad = int.Parse(date3[0]) + 621;
            int datenow = int.Parse(yearnow);
            age = datenow - datetavalodmilad;
            return age;
        }
        public bool create(Model h)
        {


            if (age >= 18)
            {
                dal.create(h);
                return true;
            }
            else
            {

                return false;

            }


        }
        public bool read(Model h)
        {

            return dal.read(h);
        }
        public bool read(int id, Model h)
        {

            return dal.read(id, h);
        }
        public List<Model> read(string h)
        {
            return dal.read(h);
        }
        public List<Model> read()
        {

            return dal.read();
        }
        public Model read(int id)
        {

            return dal.read(id);
        }
        public bool update(int id, Model hnew)
        {
            return dal.update(id, hnew);
        }
        public string delete(int id)
        {

            return dal.delete(id);

        }

    }
}
