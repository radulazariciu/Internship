using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samsung.BusinessLogic.BusinessLogic;
using Samsung.BusinessLogic.ViewModels;

namespace Samsung.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {

<<<<<<< HEAD
        //ShoppingBL.GetCart(id.Value);
=======
        ShoppingCartBL.GetShoppingCart();
>>>>>>> 9079e8b81ed9aa51e4a7bc031af98a25d22f8255
        
            return View();
        }

<<<<<<< HEAD

       /* [HttpPost]
        public ActionResult AddToCart(ShoppingCartItem i , User u )
=======
        [HttpPost]
        public ActionResult AddToCart(ShoppingCartItemVM shoppingCartItemVm)
>>>>>>> 9079e8b81ed9aa51e4a7bc031af98a25d22f8255
        {
            if (shoppingCartItemVm != null)
            {
                ShoppingCartBL.AddItem(shoppingCartItemVm);
            }

            return View(); 
        }*/

        public ActionResult Checkout(UserVM userVm)
        {
            ShoppingCartBL.SetUserToCart(userVm);
             return View(); 
        }
    }
<<<<<<< HEAD

    }
=======
}
>>>>>>> 9079e8b81ed9aa51e4a7bc031af98a25d22f8255
