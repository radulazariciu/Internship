using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestControllersAndViews.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting =
            hour < 12
            ? "Good Morning. Time is" + DateTime.Now.ToShortTimeString()
            : "Good Afternoon. Time is " + DateTime.Now.ToShortTimeString();

            return View();
        }

        [HttpPost]
        public ActionResult Search(string FirstName)
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting = FirstName;
            return View();
        }

    }
}
