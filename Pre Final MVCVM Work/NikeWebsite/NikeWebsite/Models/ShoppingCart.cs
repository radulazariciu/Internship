using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
        public User Customer { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
    }
}