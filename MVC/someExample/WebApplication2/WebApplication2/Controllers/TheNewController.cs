using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication2.Controllers
{
    public class TheNewController : Controller
    {
        //
        // GET: /TheNew/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FirstOption()
        {
            return View("FirstOptionView");
        }

        //[Authorize]
        public ActionResult SecondOption()
        {
            return RedirectPermanent("http://wiki.com");
        }

        [HttpGet]
        public ActionResult ThirdOption()
        {
            var message = "this is the MESSAGE var";
            return Content(message);
        }
	}
}