using Src.Controllers.Dtos;

namespace Src.Services;

public interface IProductService
{
    public Task CreateProductRequest(CreateProductRequest request);
}