using Src.Database;
using Src.Entities;

namespace Src.Repositories;

public class CategoryRepo : ICategoryRepository
{
    private EshopDatabase _db;

    public CategoryRepo(EshopDatabase db)
    {
        _db = db;
    }

    public bool CategoryNameIsExist(string name)
    {
        return _db.Categories.Any(x => x.Name == name);
    }

    public async Task Add(Category category)
    {
        _db.Categories.Add(category);
        await _db.SaveChangesAsync();
    }
}