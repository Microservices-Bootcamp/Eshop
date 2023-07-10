using Src.Domain.Entities;

namespace Src.Domain.Contracts
{
	public interface ICategoryRepository
	{
		public bool CategoryNameIsExist(string name);
		public Task Add(Category category);
	}
}

