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
            return await _borrowService.GetBookById(id);
        }

        [HttpPost]
        [Route("Borrow")]
        public async Task<IActionResult> Borrow(int id)
        {
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            return await _borrowService.BorrowBook(id, userId);
        }

        [HttpPatch]
        [Route("Return/{bookId}")]
        public async Task<IActionResult> ReturnBook(int bookId) 
        {
            return await _borrowService.ReturnBook(bookId);
        }

        [HttpGet]
        [Route("History/user/{userId}")]
        public async Task<IActionResult> GetBorrowHistory(int userId)
        {
            return await _borrowService.GetBorrowHistory(userId);
        }
    }
}
