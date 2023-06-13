using System.Runtime.Serialization;

namespace Catalog.Services
{
    [Serializable]
    internal class CategoryNameEmptyException : Exception
    {
        public CategoryNameEmptyException() : base("Catengory name should not be null")
        {
        }
    }
}