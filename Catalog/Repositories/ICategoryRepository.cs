using System;
namespace Catalog.Repositories
{
	public interface ICategoryRepository
	{
		public bool CategoryNameIsExist(string name);
	}
}

