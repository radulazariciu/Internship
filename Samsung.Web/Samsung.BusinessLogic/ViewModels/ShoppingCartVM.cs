using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class ShoppingCartVM
    {
        public int Id { get; set; }
        public LoginVM UserCredentials { get; set; }
        public float TotalPrice { get; set; }
        public List<ShoppingCartItemVM> ShoppingCartItemsList { get; set; }

        public ShoppingCartVM(int id, LoginVM userCredentials, float totalPrice, List<ShoppingCartItemVM> shoppingCartItemsList)
        {
            Id = id;
            UserCredentials = userCredentials;
            TotalPrice = totalPrice;
            ShoppingCartItemsList = shoppingCartItemsList;
        }
    }
}