using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.DataLayer.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public User User { get; set; }
        public float TotalPrice { get; set; }
        public List<ShoppingCartItem> ShoppingCartItemsList { get; set; }

        public ShoppingCart()
        {
            ShoppingCartItemsList = new List<ShoppingCartItem>();
        }
    }
}