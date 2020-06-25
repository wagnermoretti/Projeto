using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Test1", Category = "T1", Price = 1 },
            new Product { Id = 2, Name = "Test2", Category = "T2", Price = 2.75M },
            new Product { Id = 3, Name = "Test3", Category = "T3", Price = 13.99M }
        };


        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        [HttpGet]
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        //http://localhost:55722/api/products/GetProduct/?id=2
        //http://localhost:55722/api/products/
    }
}