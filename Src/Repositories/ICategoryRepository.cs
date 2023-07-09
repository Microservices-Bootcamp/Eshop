using Src.Entities;

namespace Src.Repositories
{
	public interface ICategoryRepository
	{
		public bool CategoryNameIsExist(string name);
		public Task Add(Category category);
	}
}

