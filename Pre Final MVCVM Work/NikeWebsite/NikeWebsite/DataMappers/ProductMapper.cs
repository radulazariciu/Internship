using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models.DataMappers
{
    public class ProductMapper
    {
        static List<Product> _products = new List<Product>()
        {
            new Product{
                Id = 1,
                Name = "Nike Air Zoom Pegasus 32",
                Category = "6 Colors",
                Description = "Men's Running Shoe",
                Price = 110
            },

            new Product {
                Id = 2,
                Name = "Nike Air Zoom Vomero 10",
                Category = "7 colors",
                Description = "Men's Running Shoe",
                Price = 140
            },
            new Product{
                Id = 3,
                Name = "Nike Zoom Elite 8",
                Category = "4 Colors",
                Description = "Men's Running Shoe",
                Price = 115
            },
            new Product{
                Id = 4,
                Name = "Nike Air Zoom Structure 18",
                Category = "10 Colors",
                Description = "Men's Running Shoe",
                Price = 120
            },
            new Product{
                Id = 5,
                Name = "Nike Air Zoom Free Trainer 3.0 V4",
                Category = "6 Colors",
                Description = "Men's Running Shoe",
                Price = 120
            }
        };

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}