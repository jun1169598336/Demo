using getajdal.model;
using HPIT.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getajdal
{
    public class Class1
    {
        public static Class1 Instance = new Class1();
        public static List<trashtype> select()
        {

            Model1 mo = new Model1();
            List<trashtype> list = mo.trashtype.ToList();
            return list;

        }

        public static usertable loginIn(string name, string pwd)
        {
            Model1 mo = new Model1();
            List<usertable> list = mo.usertable.ToList();
            usertable li = list.FirstOrDefault(p => p.userName == name && p.userWord == pwd);
            return li;

        }

        public static int insert(trashtype str)
        {
            Model1 mo = new Model1();
            mo.trashtype.Add(str);
            return mo.SaveChanges();

        }

        public static trashtype updateli(int id)
        {

            Model1 mo = new Model1();
            return mo.trashtype.FirstOrDefault(p => p.typeId == id);
        }
        public static int updatemodel(trashtype str)
        {
            Model1 mo = new Model1();
            mo.Entry(str).State = System.Data.Entity.EntityState.Modified;
            return mo.SaveChanges();
        }
        public static int delete(int id)
        {
            Model1 mo = new Model1();
            trashtype list = mo.trashtype.FirstOrDefault(p => p.typeId == id);
            mo.Entry(list).State = System.Data.Entity.EntityState.Deleted;
            return mo.SaveChanges();
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="search"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public object GetPageData(SearchModel<trashtype> search, out int count)
        {
            GetPageListParameter<trashtype, int> parameter = new GetPageListParameter<trashtype, int>();
            parameter.isAsc = true;
            parameter.orderByLambda = t => t.typeId;
            parameter.pageIndex = search.PageIndex;
            parameter.pageSize = search.PageSize;
            parameter.whereLambda = t => t.typeId != 0;
            Model1 Instance = new Model1();
            DBBaseService baseService = new DBBaseService(Instance);
            List<trashtype> list = baseService.GetSimplePagedData<trashtype, int>(parameter, out count);
            return list;
        }


    }
}
