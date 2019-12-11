using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demodal.model;

namespace Demodal
{
    public class Class1
    {
        public static List<trashtype> select()
        {
            Model1 mo = new Model1();
            List<trashtype> list = mo.trashtype.ToList();
            return list;
        }

        public static usertable longin(string name,string pwd)
        {
            Model1 mo = new Model1();
            List<usertable> lis = mo.usertable.ToList();
            usertable li = lis.FirstOrDefault(p => p.userName==name && p.userWord==pwd);
            return li;
        }
    }
}
