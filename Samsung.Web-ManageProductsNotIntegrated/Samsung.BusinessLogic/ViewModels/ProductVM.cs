using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class ProductVM
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Details { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public ProductVM(int id, string name, string category, string color, string details, int price, int stock)
        {
            Id = id;
            Name = name;
            Category = category;
            Color = color;
            Details = details;
            Price = price;
            Stock = stock;
        }

        public ProductVM()
        {
        }
    }
}