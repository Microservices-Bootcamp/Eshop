using Src.Domain.Entities;

namespace Src.Domain.Contracts;

public interface IProductRepository
{
    public Task Add(Product product);
}