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
        public async Task<IActionResult>  GetAuthorById(int id)
        {
            return this.ServiceToActionResult(_authorService.GetAuthorById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            return this.ServiceToActionResult(_authorService.GetAuthors());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> EditAuthor(int id, Author author)
        {
            return this.ServiceToActionResult(_authorService.EditAuthor(id, author));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(Author author)
        {
            return this.ServiceToActionResult(_authorService.CreateAuthor(author));
        }
    }
}
