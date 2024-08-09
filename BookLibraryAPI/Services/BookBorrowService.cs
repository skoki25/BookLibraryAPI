using BookLibraryAPI.Data.Builder;
using BookLibraryAPI.Data.Config;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BookLibraryAPI.Services
{
    public class BookBorrowService : IBookBorrowService
    {
        private LibraryDbContext _context = new LibraryDbContext();

        public void Borrow(int id, string userEmail)
        {
            if (CheckIfBookIsBorrowed(id))
            {
                throw new ValidationErrorExeption("Book is borrowed");
            }
            User user = _context.User.Where(x => x.Email == userEmail).SingleOrDefault();

            if (user == null)
            {
                throw new ValidationErrorExeption("Problem");
            }

            List<BookBorrow> borrowBooksList = _context.BookBorrow.Where(x => x.UserId == user.Id && !x.IsReturned)
                        .ToList();

            if (borrowBooksList.Count >= Config.MaxBorrowedBook)
            {
                throw new ValidationErrorExeption($"User had borrow {Config.MaxBorrowedBook} books already");
            }

            BookBorrow bookBorrow = new BookBorrowBuilder()
                .IsBorrowed()
                .AddReturnDate(10)
                .AddBookId(id)
                .AddUser(user)
                .Build();

            _context.BookBorrow.Add(bookBorrow);
            _context.SaveChanges();
        }



        public Book GetBookById(int id)
        {
            if (CheckIfBookIsBorrowed(id))
            {
                throw new ValidationErrorExeption("Book is borrowed");
            }

            Book book = _context.Book.Where(x => x.Id == id).SingleOrDefault();

            if (book == null)
            {
                throw new ValidationErrorExeption("Book dosnt exist");
            }

            return book;
        }

        public List<BookBorrow> GetBorrowHistory(int userId)
        {
            User userExist = _context.User.Where(x => x.Id == userId).SingleOrDefault();
            if(userExist == null)
            {
                throw new ValidationErrorExeption("User with this id dosnt exist");
            }

            return _context.BookBorrow.Where(x => x.UserId == userId).ToList();
        }

        public string ReturnBook(int id)
        {
            BookBorrow bookBorrow = _context.BookBorrow.Where(x => x.Id == id).SingleOrDefault();

            if (bookBorrow == null)
            {
               throw new ValidationErrorExeption("Not found!");
            }

            bookBorrow.IsReturned = true;
            bookBorrow.ReturnedDated = DateTime.Now;
            _context.SaveChanges();
            return "Success";
        }

        public bool CheckIfBookIsBorrowed(int id)
        {
            BookBorrow isBookBorrower = _context.BookBorrow.Where(x => x.Book.Id == id && !x.IsReturned)
                .Include(x => x.Book)
                .FirstOrDefault();
            return isBookBorrower != null ? true : false;
        }
    }
}
