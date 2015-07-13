using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }

    }
}