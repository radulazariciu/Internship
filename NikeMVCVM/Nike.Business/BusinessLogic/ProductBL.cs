using Nike.Business.ViewModels;
using Nike.DataLayer.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.Business.BusinessLogic
{
    public static class ProductBL
    {
       
        public static List<ProductCategoryVM> GetProducts()
        {
            ProductMapper _productMapper = new ProductMapper();
            var productList = _productMapper.GetProducts();
            var productVMList = new List<ProductCategoryVM>();

            foreach (var item in productList)
            {
                var prod = new ProductCategoryVM
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description,
                    Price = item.Price,
                    Category = item.Category
                };

                productVMList.Add(prod);
            }

            return productVMList;

        }

        public static ProductCategoryVM GetProduct(int id)
        {
            var products = GetProducts();

            var prod = products.FirstOrDefault(p => p.Id == id);

            return prod;
        }
    }
}
