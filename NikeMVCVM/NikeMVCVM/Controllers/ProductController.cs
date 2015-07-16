using Nike.Business.BusinessLogic;
using Nike.Business.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NikeMVCVM.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            var products = ProductBL.GetProducts();
            
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = ProductBL.GetProduct(id);
            var model = new ProductDetailsVM()
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                Description = product.Description,
                Price = product.Price
            };

            return View(model);
        }
    }
}
