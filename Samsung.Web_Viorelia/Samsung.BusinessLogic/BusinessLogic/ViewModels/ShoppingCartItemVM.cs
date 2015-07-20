﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class ShoppingCartItemVM
    {
        public int IdProduct { get; set; }
        public int Quantity { get; set; }

        public ShoppingCartItemVM(int quantity, int idProduct)
        {
            Quantity = quantity;
            IdProduct = idProduct;
        }

        public ShoppingCartItemVM()
        {
            
        }
    }
}