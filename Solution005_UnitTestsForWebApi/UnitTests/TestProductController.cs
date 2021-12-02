using Moq;
using System;
using System.Linq;
using WebApi.Controllers;
using WebApi.Models;
using WebApi.Services;
using Xunit;

namespace UnitTests
{
    public class TestProductController
    {
        private static readonly ProductEntity[] allProducts = new ProductEntity[]
        {
            new ProductEntity() { Id = 1, Name = "Product1", Price = 10m },
            new ProductEntity() { Id = 2, Name = "Product2", Price = 20m }
        };

        [Fact]
        public void Get_ShouldReturnAllProducts()
        {
            var mockProductService = new Mock<IProductService>();
            mockProductService.Setup(service => service.GetAll())
                .Returns(allProducts);
            var controller = new ProductController(mockProductService.Object);

            var result = controller.Get();

            Assert.Equal(allProducts.Length, result.Count());
            foreach (var x in result.Zip(allProducts))
            {
                Assert.Equal(x.First.Id, x.Second.Id);
                Assert.Equal(x.First.Name, x.Second.Name);
            }
        }
    }
}
