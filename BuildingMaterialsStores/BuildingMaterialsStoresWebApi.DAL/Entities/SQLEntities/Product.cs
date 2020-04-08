using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;

namespace BuildingMaterialsStoresWebApi.DAL.Entities
{
    public class Product : IEntity<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Company { get; set; }

        public double Price { get; set; }
    }
}
