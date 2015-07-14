﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}