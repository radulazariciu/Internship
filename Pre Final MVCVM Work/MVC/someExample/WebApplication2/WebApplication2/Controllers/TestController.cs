using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TestController : Controller
    {
        public String MyFirstMethod()
        {
            return "This is a test";
        }

        public ActionResult Index()
        {
            CustomerBAL b = new CustomerBAL();
            Customer c = b.GetCustomer();
            Customer d = new Customer();
            d.CustomerName = "alex";

            List<Customer> customers = new List<Customer>();
            customers.Add(c);
            customers.Add(d);
           // return View(customers);
            return View();
        }

        public ActionResult MyFirstViewMethod()
        {
            CustomerBAL b = new CustomerBAL();
            Customer c = b.GetCustomer();
            ViewBag.CustomerData = c;

            string custName = "john doe";
            ViewData["MyData"] = custName;
            //ViewBag.MyData = custName;
            return View("MyFirstView2");
        }

        private ShopContext db = new ShopContext(); 

        public ActionResult Abc()
        {
            var customers = db.customers.ToList();

            return View(customers);

        }

	}
}