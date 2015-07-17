using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samsung.BusinessLogic.ViewModels;
using Samsung.BusinessLogic.BusinessLogic;

namespace Samsung.Web.Controllers
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
            Boolean success = UserBL.CheckCredentials(loginVm);
            if (success)
            {
                return RedirectToAction("Index", "Product");
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterVM registerVm)
        {
            Boolean success = UserBL.RegisterUser(registerVm);
            if (success)
            {
                return RedirectToAction("Login", "User");
            }
            return View();
        }

        public ActionResult LoginFailed()
        {
           
            return View();
        }

    }
}
