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
        public IActionResult GetAllCategory()
        {
            return this.ServiceToActionResult(_categoryService.GetAllCategory());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            return this.ServiceToActionResult(_categoryService.GetCategoryById(id));
        }

        [HttpPut]
        [Authorize]
        public IActionResult EditCategory([FromForm]int id, [FromBody]Category category) 
        {
            return this.ServiceToActionResult(_categoryService.EditCategory(id, category));
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddCategory(Category category)
        {
            return this.ServiceToActionResult(_categoryService.AddCategory(category));
        }
    }
}
