using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class CustomerBAL
    {
        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "James";
            c.Address = "UK";
            c.Age = 25;
            return c;
        }
    }
}