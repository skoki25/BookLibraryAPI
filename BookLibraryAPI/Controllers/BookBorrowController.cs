using BookLibraryAPI.Data.Builder;
using BookLibraryAPI.Data.Config;
using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public partial class BookBorrowController: ControllerBase
    {
        private LibraryDbContext _context;
        private ILogger _logger;

        public BookBorrowController(ILogger<BookBorrowController> logger) 
        {
            _logger = logger;
            _context = new LibraryDbContext();
        } 

        [HttpGet]
        [Route("Check")]
        public IActionResult GetBookById(int id)
        {
            if (CheckIfBookIsBorrowed(id))
            {
                return BadRequest("Book is borrowed");
            }

            Book book = _context.Book.Where(x => x.Id == id).SingleOrDefault();

            if(book ==null)
            {
                return NotFound("Book dosnt exist");
            }

            return Ok(book);
        }

        [HttpPost]
        [Route("Borrow")]
        public IActionResult Borrow(int id)
        {
            if (CheckIfBookIsBorrowed(id))
            {
                return BadRequest("Book is borrowed");
            }
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            User user = _context.User.Where(x => x.Email == userId).SingleOrDefault();
            
            if (user == null)
            {
                return BadRequest("Problem");
            }

            List<BookBorrow> borrowBooksList = _context.BookBorrow.Where(x=>x.UserId == user.Id && !x.IsReturned)
                        .ToList();

            if(borrowBooksList.Count >= Config.MaxBorrowedBook)
            {
                return BadRequest($"User had borrow {Config.MaxBorrowedBook} books already");
            }

            BookBorrow bookBorrow = new BookBorrowBuilder()
                .IsBorrowed()
                .AddReturnDate(10)
                .AddBookId(id)
                .AddUser(user)
                .Build();

            _context.BookBorrow.Add(bookBorrow);
            _context.SaveChanges();
            return Ok("Saved");
        }

        [HttpPost]
        [Route("Return")]
        public IActionResult Return(int id) 
        {
            BookBorrow bookBorrow = _context.BookBorrow.Where(x=> x.Id == id).SingleOrDefault();    

            if (bookBorrow == null)
            {
                return NotFound();
            }

            bookBorrow.IsReturned = true;
            bookBorrow.ReturnedDated = DateTime.Now;
            _context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        [Route("History")]
        public IActionResult GetHistory([Optional] int userId)
        {

            return Ok();
        }

        private bool CheckIfBookIsBorrowed(int id)
        {
            BookBorrow isBookBorrower = _context.BookBorrow.Where(x =>x.Book.Id == id && !x.IsReturned )
                .Include(x=>x.Book)
                .FirstOrDefault();
            return isBookBorrower != null ? true : false;
        }
    }
}
