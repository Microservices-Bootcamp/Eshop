using Catalog.Database;
using Catalog.Entities;

namespace Catalog.Repositories;

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
    }
}