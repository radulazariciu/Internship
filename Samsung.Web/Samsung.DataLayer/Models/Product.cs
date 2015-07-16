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
        public Image Image { get; set; }
        public List<string> Details { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}