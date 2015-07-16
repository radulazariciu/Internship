using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.BusinessLogic.ViewModels;
using Samsung.DataLayer.DataMappers;
using Samsung.DataLayer.Models;
using Samsung.BusinessLogic.ViewModels;

namespace Samsung.BusinessLogic.BusinessLogic
{
    public static class ProductBL
    {
        public static List<ProductVM> GetAllProducts()
        {
        }

        public static GetProduct(int id)
        {
             ProductMapper userMapper = new UserMapper();
            return _productDataMapper.GetProduct(id);
        }

        publicstatic List<Product> CategoryProducts()
        {
            return _productDataMapper.GetAllProducts();
        }

        public void Edit(ProductVM productVM)
        {
            _productDataMapper.Edit(p);
        }
    }
}