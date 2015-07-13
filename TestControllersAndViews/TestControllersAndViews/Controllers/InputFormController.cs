using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestControllersAndViews.Controllers
{
    public class InputFormController : Controller
    {
        //
        // GET: /InputForm/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Input(string id)
        {

            return View();
        }
    }
}
