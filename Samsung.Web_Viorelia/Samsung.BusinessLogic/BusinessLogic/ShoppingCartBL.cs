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
       
        public static ShoppingCartVM GetShoppingCart()
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            ShoppingCart shoppingCart = shoppingCartMapper.GetShoppingCart();
            shoppingCart.TotalPrice = TotalPrice(shoppingCart);
            //LoginVM loginVm = new LoginVM(shoppingCart.User.EmailAddress, shoppingCart.User.Password);
            LoginVM loginVm = new LoginVM("Ceva", "parola");
            List<ShoppingCartItemDetailVM> shoppingCartItemVmList = new List<ShoppingCartItemDetailVM>();
            foreach (var shoppingCartItem in shoppingCart.ShoppingCartItemsList)
            {
                var shoppingCartItemDetailVM=new ShoppingCartItemDetailVM();
                shoppingCartItemDetailVM.Product = ProductBL.GetProduct(shoppingCartItem.IdProduct);
                shoppingCartItemDetailVM.Quantity = shoppingCartItem.Quantity;
                shoppingCartItemVmList.Add(shoppingCartItemDetailVM);
            }
            
            ShoppingCartVM shoppingCartVM = new ShoppingCartVM(shoppingCart.Id, loginVm, shoppingCart.TotalPrice,shoppingCartItemVmList);
          
            return shoppingCartVM;
        }


        public static void AddItem(ShoppingCartItemVM shoppingCartItemVm)
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem(shoppingCartItemVm.IdProduct, shoppingCartItemVm.Quantity);
            shoppingCartMapper.AddShoppingCartItem(shoppingCartItem);
        }

        public static void UpdateItem(ShoppingCartItemVM shoppingCartItemVm)
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            ShoppingCartItem shoppingCartItem = new ShoppingCartItem(shoppingCartItemVm.IdProduct, shoppingCartItemVm.Quantity);
            shoppingCartMapper.UpdateShoppingCartItem(shoppingCartItem);
        }

        public static void RemoveItem(int idProduct)
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            shoppingCartMapper.RemoveShoppingCartItem(idProduct);
        }

        public static void SetUserToCart(UserVM userVm)
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            User user = new User(userVm.EmailAddress, userVm.Password);
            shoppingCartMapper.SetUserToShoppingCart(user);
        }

        public static void PayOrder()
        {
            ShoppingCartMapper shoppingCartMapper = new ShoppingCartMapper();
            shoppingCartMapper.AddOrder();
            shoppingCartMapper.ClearShoppingCart();
        }

        public static float TotalPrice(ShoppingCart shoppingCart)
        {
            float totalPrice = 0;
            foreach (var item in shoppingCart.ShoppingCartItemsList)
            {
                totalPrice += ItemPrice(item);
            }

            return totalPrice;
        }

        public static float ItemPrice(ShoppingCartItem shoppingCartItem)
        {
            ProductMapper productMapper = new ProductMapper();
            Product product = productMapper.GetProduct(shoppingCartItem.IdProduct);

            return product.Price * shoppingCartItem.Quantity;
        }
    }
}