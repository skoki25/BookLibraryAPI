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
        [Route("/{id}")]
        public async Task<Author>  GetAuthorById(int id)
        {
            return await _authorService.GetAuthorById(id);
        }

        [HttpGet]
        public async Task<List<Author>> GetAuthors()
        {
            return await _authorService.GetAuthors();
        }

        [HttpPut]
        [Route("/{id}")]
        public async Task<Author> EditAuthor(int id, Author author)
        {
            return await _authorService.EditAuthor(id, author);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(Author author)
        {
            var result = await _authorService.CreateAuthor(author);
            if (result.IsSuccess)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.ErrorMessage);
        }
    }
}
