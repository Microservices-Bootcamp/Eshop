using System.Runtime.Serialization;

namespace Catalog.Services
{
    [Serializable]
    internal class CategoryAlreadyExistsException : Exception
    {
        public CategoryAlreadyExistsException(string categoryName) : base($"Category with name {categoryName} is already exist!")
        {
        }
    }
}