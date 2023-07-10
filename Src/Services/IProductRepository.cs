using Src.Domain.Entities;

namespace Src.Services;

public interface IProductRepository
{
    public Task Add(Product product);
}