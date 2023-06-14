using System;
using Catalog.Entities;

namespace Catalog.Repositories
{
	public interface ICategoryRepository
	{
		public bool CategoryNameIsExist(string name);
		public Task Add(Category category);
	}
}

