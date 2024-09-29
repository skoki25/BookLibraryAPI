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
        public async Task<IActionResult> GetBookById(int id)
        {
            return _borrowService.GetBookById(id).Result();
        }

        [HttpPost]
        [Route("Borrow")]
        public async Task<IActionResult> Borrow(int id)
        {
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            return _borrowService.BorrowBook(id, userId).Result();
        }

        [HttpPatch]
        [Route("Return/{bookId}")]
        public async Task<IActionResult> ReturnBook(int bookId) 
        {
            return _borrowService.ReturnBook(bookId).Result();
        }

        [HttpGet]
        [Route("History/user/{userId}")]
        public async Task<IActionResult> GetBorrowHistory(int userId)
        {
            return _borrowService.GetBorrowHistory(userId).Result();
        }
    }
}
