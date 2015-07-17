using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;

namespace Samsung.DataLayer.DataMappers
{
    public class ShoppingCartMapper
    {
<<<<<<< HEAD
      /*  private List<ShoppingCartItem> shoppingCartList;
=======
        private ShoppingCart shoppingCart;
>>>>>>> 9079e8b81ed9aa51e4a7bc031af98a25d22f8255

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
<<<<<<< HEAD

            var cart = shoppingCartList.Find(x => x.User.EmailAddress == u.EmailAddress);
            if (cart == null)
            {
                cart = new ShoppingCart();
                cart.User = u;
                cart.ShoppingCartItemsList.Add(i);
            }
        }*/
=======
            shoppingCart.ShoppingCartItemsList.Add(sc);
        }
>>>>>>> 9079e8b81ed9aa51e4a7bc031af98a25d22f8255
    }
}