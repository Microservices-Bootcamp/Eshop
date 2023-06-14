using Catalog.Entities;

namespace Catalog.Repositories;

public interface IProductRepository
{
    public Task Add(Product product);
}