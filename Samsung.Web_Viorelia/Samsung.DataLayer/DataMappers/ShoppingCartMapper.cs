using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;

namespace Samsung.DataLayer.DataMappers
{
    public class ShoppingCartMapper
    {
        private static ShoppingCart shoppingCart=null;

        public ShoppingCartMapper()
        {
            if (shoppingCart == null)
            {
                shoppingCart = new ShoppingCart();
            }
        }

        public void SetUserToShoppingCart(User user)
        {
            shoppingCart.User = user;
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

        public void AddShoppingCartItem(ShoppingCartItem shoppingCartItem)
        {
            shoppingCart.ShoppingCartItemsList.Add(shoppingCartItem);
        }

        public void UpdateShoppingCartItem(ShoppingCartItem shoppingCartItem)
        {
            var updateShoppingCartItem = shoppingCart.ShoppingCartItemsList.Find(i => i.IdProduct == shoppingCartItem.IdProduct);
            updateShoppingCartItem.Quantity = shoppingCartItem.Quantity;
        }

        public void ClearShoppingCart()
        {
            shoppingCart = null;
        }

        public void AddOrder()
        {
            var productMapper = new ProductMapper();
            var order = new Samsung_Order();
            order.userId = 4;
            order.totalPrice = Convert.ToInt32(shoppingCart.TotalPrice);

            using (var db = new EntitySamsung())
            {
                db.Samsung_Order.Add(order);
                db.SaveChanges();

                foreach (var item in shoppingCart.ShoppingCartItemsList)
                {
                    var orderItem = new Samsung_OrderItem();
                    orderItem.orderId = order.id;
                    orderItem.productId = item.IdProduct;
                    orderItem.quantity = item.Quantity;
                    db.Samsung_OrderItem.Add(orderItem);

                    productMapper.EditStockProduct(item.IdProduct, item.Quantity);
                    
                    db.SaveChanges();
                }
            }
        }
    }
}