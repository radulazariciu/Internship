﻿//------------------------------------------------------------------------------
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
    using System.Data.EntitySamsung;
    using System.Data.SamsungEntity.Infrastructure;
    
    public partial class EntitySamsung : DbContext
    {
        public EntitySamsung()
            : base("name=EntitySamsung")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Samsung_Category> Samsung_Category { get; set; }
        public virtual DbSet<Samsung_Images> Samsung_Images { get; set; }
        public virtual DbSet<Samsung_Order> Samsung_Order { get; set; }
        public virtual DbSet<Samsung_OrderItem> Samsung_OrderItem { get; set; }
        public virtual DbSet<Samsung_Product> Samsung_Product { get; set; }
        public virtual DbSet<Samsung_User> Samsung_User { get; set; }
    }
}
