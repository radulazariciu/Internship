using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC_Operations_Users.Models;

namespace CRUD_MVC_Operations_Users.Controllers
{
    public class userController : Controller
    {
        //
        // GET: /user/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewUsers() 
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult EditUser()
        {
            return View();
        }

        public ActionResult DeleteUser()
        {
            return View();
        }
    }
}
