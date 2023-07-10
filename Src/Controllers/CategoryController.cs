using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Src.Application.UseCases;
using Src.Controllers.Dtos;

namespace Src.Controllers
{
    [Route("/categories")]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly CreateCategory _createCategory;

        public CategoryController(CreateCategory createCategory)
        {
            _createCategory = createCategory;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryRequest request)
        {
            await _createCategory.Execute(request.CategoryName);
            return Ok("Category created...");
        }
    }
}