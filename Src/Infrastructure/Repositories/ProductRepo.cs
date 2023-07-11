using Src.Domain.Contracts;
using Src.Domain.Entities;
using Src.Infrastructure.Database;

namespace Src.Infrastructure.Repositories;

public class ProductRepo: IProductRepository
{
    private readonly EshopDatabase _db;

    public ProductRepo(EshopDatabase db)
    {
        _db = db;
    }

    public async Task Add(Product product)
    {
        _db.Products.Add(product);
        await _db.SaveChangesAsync();
        // publish domain events
        var evetns = product.GetOccuredEvents();
        //publisher.publish(events);
    }
}