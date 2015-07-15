﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nike.Business.ViewModels;
using Nike.Business.BusinessLogic;

namespace NikeMVCVM.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM loginVm)
        {
            Boolean success;
            success =  UserBL.CheckCredentials(loginVm);
            if (success)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
