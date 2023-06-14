using System.Runtime.Serialization;

namespace Catalog.Services
{
    [Serializable]
    internal class CategoryNameEmptyException : Exception
    {
        public CategoryNameEmptyException() : base("Category name should not be null")
        {
        }

    }
}