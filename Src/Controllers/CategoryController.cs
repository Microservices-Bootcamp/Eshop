using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Src.Controllers.Dtos;
using Src.Services;

namespace Src.Controllers
{
    [Route("/categories")]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryRequest request)
        {
            await _categoryService.Create(request.CategoryName);
            return Ok("Category created...");
        }
    }
}