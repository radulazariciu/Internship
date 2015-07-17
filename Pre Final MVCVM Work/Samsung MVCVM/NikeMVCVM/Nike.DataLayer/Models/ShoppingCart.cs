﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.DataLayer.Models
{
    class ShoppingCart
    {
        public int Id { get; set; }
       // public List<ShoppingCartItem> Items { get; set; }
        public User Customer { get; set; }
        public string Address { get; set; }
        public decimal TotalPrice { get; set; }
    }
}