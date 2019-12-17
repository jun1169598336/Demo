using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Data.Core;
using getajdal.model;

namespace getajdal
{
    public class Class3
    {
        public static List<usertable> select()
        {

            Model1 mo = new Model1();
            List<usertable> list = mo.usertable.ToList();
            return list;

        }
        public static int insert(usertable str)
        {
            Model1 mo = new Model1();
            mo.usertable.Add(str);
            return mo.SaveChanges();

        }
        public static usertable updateli(int id)
        {

            Model1 mo = new Model1();
            return mo.usertable.FirstOrDefault(p => p.userId == id);
        }
        public static int updatemodel(usertable str)
        {
            Model1 mo = new Model1();
            mo.Entry(str).State = System.Data.Entity.EntityState.Modified;
            return mo.SaveChanges();
        }
        public static int delete(int id)
        {
            Model1 mo = new Model1();
            usertable list = mo.usertable.FirstOrDefault(p => p.userId == id);
            mo.Entry(list).State = System.Data.Entity.EntityState.Deleted;
            return mo.SaveChanges();
        }
    }
}
