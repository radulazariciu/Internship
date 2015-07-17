using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Samsung.BusinessLogic.ViewModels;
using Samsung.BusinessLogic.BusinessLogic;
namespace Samsung.Web.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var listProductVM = ProductBL.GetAllProducts();
            return View(listProductVM);
        }

        //GET: /Product/Details/3
        public ActionResult Details(int? id)
        {
            var prodVm = ProductBL.GetProduct(id.Value);
            return View(prodVm);
        }

        public ActionResult Edit(int? id)
        {
            var prod = ProductBL.GetProduct(id.Value);
            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(ProductVM productVm)
        {
            ProductBL.EditProduct(productVm);
            return RedirectToAction("Index");
        }

    }
}
