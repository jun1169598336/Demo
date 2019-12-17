using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using getajdal;
using getajdal.model;
using HPIT.Data.Core;
using HPIT.Survey.Portal.Filters;
using Newtonsoft.Json;

namespace getaj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<trashtype> list = Class1.select();
            return View(list);
        }
        public ActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertmodel(trashtype str)
        {
            if (Class1.insert(str) != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("insert");
            }
        }

        public ActionResult update(int id)
        {
            return View(Class1.updateli(id));
        }
        [HttpPost]
        public ActionResult updatemodel(trashtype str)
        {
            if (Class1.updatemodel(str) != 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("update");
            }
        }
        public ActionResult delete(int id)
        {
            Class1.delete(id);
            return RedirectToAction("Index");
        }
        
           public DeluxeJsonResult QueryPageData(SearchModel<trashtype> search)
        {

            int total = 0;
            var result = Class1.Instance.GetPageData(search, out total);
            var totalPages = total % search.PageSize == 0 ? total / search.PageSize : total / search.PageSize + 1;
            return new DeluxeJsonResult(new { Data = result, Total = total, TotalPages = totalPages }, "yyy-MM-dd HH:mm");
        }

        public ActionResult Action()
        {
            return View();
        }

    }
}