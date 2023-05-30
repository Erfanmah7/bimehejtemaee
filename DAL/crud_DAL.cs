using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class crud_DAL
    {

        db db = new db();
        public string create(Model h)
        {

            if (!read(h))
            {
                db.bimetable.Add(h);
                db.SaveChanges();
                return "ثبت نام با موفقیت انجام شد";
            }
            else
            {

                return "اطلاعات وارد شده تکراری است";

            }

        }


        public bool read(Model h)
        {
            db db1 = new db();
            var q = from i in db1.bimetable where i.codemeli == h.codemeli || i.shenasname == h.shenasname || i.shomarebime == h.shomarebime || i.shomarepersonely == h.shomarepersonely select i;
            if (q.Count() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool read(int id, Model h)
        {
            db db1 = new db();
            var q = from i in db1.bimetable where i.id != id && (i.codemeli == h.codemeli || i.shenasname == h.shenasname || i.shomarebime == h.shomarebime || i.shomarepersonely == h.shomarepersonely) select i;
            if (q.Count() >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Model> read(string h)
        {
            return db.bimetable.Where(x => x.name.Contains(h) || x.codemeli.Contains(h) || x.family.Contains(h)).ToList();
        }
        public List<Model> read()
        {

            return db.bimetable.ToList();
        }
        public Model read(int id)
        {
            try
            {
                return db.bimetable.Where(x => x.id == id).Single();
            }
            catch (Exception)
            {

                return null;

            }

        }
        public bool update(int id, Model hnew)
        {

            Model h = new Model();
            //if (!read(h))
            //{
            var q = from i in db.bimetable where i.id == id select i;
            if (q.Count() == 1)
            {
                //h = read(id);
                h = q.Single();
                h.shomarebime = hnew.shomarebime;
                h.shomarebime = hnew.shomarepersonely;
                h.name = hnew.name;
                h.family = hnew.family;
                h.namefather = hnew.namefather;
                h.shenasname = hnew.shenasname;
                h.codemeli = hnew.codemeli;
                h.date = hnew.date;
                h.job = hnew.job;
                h.mahalesodor = hnew.mahalesodor;
                h.jens = hnew.jens;
                h.meleyat = hnew.meleyat;
                db.SaveChanges();

                return true;
            }

            //}

            return false;

        }
        public string delete(int id)
        {

            try
            {
                Model h = read(id);
                db.bimetable.Remove(h);
                db.SaveChanges();
                return "حذف با موفقیت انجام شد";
            }
            catch (Exception)
            {

                return "هیچ فیلدی انتخاب نکردید";
            }


        }

    }
}
