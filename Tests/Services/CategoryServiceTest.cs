using Moq;
using Src.Domain.Contracts;
using Src.Domain.Entities;
using Src.Domain.Exceptions;
using Src.Repositories;
using Src.Services;
using Src.Services.Exceptions;

namespace Tests.Services;

public class CategoryServiceTest
{
    [Fact]
    public async Task Create_WhenCategoryNameEmpty_ShouldThrowException()
    {
        // Arrange
        var categoryRepository = new Mock<ICategoryRepository>();
        var categoryService = new CategoryService(categoryRepository.Object);

        // Act
        await Assert.ThrowsAsync<CategoryNameEmptyException>(async () => await categoryService.Create(""));
    }
    
    [Fact]
    public async Task Create_WhenCategoryNameExists_ShouldThrowException()
    {
        // Arrange
        var categoryRepository = new Mock<ICategoryRepository>();
        var categoryName = "toys";
        categoryRepository.Setup(categoryRepository => categoryRepository.CategoryNameIsExist(categoryName)).Returns(true);
        var categoryService = new CategoryService(categoryRepository.Object);

        // Act
        await Assert.ThrowsAsync<CategoryAlreadyExistsException>(async () => await categoryService.Create(categoryName));
    }
    
      
    [Fact]
    public async Task Create_WhenNewCategoryNameProvided_ShouldWork()
    {
        // Arrange
        var categoryRepository = new Mock<ICategoryRepository>();
        var categoryName = "toys";
        categoryRepository.Setup(categoryRepository => categoryRepository.CategoryNameIsExist(categoryName)).Returns(false);
        var categoryService = new CategoryService(categoryRepository.Object);

        // Act
        await categoryService.Create(categoryName);
        
        // Assert
        categoryRepository.Verify(x=>x.Add(It.IsAny<Category>()));
    }
}