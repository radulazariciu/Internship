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
    
    public partial class Samsung_Category
    {
        public Samsung_Category()
        {
            this.Samsung_Product = new HashSet<Samsung_Product>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Samsung_Product> Samsung_Product { get; set; }
    }
}