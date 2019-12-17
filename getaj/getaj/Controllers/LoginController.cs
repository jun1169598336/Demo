using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using getajdal;
using getajdal.model;
using Newtonsoft.Json;

namespace getaj.Controllers
{
    /// <summary>
    /// 可匿名
    /// </summary>
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult LoginIn(string name,string pwd)
        {
            usertable user = Class1.loginIn(name, pwd);
            JsonResult jsonResult = new JsonResult();
            if (user != null)
            {
                string json = JsonConvert.SerializeObject(user);
                HttpCookie cookie = new HttpCookie("login", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json)));
                Response.Cookies.Add(cookie);
                jsonResult.Data = new { data = json, state = "200" };
                jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
                return jsonResult;
            }
            else
            {
                jsonResult.Data = new { data = "未找到该用户", state = "403" };
                return jsonResult;
            }
        }
    }
}