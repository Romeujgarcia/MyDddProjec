// MyDddProject.API/Controllers/ProductController.cs
using Microsoft.AspNetCore.Mvc;
using MyDddProject.Application.Services;
using MyDddProject.Domain.Entities;

namespace MyDddProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productService.GetProduct(id);
            return product != null ? Ok(product) : NotFound();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.AddProduct(product.Name, product.Price);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }
    }
}
