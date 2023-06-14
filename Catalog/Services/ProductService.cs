using Catalog.Entities;
using Catalog.Repositories;
using Catalog.Services.Exceptions;

namespace Catalog.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task CreateProduct(Product product)
    {
        if (product.SellingPrice == 0 || product.CostPrice == 0 || product.SellingPrice < product.CostPrice)
            throw new PriceException();
        
        await _productRepository.Add(product);
    }
}