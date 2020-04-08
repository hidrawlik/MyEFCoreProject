using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace BuildingMaterialsStoresWebApi.DAL.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetSqlConnection { get; }

        void SetConnection(string connectionString);
    }
}
