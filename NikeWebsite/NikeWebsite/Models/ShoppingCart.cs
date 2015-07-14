using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Products { get; set; }
        public List<User> Users { get; set; }
        public decimal TotalPrice { get; set; }
    }
}