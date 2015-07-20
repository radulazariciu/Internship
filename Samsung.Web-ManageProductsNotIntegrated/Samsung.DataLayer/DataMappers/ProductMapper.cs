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
                   foreach(var item in db.Samsung_Category.ToList())
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
               foreach(var item in db.Samsung_Category.ToList())
               {
                   if (item.id == categoryId)
                   {
                       return item.name;
                   }
               }
               return null;
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
            Samsung_Product product = new Samsung_Product(p.Id,p.Name, categoryId, p.Color, (int)p.Price, p.Stock, p.Details);
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

            foreach(Samsung_Product sProduct in sProductList)
            {
                Product product = new Product(sProduct.id, sProduct.name, getCategoryName((int)sProduct.categoryId), sProduct.color, sProduct.details, (int)sProduct.price, (int)sProduct.stock);
                productList.Add(product);
            }
            return productList;

        }

        public void EditProduct(Product p)
        {
            using (var db = new EntitySamsung())
            {
                var item = db.Samsung_Product.Find(p.Id);
                if (item != null)
                {
                    item.name = p.Name;
                    item.price = p.Price;
                    item.stock = p.Stock;
                    item.color = p.Color;
                    item.details = p.Details;
                    item.categoryId = getCategoryId(p.Category);
                    db.SaveChanges();
                }
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
    }
}