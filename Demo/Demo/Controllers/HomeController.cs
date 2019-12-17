using Demodal.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demodal;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<trashtype> list = Class1.select();
            //ViewBag.Name = Class1.se().Select(m => new SelectListItem() { Text = m.DutyName, Value = m.DutyId.ToString() }).ToList();
            return View(list);
        }

        public ActionResult insert()
        {
            return View();
        }

        [HttpGet]
        public int insertmod(string name, string wei, string chu)
        {
            trashtype str = new trashtype();
            str.typeName = name;
            str.typeHarm = wei;
            str.typeWay = chu;
            int t1 = Class1.insert(str);
            //JsonResult jsonResult = new JsonResult();
            if (t1 != 0)
            {
                return t1;
            }
            else
                return t1;
        }


    }
}