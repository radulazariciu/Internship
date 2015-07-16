using NikeWebsite.BusinessLogic;
using NikeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NikeWebsite.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ShoppingCart _shoppingCart = new ShoppingCart();
        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {
            var helper = new ShoppingCartBL();
            _shoppingCart.TotalPrice = helper.CalcTotalPrice(_shoppingCart);
            var model = _shoppingCart;                            
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Message(ShoppingCartItem item)
        {
            _shoppingCart.Items.Add(item);
            return View();
        }
        //
        // GET: /ShoppingCart/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ShoppingCart/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ShoppingCart/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ShoppingCart/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ShoppingCart/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ShoppingCart/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ShoppingCart/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
