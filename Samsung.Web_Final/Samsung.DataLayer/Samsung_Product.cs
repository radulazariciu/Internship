//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Samsung.DataLayer
{
    using System;
    using System.Collections.Generic;

    public partial class Samsung_Product
    {


        public Samsung_Product()
        {
            this.Samsung_Images = new HashSet<Samsung_Images>();
            this.Samsung_OrderItem = new HashSet<Samsung_OrderItem>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> categoryId { get; set; }
        public string color { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> stock { get; set; }
        public string details { get; set; }

        public virtual Samsung_Category Samsung_Category { get; set; }
        public virtual ICollection<Samsung_Images> Samsung_Images { get; set; }
        public virtual ICollection<Samsung_OrderItem> Samsung_OrderItem { get; set; }

        public Samsung_Product(string name, int categoryId, string color, int price, int stock, string details)
        {
            this.name = name;
            this.categoryId = categoryId;
            this.color = color;
            this.price = price;
            this.stock = stock;
            this.details = details;
        }

        public Samsung_Product(int id, string name, int categoryId, string color, int price, int stock, string details)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
            this.color = color;
            this.price = price;
            this.stock = stock;
            this.details = details;
        }
    }
}