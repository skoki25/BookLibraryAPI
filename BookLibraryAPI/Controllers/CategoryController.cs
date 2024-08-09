using BookLibraryAPI.Data.CustomException;
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
            List<Category> categories = _categoryService.GetAllCategory();
            if(categories.Count == 0)
            {
                return NoContent();
            }
            return Ok(categories);
        }

        [HttpPut]
        [Authorize]
        public IActionResult EditCategory([FromForm]int id, [FromBody]Category category) 
        {
            Category catergoryResult = _categoryService.EditCategory(id, category);
            
            if (catergoryResult == null)
            {
                return NotFound();
            }

            return Ok(catergoryResult);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddCategory(Category category)
        {
            try
            {
                Category catagory = _categoryService.AddCategory(category);
                return Ok(category);
            }
            catch (ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
