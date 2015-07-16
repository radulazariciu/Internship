using NikeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.BusinessLogic
{
    public class ShoppingCartBL
    {
       
        public decimal CalcTotalPrice(ShoppingCart cart)
        {
            decimal totalPrice = 0;
            foreach (var item in cart.Items)
            {
                totalPrice = item.Item.Price * item.Quantity;
            }
            return totalPrice;
        }
    }
}