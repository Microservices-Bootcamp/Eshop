using Catalog.Entities;
using Catalog.Services;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers;

[Route("/products")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly ILogger<ProductsController> _logger;
    public ProductsController(IProductService productService, ILogger<ProductsController> logger)
    {
        _productService = productService;
        _logger = logger;
    }

    public async Task<IActionResult> Post([FromBody] Product product)
    {
        _logger.LogInformation("Product with ${ProductName} requested", product.Name);
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(value => value.Errors)
                .Select(error => error.ErrorMessage)
                .ToList();
            return BadRequest(errors);
        }

        await _productService.CreateProduct(product);
        return Ok("Product Created..");
    }
}