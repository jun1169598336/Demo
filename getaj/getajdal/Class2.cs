using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HPIT.Data.Core;
using getajdal.model;

namespace getajdal
{
    public class Class2
    {
        public static List<DutyInfo> select()
        {

            Model1 mo = new Model1();
            List<DutyInfo> list = mo.DutyInfo.ToList();
            return list;

        }
        public static int insert(DutyInfo str)
        {
            Model1 mo = new Model1();
            mo.DutyInfo.Add(str);
            return mo.SaveChanges();

        }
        public static DutyInfo updateli(int id)
        {

            Model1 mo = new Model1();
            return mo.DutyInfo.FirstOrDefault(p => p.DutyId == id);
        }
        public static int updatemodel(DutyInfo str)
        {
            Model1 mo = new Model1();
            mo.Entry(str).State = System.Data.Entity.EntityState.Modified;
            return mo.SaveChanges();
        }
        public static int delete(int id)
        {
            Model1 mo = new Model1();
            DutyInfo list = mo.DutyInfo.FirstOrDefault(p => p.DutyId == id);
            mo.Entry(list).State = System.Data.Entity.EntityState.Deleted;
            return mo.SaveChanges();
        }
    }
}
