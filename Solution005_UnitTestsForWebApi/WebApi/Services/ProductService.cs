using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Services
{
    public class ProductService : IProductService
    {
        private static readonly ProductEntity[] productEntities = new ProductEntity[]
        {
            new ProductEntity() { Id = 1, Name = "Product1", Price = 10m },
            new ProductEntity() { Id = 2, Name = "Product2", Price = 20m }
        };

        public IEnumerable<ProductEntity> GetAll()
        {
            return productEntities;
        }
    }
}
