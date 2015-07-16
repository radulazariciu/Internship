using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;

namespace Samsung.DataLayer.DataMappers
{
    public class ShoppingCartMapper
    {
        private ShoppingCart shoppingCart;

        public void SetUserToShoppingCart(User user)
        {
            shoppingCart.User = user;
        }

        public ShoppingCartMapper()
        {
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart();
            }
        }

        public ShoppingCart GetShoppingCart()
        {
            return shoppingCart;
        }

        public ShoppingCartItem GetShoppingCartItem(int idProduct)
        {
            var item = shoppingCart.ShoppingCartItemsList.Find(i => i.IdProduct == idProduct);
            return item;
        }

        public void RemoveShoppingCartItem(int idProduct)
        {
            var item = shoppingCart.ShoppingCartItemsList.Find(i => i.IdProduct == idProduct);
            shoppingCart.ShoppingCartItemsList.Remove(item);
        }

        public void AddShoppingCartItem(ShoppingCartItem sc)
        {
            shoppingCart.ShoppingCartItemsList.Add(sc);
        }
    }
}