using BookLibraryAPI.Data.CustomException;
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
        public IActionResult GetAllBooks()
        {
            List<Book>books = _bookService.GetAllBooks();
            if (books.Count == 0)
            {
                return NoContent();
            }
            return Ok(books);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book) 
        {           
            try
            {
                _bookService.CreateBook(book);
                return Ok("Sucess");

            }
            catch (ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            _bookService.DeleteBook(id);
            return Ok();
        }
    }
}
