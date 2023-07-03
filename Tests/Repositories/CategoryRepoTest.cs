using Catalog.Database;
using Catalog.Entities;
using Catalog.Repositories;
using EntityFrameworkCoreMock;
using Microsoft.EntityFrameworkCore;

namespace Tests.Repositories;

public class CategoryRepoTest
{
    [Fact]
    public void CategoryNameIsExist_NameExists_ShouldReturnTrue()
    {
        //Arrange
        var categoryName = "Toys";
        var categoryList = new List<Category> { new Category { Name = categoryName, Id = Guid.NewGuid() } };
        var eshopDatabase = new DbContextMock<EshopDatabase>(new DbContextOptionsBuilder<EshopDatabase>().Options);
        eshopDatabase.CreateDbSetMock(db => db.Categories, categoryList);
        var categoryRepo = new CategoryRepo(eshopDatabase.Object);
        
        // Act
        var actual = categoryRepo.CategoryNameIsExist(categoryName);
        
        // Assert
        Assert.True(actual);
    }
}