﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewOnlineNoticeBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //this method is for showing admin and user buttons in view
        public ActionResult LoginDisplay()
        {
            return View();
        }

        public ActionResult LogOff()
        {
            Session.Clear();
            return Redirect("~/Home/Index");
        }
        public ActionResult ErrorPage()
        {
            return View();
        }
    }
}