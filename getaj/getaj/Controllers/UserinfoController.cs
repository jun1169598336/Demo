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
    public class UserinfoController : Controller
    {
        // GET: Userinfo
        public ActionResult Index()
        {
            List<usertable> list = Class3.select();
            return View(list);
        }
        public ActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertmodel(usertable str)
        {
            if (Class3.insert(str) != 0)
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
            return View(Class3.updateli(id));
        }
        [HttpPost]
        public ActionResult updatemodel(usertable str)
        {
            if (Class3.updatemodel(str) != 0)
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
            Class3.delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Action()
        {
            return View();
        }
    }
}