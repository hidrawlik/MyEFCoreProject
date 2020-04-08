using System;
using System.Collections.Generic;
using System.Text;
using BuildingMaterialsStoresWebApi.DAL.Entities;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;

namespace BuildingMaterialsStoresWebApi.DAL.Services.SQLServices
{
    public class SQLProductService : ISQLProductService
    {
        private ISQLUnitOfWork _SqlUnitOfWork;

        public SQLProductService(ISQLUnitOfWork SqlUnitOfWork)
        {
            _SqlUnitOfWork = SqlUnitOfWork;
        }

        public long AddProduct(Product product)
        {
            return _SqlUnitOfWork.SQLProductRepository.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _SqlUnitOfWork.SQLProductRepository.Delete(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _SqlUnitOfWork.SQLProductRepository.GetAll();
        }

        public Product GetProductById(int Id)
        {
            return _SqlUnitOfWork.SQLProductRepository.Get(Id);
        }

        public void UpdateProduct(Product product)
        {
            _SqlUnitOfWork.SQLProductRepository.Update(product);
        }
    }
}
