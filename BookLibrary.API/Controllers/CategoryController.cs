using BookLibrary.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            return await _categoryService.GetAllCategory();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            return await _categoryService.GetCategoryById(id);
        }

        [HttpPut]
        [Authorize]
        [Route("{id}")]
        public async Task<IActionResult> EditCategory(int id, Category category) 
        {
            return await _categoryService.EditCategory(id, category);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category)
        {
            return await _categoryService.CreateCategory(category);
        }
        [HttpGet]
        [Route("Books")]
        public async Task<IActionResult> GetCategoriesWithBooks()
        {
            return await _categoryService.GetCategoriesWithBooks();
        }


    }
}
