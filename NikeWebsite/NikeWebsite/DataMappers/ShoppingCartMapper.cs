using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models.DataMappers
{
    public class ShoppingCartMapper
    {
        private ShoppingCart _shoppingCart = new ShoppingCart();

        public List<Product> GetProducts()
        {
            return _shoppingCart.Products;
        }
        public void AddProduct(Product p)
        {
            _shoppingCart.Products.Add(p);
        }
        public void RemoveProduct(int id)
        {
            var product = _shoppingCart.Products.FirstOrDefault(prod => prod.Id == id);
            if (product != null)
            {
                _shoppingCart.Products.Remove(product);
            }
        }
    }
}