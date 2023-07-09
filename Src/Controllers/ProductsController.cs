using Microsoft.AspNetCore.Mvc;
using Src.Controllers.Dtos;
using Src.Services;

namespace Src.Controllers;

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

    public async Task<IActionResult> Post([FromBody] CreateProductRequest product)
    {
        
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values
                .SelectMany(value => value.Errors)
                .Select(error => error.ErrorMessage)
                .ToList();

            return BadRequest(errors);
        }
        _logger.LogInformation("Product with ${ProductName} requested", product.Name);
        await _productService.CreateProductRequest(product);
        return Ok("Product Created..");
    }
}