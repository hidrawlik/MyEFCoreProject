using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;
using BuildingMaterialsStoresWebApi.DAL.Entities;

namespace BuildingMaterialsStoresWebApi.WEBAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        #region Properties
        ISQLProductService _sqlProductService;
        #endregion

        #region Constructors
        public ProductController(ISQLProductService sqlProductService)
        {
            _sqlProductService = sqlProductService;
        }
        #endregion

        #region API's

        //GET: Get all products
        [Route("Product")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _sqlProductService.GetAllProducts();
        }
        //"[controller]/id"
        //GET: Get product by id
        [Route("Product/{Id}")]
        [HttpGet]
        public Product Get(int Id)
        {
            return _sqlProductService.GetProductById(Id);
        }

        //POST: Add new product
        [Route("Product")]
        [HttpPost]
        public long Post([FromBody]Product product)
        {
            return _sqlProductService.AddProduct(product);
        }

        //PUT: Update existing product
        [Route("Product/{product}")]
        [HttpPut]
        public void Put([FromBody]Product product)
        {
            _sqlProductService.UpdateProduct(product);
        }

        //DELETE: Delete existing product
        [Route("Product/{product}")]
        [HttpDelete]
        public void Delete([FromBody]Product product)
        {
            _sqlProductService.DeleteProduct(product);
        }
        #endregion
    }
}
