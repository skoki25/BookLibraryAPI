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
        public IActionResult GetAllBooks()
        {
            return this.ServiceToActionResult(_bookService.GetAllBooks());
        }

        [HttpPost]
        public IActionResult CreateBook(Book book) 
        {
            return this.ServiceToActionResult(_bookService.CreateBook(book));
        }

        public IActionResult EditBook(int id, Book book)
        {
            return this.ServiceToActionResult(_bookService.EditBook(id, book));
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            return this.ServiceToActionResult(_bookService.DeleteBook(id));
        }
    }
}
