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
        public ActionResult login()
        {
            return View();
        }
    }
}