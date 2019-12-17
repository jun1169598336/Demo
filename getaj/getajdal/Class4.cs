using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Data.Core;
using getajdal.model;

namespace getajdal
{
    public class Class4
    {
        public static List<information> select()
        {

            Model1 mo = new Model1();
            List<information> list = mo.information.ToList();
            return list;

        }
        public static int insert(information str)
        {
            Model1 mo = new Model1();
            mo.information.Add(str);
            return mo.SaveChanges();

        }
        public static information updateli(int id)
        {

            Model1 mo = new Model1();
            return mo.information.FirstOrDefault(p => p.infoId == id);
        }
        public static int updatemodel(information str)
        {
            Model1 mo = new Model1();
            mo.Entry(str).State = System.Data.Entity.EntityState.Modified;
            return mo.SaveChanges();
        }
        public static int delete(int id)
        {
            Model1 mo = new Model1();
            information list = mo.information.FirstOrDefault(p => p.infoId == id);
            mo.Entry(list).State = System.Data.Entity.EntityState.Deleted;
            return mo.SaveChanges();
        }
    }
}
