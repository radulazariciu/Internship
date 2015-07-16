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
            ProductMapper productMapper = new ProductMapper();
            List<Product> returnedProductsList = productMapper.GetAllProducts();
            List<ProductVM> returnedProductsVm =new List<ProductVM>();
            foreach (var productItem in returnedProductsList)
            {
                ProductVM newProductVm = new ProductVM(productItem.Id, productItem.Name, productItem.Category, productItem.Color,
               productItem.Details, productItem.Price, productItem.Stock);
                returnedProductsVm.Add(newProductVm);
            }

            return returnedProductsVm;
        }

        public static ProductVM GetProduct(int id)
        {
           ProductMapper productMapper = new ProductMapper();
           Product returnedProduct =  productMapper.GetProduct(id);
           ProductVM newProductVm = new ProductVM(returnedProduct.Id,returnedProduct.Name, returnedProduct.Category,  returnedProduct.Color,
               returnedProduct.Details, returnedProduct.Price, returnedProduct.Stock);
            return newProductVm;
        }

        public static void EditProduct(ProductVM productVM)
        {
            ProductMapper productMapper = new ProductMapper();
            Product inputProduct = new Product(productVM.Id, productVM.Name, productVM.Category, productVM.Color, productVM.Details, productVM.Price, productVM.Stock);
            productMapper.EditProduct(inputProduct);
        }
    }
}