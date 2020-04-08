using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingMaterialsStoresWebApi.DAL.Entities;

namespace BuildingMaterialsStoresWebApi.DAL.Interfaces
{
    public interface ISQLProductRepository : IGenericRepository<Product, int>
    {

    }
}
