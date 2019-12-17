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
    public class ZZZController : Controller
    {
        // GET: ZZZ
        public ActionResult Index()
        {
            List<DutyInfo> list = Class2.select();
            return View(list);
        }
        public ActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertmodel(DutyInfo str)
        {
            if (Class2.insert(str) != 0)
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
            return View(Class2.updateli(id));
        }
        [HttpPost]
        public ActionResult updatemodel(DutyInfo str)
        {
            if (Class2.updatemodel(str) != 0)
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
            Class2.delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Action()
        {
            return View();
        }
    }
}