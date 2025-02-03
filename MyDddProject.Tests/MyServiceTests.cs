using Xunit;
using Moq;
using MyDddProject.Application.Services;
using MyDddProject.Domain.Entities;
using MyDddProject.Domain.Repositories;

namespace MyDddProject.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetProduct_ReturnsProduct()
        {
            // Arrange
            var mockRepo = new Mock<IProductRepository>();
            var product = new Product("Test Product", 10.0m);
            mockRepo.Setup(repo => repo.GetById(It.IsAny<int>())).Returns(product);
            var service = new ProductService(mockRepo.Object);

            // Act
            var result = service.GetProduct(1);

            // Assert
            Assert.Equal(product, result);
        }

        [Fact]
        public void AddProduct_CallsRepositoryAdd()
        {
            // Arrange
            var mockRepo = new Mock<IProductRepository>();
            var service = new ProductService(mockRepo.Object);

            // Act
            service.AddProduct("New Product", 20.0m);

            // Assert
            mockRepo.Verify(repo => repo.Add(It.IsAny<Product>()), Times.Once);
        }
    }
}