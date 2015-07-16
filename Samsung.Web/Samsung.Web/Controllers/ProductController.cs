using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Samsung.Web.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var prodBL = new ProductBL();
            var list = prodBL.CategoryProducts();
            return View(list);
        }

        //GET: /Product/Details/3
        public ActionResult Details(int? id)
        {
            var prodBL = new ProductBL();
            var prod = prodBL.GetProduct(id.Value);
            return View(prod);
        }

        public ActionResult Edit(int? id)
        {
            var prodBL = new ProductBL();
            var prod = prodBL.GetProduct(id.Value);
            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(Product p = null)
        {
            var prodBL = new ProductBL();
            prodBL.Edit(p);
            return RedirectToAction("Index");
        }

        public ActionResult ShoppingCart(int id = 0)
        {
            return RedirectToAction("Shopping/Index");
        }


    }
}
