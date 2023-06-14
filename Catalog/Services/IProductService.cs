using Catalog.Entities;

namespace Catalog.Services;

public interface IProductService
{
    public Task CreateProduct(Product product);
}