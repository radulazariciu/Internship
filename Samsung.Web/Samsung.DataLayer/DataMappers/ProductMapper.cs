using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;
namespace Samsung.DataLayer.DataMappers
{
    public class ProductMapper
    {

       private static List<Product> productsList = null;

       public ProductMapper()
        {
            if (productsList == null) { 
                productsList = new List<Product>();
                Init();
            }
        }

        private void Init()
        {
            var p = new Product();
            p.Id = 1;
            p.Name="Samsung Galaxy S6 edge";
            p.Category = "T-Mobile";
            p.Color = "black";
            p.Details ="Reimagined Design Inside and Out";
            p.Price = 600;
            p.Stock = 5;
            productsList.Add(p);

            p = new Product();
            p.Id = 2;
            p.Name = "Samsung Galaxy Note Edge";
            p.Category = "T-Mobile";
            p.Color = "black";
            p.Details = "Reimagined Design Inside and Out";
            p.Price = 550;
            p.Stock = 10;
            productsList.Add(p);

            p = new Product();
            p.Id = 3;
            p.Name = "Samsung Galaxy Note II ";
            p.Category = "Sprint";
            p.Color = "gray";
            p.Details = "Reimagined Design Inside and Out";
            p.Price = 850;
            p.Stock = 7;
            productsList.Add(p);
        }

        public void AddProduct(Product p)
        {
            productsList.Add(p);
        }

        public void RemoveProduct(Product p)
        {
            productsList.Remove(p);
        }

        public List<Product> GetAllProducts()
        {
            return productsList;
        }

        public void EditProduct(Product p)
        {
            var prod = productsList.Find(i => i.Id == p.Id);
            prod.Name = p.Name;
            prod.Category = p.Category;
            prod.Color = p.Color;
            prod.Details = p.Details;
            prod.Price = p.Price;
            prod.Stock = p.Stock;
        }

        public Product GetProduct(int id)
        {
            return productsList.Find(p => p.Id == id);
        }
    }
}