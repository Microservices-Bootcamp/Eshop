using Catalog.Controllers.Dtos;
using Catalog.Entities;

namespace Catalog.Services;

public interface IProductService
{
    public Task CreateProductRequest(CreateProductRequest request);
}