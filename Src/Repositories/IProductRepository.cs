using Src.Entities;

namespace Src.Repositories;

public interface IProductRepository
{
    public Task Add(Product product);
}