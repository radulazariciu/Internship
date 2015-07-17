using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Samsung.DataLayer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string ImagePath { get; set; }
        public string Details { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, string category, string color, string image, string details, float price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Color = color;
            ImagePath = image;
            Details = details;
            Price = price;
            Stock = stock;
        }

        public Product(int id, string name, string category, string color, string details, float price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Color = color;
            Details = details;
            Price = price;
            Stock = stock;
        }

        public Product()
        {
            
        }
    }
 
}