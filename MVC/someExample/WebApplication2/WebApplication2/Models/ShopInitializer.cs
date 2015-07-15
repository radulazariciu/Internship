using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var customers = new List<Customer>
            {
                new Customer {CustomerName = "ana", Address = "us", Age = 33},
                new Customer {CustomerName = "dan", Address = "uk", Age = 32}
            };

            foreach (var temp in customers)
            {
                context.customers.Add(temp);
            }
            context.SaveChanges();
        }
    }
}