using System;
using System.Collections.Generic;
using System.Text;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;

namespace BuildingMaterialsStoresWebApi.DAL.UnitOfWork
{
    public class SQLUnitOfWork : ISQLUnitOfWork
    {
        private readonly ISQLProductRepository sqlProductRepository;

        public SQLUnitOfWork(ISQLProductRepository sqlProductRepository)
        {
            this.sqlProductRepository = sqlProductRepository;
        }

        public ISQLProductRepository SQLProductRepository
        {
            get
            {
                return sqlProductRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
