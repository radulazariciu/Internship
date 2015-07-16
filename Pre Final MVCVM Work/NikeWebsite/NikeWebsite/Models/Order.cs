﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models
{
    public class Order
    {
        public Product Prod { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}