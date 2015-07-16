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
            p.Details = new List<string>();
            p.Details.Add("Reimagined Design Inside and Out");
            p.Details.Add("Innovative Dual-Edge Screen");
            p.Details.Add("5.1\" Quad HD Super AMOLED® display ");
            p.Price = 600;
            p.Stock = 5;
            productsList.Add(p);

            p = new Product();
            p.Id = 2;
            p.Name = "Samsung Galaxy Note Edge";
            p.Category = "T-Mobile";
            p.Color = "black";
            p.Details = new List<string>();
            p.Details.Add("Innovative Smart Edge Screen");
            p.Details.Add("Enhanced S Pen™ with more precision and functions");
            p.Details.Add("16MP rear camera with Optical Image Stabilization");
            p.Price = 550;
            p.Stock = 10;
            productsList.Add(p);

            p = new Product();
            p.Id = 3;
            p.Name = "Samsung Galaxy Note II ";
            p.Category = "Sprint";
            p.Color = "gray";
            p.Details = new List<string>();
            p.Details.Add("Built for productivity, multitasking, capturing and sharing");
            p.Details.Add("Power and performance with 4G speed, quad-core processor on the Android platform");
            p.Details.Add("Intuitive interacting by tapping, hovering and speaking");
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

        public void Edit(Product p)
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