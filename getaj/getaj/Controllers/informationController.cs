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
    public class informationController : Controller
    {
        // GET: information
        public ActionResult Index()
        {
            List<information> list = Class4.select();
            return View(list);
        }
        public ActionResult insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult insertmodel(information str)
        {
            if (Class4.insert(str) != 0)
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
            return View(Class4.updateli(id));
        }
        [HttpPost]
        public ActionResult updatemodel(information str)
        {
            if (Class4.updatemodel(str) != 0)
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
            Class4.delete(id);
            return RedirectToAction("Index");
        }


        public ActionResult Action()
        {
            return View();
        }
    }
}