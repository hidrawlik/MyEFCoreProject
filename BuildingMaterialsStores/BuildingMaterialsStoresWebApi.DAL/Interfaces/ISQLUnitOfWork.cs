using System;
using System.Collections.Generic;
using System.Text;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;

namespace BuildingMaterialsStoresWebApi.DAL.Interfaces
{
    public interface ISQLUnitOfWork
    {
        ISQLProductRepository SQLProductRepository { get; }
        
        void Complete();
    }
}
