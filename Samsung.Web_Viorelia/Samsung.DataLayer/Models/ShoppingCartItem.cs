﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.DataLayer.Models
{
    public class ShoppingCartItem
    {
       public int IdProduct { get; set; }
       public int Quantity { get; set; }

       public ShoppingCartItem(int idProduct, int quantity)
       {
           IdProduct = idProduct;
           Quantity = quantity;
       }

        public ShoppingCartItem()
        {
            
        }
    }
}