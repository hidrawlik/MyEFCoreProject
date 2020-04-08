using System;
using System.Collections.Generic;
using System.Text;
using BuildingMaterialsStoresWebApi.DAL.Entities;

namespace BuildingMaterialsStoresWebApi.DAL.Interfaces
{
    public interface ISQLProductService
    {
        IEnumerable<Product> GetAllProducts();
        
        Product GetProductById(int Id);

        long AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(Product product);
    }
}
