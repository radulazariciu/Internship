﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestControllersAndViews.Controllers
{
    public class userController : Controller
    {
        //
        // GET: /user/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search() 
        {

            return View();
        }
    }
}
