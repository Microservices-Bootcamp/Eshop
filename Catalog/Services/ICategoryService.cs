using System;
using Catalog.Entities;

namespace Catalog.Services
{
    public interface ICategoryService
    {
        public Task Create(Category category);
    }
}

