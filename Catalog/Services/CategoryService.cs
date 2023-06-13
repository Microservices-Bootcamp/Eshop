using System;
using Catalog.Entities;

namespace Catalog.Services
{
    public class CategoryService : ICategoryService
    {
        public CategoryService()
        {
        }

        public Task Create(Category category)
        {
            // check if the name is not empty
            if(string.IsNullOrEmpty(category.Name))
            {               
                throw new CategoryNameEmptyException();
            }

            // make sure the category is not already exists
            throw new NotImplementedException();
        }
    }
}

