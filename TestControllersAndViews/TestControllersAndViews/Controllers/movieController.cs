using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestControllersAndViews.Controllers
{
    public class movieController : Controller
    {
        //
        // GET: /movie/

        public ActionResult Index()
        {
            return View();
        }



    }
}
