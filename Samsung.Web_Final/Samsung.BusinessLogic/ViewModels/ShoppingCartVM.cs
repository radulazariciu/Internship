using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class ShoppingCartVM
    {
        private int p1;
        private float p2;
        private List<ShoppingCartItemDetailVM> shoppingCartItemVmList;

        public int Id { get; set; }
        public LoginVM UserCredentials { get; set; }
        public float TotalPrice { get; set; }
        public List<ShoppingCartItemDetailVM> ShoppingCartItemDetailList { get; set; }

        public ShoppingCartVM(int id, LoginVM userCredentials, float totalPrice, List<ShoppingCartItemDetailVM> shoppingCartItemDetailList)
        {
            Id = id;
            UserCredentials = userCredentials;
            TotalPrice = totalPrice;
            ShoppingCartItemDetailList = shoppingCartItemDetailList;
        }

        public ShoppingCartVM()
        {

        }

        public ShoppingCartVM(int p1, float p2, List<ShoppingCartItemDetailVM> shoppingCartItemList)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.shoppingCartItemVmList = shoppingCartItemVmList;
        }
    }
}