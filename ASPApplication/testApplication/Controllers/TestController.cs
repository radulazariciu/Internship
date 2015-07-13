using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testApplication.Models;

namespace testApplication.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult PressButton()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(string input1, string input2)
        {
            Model model = new Model();
            int sum = model.GetSum(Int32.Parse(input1), Int32.Parse(input2));
            return View();
        }

    }
}
