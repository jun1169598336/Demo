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
    }
}
