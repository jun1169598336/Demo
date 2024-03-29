﻿using Demodal;
using Demodal.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult loginIn(string name, string pwd)
        {
            usertable user = Class1.longin(name, pwd);
            JsonResult jsonResult = new JsonResult();
            if (user != null)
            {
                string json = JsonConvert.SerializeObject(user);
                //HttpCookie cookie = new HttpCookie("login", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json)));
                //Response.Cookies.Add(cookie);
                jsonResult.Data = new { data = json, state = "200" };
                jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
                return jsonResult;
            }
            else
            {
                jsonResult.Data = new {data="未找到该用户",state = "403" };
                return jsonResult;
            }
        }

        public ActionResult logOff()
        {
            Request.Cookies.Clear();
            Response.Cookies.Clear();
            return View("Index");
        }
    }
}