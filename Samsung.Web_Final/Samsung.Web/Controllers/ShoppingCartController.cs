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
            ShoppingCartVM shoppingCartVM = ShoppingCartBL.GetShoppingCart();
            return View(shoppingCartVM);
        }

        [HttpPost]
        public ActionResult AddToCart(ShoppingCartItemVM shoppingCartItemVm)
        {
            if (shoppingCartItemVm != null)
            {
                var success = ShoppingCartBL.AddItem(shoppingCartItemVm);
                if (success)
                    return View();
            }

            return RedirectToAction("WrongStock");
        }

        public ActionResult ShoppingCart()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateItem(ShoppingCartItemVM shoppingCartItemVM)
        {

            ShoppingCartBL.UpdateItem(shoppingCartItemVM);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveItem(int idProduct)
        {
            ShoppingCartBL.RemoveItem(idProduct);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Checkout()
        {
            ShoppingCartBL.PayOrder();
            return View();
        }

        public ActionResult WrongStock()
        {
            return View();
        }
    }
}