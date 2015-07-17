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

        ShoppingCartBL.GetShoppingCart();
        
            return View();
        }

        [HttpPost]
        public ActionResult AddToCart(ShoppingCartItemVM shoppingCartItemVm)
        {
            if (shoppingCartItemVm != null)
            {
                ShoppingCartBL.AddItem(shoppingCartItemVm);
            }

            return View(); 
        }

        public ActionResult Checkout(UserVM userVm)
        {
            ShoppingCartBL.SetUserToCart(userVm);
             return View(); 
        }
    }
}