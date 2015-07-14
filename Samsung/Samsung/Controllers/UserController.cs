using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samsung.Models;

using Samsung.Controllers.BusinessLogic;
using Samsung.Controllers.DataMappers;

namespace Samsung.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            var userBL = new UserBL();
            var list = userBL.GetAllUsers();
            return View(list);
        }

       //[HttpPost]
        public ActionResult LogIn(User model)
        {

            var userEmail = model.email;
            var userPassword = model.password;
       //    ViewBag.message("Numele: " + userPassword + "Parola: " + userEmail);

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn2(User user)
        {
            UserDM userMap = new UserDM();
            if (ModelState.IsValid)
            {
                if (userMap.checkUserLogin(user))
                {
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Login data is incorrect!");
            }
            return View(user);
        }

    }
}
