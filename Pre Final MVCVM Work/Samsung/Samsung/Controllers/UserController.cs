using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samsung.Models;
<<<<<<< HEAD
using Samsung.Models.BusinessLogic;
=======

using Samsung.Controllers.BusinessLogic;
using Samsung.Controllers.DataMappers;
>>>>>>> 88e733912c7fd449e56c94f6fe867a5f49ca79fa

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

        public ActionResult SignUpUser()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string FirstName,string SecondName,string Month,string Day,string BirthYear,string EmailAddress,string ConfirmEmailAddress,string FirstPartCellPhone,
                                   string SecondPartCellPhone,string ThirdPartCellPhone,string ZipCode,string Password,string ConfirmPassword)
        {
            UserBL userBL = new UserBL();
            userBL.AddUser(FirstName, SecondName, Month, Day, BirthYear, EmailAddress, ConfirmEmailAddress, FirstPartCellPhone, SecondPartCellPhone, ThirdPartCellPhone, ZipCode, Password, ConfirmPassword);
            return View("SignUpUser", userBL);
        }
    }
}
