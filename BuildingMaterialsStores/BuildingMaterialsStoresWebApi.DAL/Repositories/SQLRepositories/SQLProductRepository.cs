using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;
using BuildingMaterialsStoresWebApi.DAL.Repositories;
using BuildingMaterialsStoresWebApi.DAL.Entities;

namespace BuildingMaterialsStoresWebApi.DAL.Repositories.SQLRepositories
{
    public class SQLProductRepository : GenericRepository<Product, int>, ISQLProductRepository
    {
        private static readonly string _tableName = "Product";
        private static readonly bool _isSoftDelete = true;

        public SQLProductRepository(IConnectionFactory connectionFactory/*, bool IsTest*/) : base(connectionFactory, _tableName, _isSoftDelete)
        {
            connectionFactory.SetConnection(MyConnection.ConnectionString);
            //connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            //if (!IsTest)
            //{ 
            //}
        }
    }
}
