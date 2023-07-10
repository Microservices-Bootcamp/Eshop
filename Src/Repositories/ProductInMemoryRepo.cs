using Src.Domain.Entities;
using Src.Services;

namespace Src.Repositories;

public class ProductInMemoryRepo : IProductRepository
{
    private static readonly List<Product> Products = new();

    public async Task Add(Product product)
    {
        Products.Add(product);
    }
}