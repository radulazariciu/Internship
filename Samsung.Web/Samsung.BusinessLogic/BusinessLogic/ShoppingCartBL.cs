using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.BusinessLogic.ViewModels;
using Samsung.DataLayer.DataMappers;
using Samsung.DataLayer.Models;

namespace Samsung.BusinessLogic.BusinessLogic
{
    public static class ShoppingCartBL
    {
       
        public static ShoppingCartVM GetShoppingCart(int id)
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            ShoppingCart shoppingCart = shoppingCartMapper.GetShoppingCart(id);
            shoppingCart.TotalPrice = TotalPrice(shoppingCart);
            LoginVM loginVm = new LoginVM(shoppingCart.User.EmailAddress, shoppingCart.User.Password);
            List<ShoppingCartItemVM> shoppingCartItemVmList = new List<ShoppingCartItemVM>();
            foreach (var shoppingCartItem in shoppingCart.ShoppingCartItemsList)
            {
               var shoppingCartItemVM=new ShoppingCartItemVM(shoppingCartItem.IdProduct, shoppingCartItem.Quantity);
                shoppingCartItemVmList.Add(shoppingCartItemVM);
            }
            
            ShoppingCartVM shoppingCartVM = new ShoppingCartVM(shoppingCart.Id, loginVm, shoppingCart.TotalPrice,shoppingCartItemVmList);
          
            return shoppingCartVM;
        }

        public static void AddItem(ShoppingCartItemVM shoppingCartItemVm, UserVM userVm)
        {
                
        }

        public static float TotalPrice(ShoppingCartVM shoppingCartVm)
        {
            float totalPrice = 0;
            foreach (var item in shoppingCartVm.ShoppingCartItemsList)
            {
                totalPrice += ItemPrice(item);
            }

            return totalPrice;
        }

        public static float ItemPrice(ShoppingCartItemVM shoppingCartItemVm)
        {
            ProductMapper productMapper = new ProductMapper();
            Product product = productMapper.GetProduct(shoppingCartItemVm.IdProduct);

            return product.Price * shoppingCartItemVm.Quantity;
        }
    }
}