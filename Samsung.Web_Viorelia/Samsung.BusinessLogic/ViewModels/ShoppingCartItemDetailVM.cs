using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class ShoppingCartItemDetailVM
    {
        public ProductVM Product { get; set; }
        public int Quantity { get; set; }
    }
}