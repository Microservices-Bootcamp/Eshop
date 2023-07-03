﻿namespace Catalog.Services.Exceptions
{
    [Serializable]
    public class CategoryNameEmptyException : Exception
    {
        public CategoryNameEmptyException() : base("Category name should not be null")
        {
        }

    }
}