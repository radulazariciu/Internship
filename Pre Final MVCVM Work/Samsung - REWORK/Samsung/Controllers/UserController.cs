using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samsung.Models;
using Samsung.Models.BusinessLogic;

namespace Samsung.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
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


        public ActionResult LogIn(string email, string password)
        {
            UserBL userBL = new UserBL();
            userBL.verifyCredentials(email,password);
            return View();
        }
    }
}
