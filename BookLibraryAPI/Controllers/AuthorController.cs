using BookLibraryAPI.Installation;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private IAuthorService _authorService;

        public AuthorController(IAuthorService authorService) 
        { 
            _authorService = authorService;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<IActionResult>  GetAuthorById(int id)
        {
            return _authorService.GetAuthorById(id).Result();
        }

        [HttpGet]
        public Task<IActionResult> GetAuthors()
        {
            return _authorService.GetAuthors().Result();
        }

        [HttpPut]
        [Route("{id}")]
        public  Task<IActionResult> EditAuthor(int id, Author author)
        {
            return _authorService.EditAuthor(id, author).Result();
        }

        [HttpPost]
        public Task<IActionResult> CreateAuthor(Author author)
        {
            return _authorService.CreateAuthor(author).Result();
        }
    }
}
