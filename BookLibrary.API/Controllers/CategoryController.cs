using BookLibrary.Models;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Installation;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

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
            return _categoryService.GetAllCategory().Result();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            return _categoryService.GetCategoryById(id).Result();
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> EditCategory([FromForm]int id, [FromBody]Category category) 
        {
            return _categoryService.EditCategory(id, category).Result();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddCategory(Category category)
        {
            return _categoryService.AddCategory(category).Result();
        }
    }
}
