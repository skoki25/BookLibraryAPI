using BookLibraryAPI.Installation;
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
            return this.ServiceToActionResult(_borrowService.GetBookById(id));
        }

        [HttpPost]
        [Route("Borrow")]
        public IActionResult Borrow(int id)
        {
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            var result = _borrowService.BorrowBook(id, userId);
            return this.ServiceToActionResult(result);
        }

        [HttpPatch]
        [Route("Return/{bookId}")]
        public IActionResult ReturnBook(int bookId) 
        {
            return this.ServiceToActionResult(_borrowService.ReturnBook(bookId));
        }

        [HttpGet]
        [Route("History/user/{userId}")]
        public IActionResult GetBorrowHistory(int userId)
        {
            var result = _borrowService.GetBorrowHistory(userId);
            return this.ServiceToActionResult(result);
        }
    }
}
