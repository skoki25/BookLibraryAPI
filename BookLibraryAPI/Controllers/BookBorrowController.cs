using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public partial class BookBorrowController: ControllerBase
    {
        private IBookBorrowService _borrowService;

        public BookBorrowController(IBookBorrowService borrowService) 
        {
            _borrowService = borrowService;
        } 

        [HttpGet]
        [Route("Check")]
        public IActionResult GetBookById(int id)
        {
            try
            {
                Book book = _borrowService.GetBookById(id);
                return Ok(book);
            }
            catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Borrow")]
        public IActionResult Borrow(int id)
        {
            try
            {
                string userId = User.FindFirst(ClaimTypes.Name)?.Value;
                _borrowService.Borrow(id, userId);
                return Ok("Success");
            }
            catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch]
        [Route("Return")]
        public IActionResult ReturnBook(int id) 
        {
            try
            {
                return Ok(_borrowService.ReturnBook(id));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);  
            }
        }

        [HttpGet]
        [Route("History/user/{userId}")]
        public IActionResult GetBorrowHistory(int userId)
        {
            try
            {
                List<BookBorrow> bookBorrows = _borrowService.GetBorrowHistory(userId);
                return Ok(bookBorrows);
            }
            catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
