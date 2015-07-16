using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;

namespace Samsung.DataLayer.DataMappers
{
    public class ShoppingCartMapper
    {
        private List<ShoppingCartItem> shoppingCartList;

        public ShoppingCartMapper()
        {
            if (shoppingCartList == null)
            {
                shoppingCartList = new List<ShoppingCart>();
                Init();
            }
        }

        private void Init()
        {
            var p = new Product();
            p.Id = 2;
            p.Name = "Samsung Galaxy Note Edge";
            p.Category = "T-Mobile";
            p.Color = "black";
            p.Price = 550;
            p.Stock = 10;

            var p1 = new Product();
            p1.Id = 3;
            p1.Name = "Samsung Galaxy Note II ";
            p1.Category = "Sprint";
            p1.Color = "gray";
            p.Price = 850;
            p.Stock = 7;

            var sc = new ShoppingCart();
            sc.Id = 1;
            sc.ShoppingCartItemsList = new List<ShoppingCartItem>();
            var it = new ShoppingCartItem();
            it.IdProduct = 1;
            it.Quantity = 1;
            sc.ShoppingCartItemsList.Add(it);
            shoppingCartList.Add(sc);

            sc = new ShoppingCart();
            sc.Id = 2;
            sc.ShoppingCartItemsList = new List<ShoppingCartItem>();

            it = new ShoppingCartItem();
            it.IdProduct = 1;
            it.Quantity = 2;
            sc.ShoppingCartItemsList.Add(it);

            it = new ShoppingCartItem();
            it.IdProduct = 2;
            it.Quantity = 1;
            sc.ShoppingCartItemsList.Add(it);
            shoppingCartList.Add(sc);
        }

        public List<ShoppingCart> GetAllShoppingCart()
        {
            return shoppingCartList;
        }

        public ShoppingCart GetShoppingCart(int id)
        {
            var sh = shoppingCartList.Find(i => i.Id == id);
            return sh;
        }

        public void RemoveShoppingCart(int id)
        {
            var cart = shoppingCartList.Find(c => c.Id == id);
            shoppingCartList.Remove(cart);
        }

        public void AddShoppingCart(ShoppingCart sc)
        {
            shoppingCartList.Add(sc);
        }

        public void AddItemToUserCart(ShoppingCartItem i, User u)
        {

            var cart = shoppingCartList.Find(x => x.User.EmailAddress == u.EmailAddress);
            if (cart == null)
            {
                cart = new ShoppingCart();
                cart.User = u;
                cart.ShoppingCartItemsList.Add(i);
            }
        }
    }
}