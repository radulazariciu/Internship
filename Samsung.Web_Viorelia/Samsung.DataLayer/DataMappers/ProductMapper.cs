using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;
namespace Samsung.DataLayer.DataMappers
{
    public class ProductMapper
    {

        private static int CATEGORYNOTFOUND = -1;

        public ProductMapper()
        {

        }



        private int getCategoryId(string categoryName)
        {
            using (var db = new EntitySamsung())
            {
                foreach (var item in db.Samsung_Category.ToList())
                {
                    if (item.name.Equals(categoryName))
                    {
                        return item.id;
                    }
                }
            }

            return CATEGORYNOTFOUND;

        }

        private string getCategoryName(int categoryId)
        {
            using (var db = new EntitySamsung())
            {
                return db.Samsung_Product.Where(p => p.id == categoryId).ToString();
            }
        }


        public void AddProduct(Product p)
        {
            string categoryName = p.Category;
            int categoryId = getCategoryId(categoryName);
            if (categoryId != CATEGORYNOTFOUND)
            {
                using (var db = new EntitySamsung())
                {
                    Samsung_Product product = new Samsung_Product(p.Name, categoryId, p.Color, (int)p.Price, p.Stock, p.Details);
                    db.Samsung_Product.Add(product);
                    db.SaveChanges();

                }
            }
        }

        public void RemoveProduct(Product p)
        {
            //productsList.Remove(p);
            int categoryId = getCategoryId(p.Category);
            Samsung_Product product = new Samsung_Product(p.Id, p.Name, categoryId, p.Color, (int)p.Price, p.Stock, p.Details);
            using (var db = new EntitySamsung())
            {
                db.Samsung_Product.Remove(product);
                db.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            //return productsList;

            List<Product> productList = new List<Product>();
            List<Samsung_Product> sProductList = new List<Samsung_Product>();
            using (var db = new EntitySamsung())
            {
                sProductList = db.Samsung_Product.ToList();

            }

            foreach (Samsung_Product sProduct in sProductList)
            {
                Product product = new Product(sProduct.id, sProduct.name, getCategoryName((int)sProduct.categoryId), sProduct.color, sProduct.details, (int)sProduct.price, (int)sProduct.stock);
                productList.Add(product);
            }
            return productList;

        }

        public void EditProduct(Product p)
        {
            /*var prod = productsList.Find(i => i.Id == p.Id);
            prod.Name = p.Name;
            prod.Category = p.Category;
            prod.Color = p.Color;
            prod.Details = p.Details;
            prod.Price = p.Price;
            prod.Stock = p.Stock;*/
            using (var db = new EntitySamsung())
            {
                var products = db.Samsung_Product.Where(i => i.id == p.Id).ToList();
                var item = products[0];
                item.name = p.Name;
                item.categoryId = getCategoryId(p.Category);
                item.color = p.Color;
                item.details = p.Details;
                item.price = p.Price;
                item.stock = p.Stock;
                db.SaveChanges();
            }
        }

        public Product GetProduct(int id)
        {
            //return productsList.Find(p => p.Id == id);
            using (var db = new EntitySamsung())
            {
                var item = db.Samsung_Product.Where(p => p.id == id);
                if (item.Count() == 0)
                {
                    return null;
                }
                else
                {
                    var product = item.First();
                    Product p = new Product(product.id, product.name, getCategoryName((int)product.categoryId), product.color, product.details, (int)product.price, (int)product.stock);
                    return p;
                }
            }
        }

        public void EditStockProduct(int idProduct, int stock)
        {
            using (var db = new EntitySamsung())
            {
                var product = db.Samsung_Product.FirstOrDefault(i => i.id == idProduct);
                product.stock -= stock;
                db.SaveChanges();
            }
        }
    }
}