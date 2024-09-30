using BookLibrary.Model.DTO;
using BookLibrary.Models;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Installation;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return await _bookService.GetAllBooks();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(Book book) 
        {
            return await _bookService.CreateBook(book);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> EditBook(int id, [FromBody] BookSimpleDto book)
        {
            return await _bookService.EditBook(id, book);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBook(int id)
        {
            return await _bookService.DeleteBook(id);
        }
    }
}
