using Src.Domain.Contracts;
using Src.Domain.Entities;
using Src.Domain.Exceptions;

namespace Src.Application.UseCases;

public class CreateCategory
{
    private readonly ICategoryRepository _categoryRepository;

    public CreateCategory(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Execute(string categoryName)
    {
        // check if the name is not empty
        if (string.IsNullOrEmpty(categoryName))
        {
            throw new CategoryNameEmptyException();
        }

        // make sure the category is not already exists
        var exists = _categoryRepository.CategoryNameIsExist(categoryName);
        if (exists)
        {
            throw new CategoryAlreadyExistsException(categoryName);
        }

        var category = new Category { Name = categoryName, Id = Guid.NewGuid() };

        await _categoryRepository.Add(category);
    }
}