using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using CMSSite.Models.Pages;

namespace CMSSite.Controllers
{
    public class PDPController : PageController<PDP>
    {
        public ActionResult Index(PDP currentPage)
        {
            

            return View(currentPage);
        }
    }
}