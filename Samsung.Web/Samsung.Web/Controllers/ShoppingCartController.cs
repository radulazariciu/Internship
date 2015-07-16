using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Samsung.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {

        ShoppingBL.GetCart(id.Value);
        
            return View();
        }


        [HttpPost]
        public ActionResult AddToCart(ShoppingCartItem i , User u )
        {
            if (i != null)
            {
                var shopBL = new ShoppingBL();
                shopBL.AddItem(i, u);
            }

            return View(); 
        }

        public ActionResult Checkout()
        {
             return View(); 
        }
    }

    }
}
