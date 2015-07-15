using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="OurQuantity")]
        
        public int Quantity { get; set; }
    }
}