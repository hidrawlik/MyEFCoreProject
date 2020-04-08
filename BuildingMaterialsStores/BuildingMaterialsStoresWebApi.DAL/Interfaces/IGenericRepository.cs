using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingMaterialsStoresWebApi.DAL.Interfaces
{
    public interface IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(TId id);

        int Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
