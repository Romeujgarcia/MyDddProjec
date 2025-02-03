using MyDddProject.Domain.Entities;
using MyDddProject.Domain.Repositories;

namespace MyDddProject.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProduct(int id)
        {
            return _productRepository.GetById(id);
        }

        public void AddProduct(string name, decimal price)
        {
            var product = new Product(name, price);
            _productRepository.Add(product);
        }
    }
}