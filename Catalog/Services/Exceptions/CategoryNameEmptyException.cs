namespace Catalog.Services.Exceptions
{
    [Serializable]
    internal class CategoryNameEmptyException : Exception
    {
        public CategoryNameEmptyException() : base("Category name should not be null")
        {
        }

    }
}