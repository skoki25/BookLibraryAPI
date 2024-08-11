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

        public ServiceResult<string> BorrowBook(int id, string userEmail)
        {
            if (CheckIfBookIsBorrowed(id))
            {
                return ServiceResult<string>.Failure("Book is borrowed");
            }
            User user = _context.User.Where(x => x.Email == userEmail).SingleOrDefault();

            if (user == null)
            {
                return ServiceResult<string>.Failure("Problem");
            }

            List<BookBorrow> borrowBooksList = _context.BookBorrow.Where(x => x.UserId == user.Id && !x.IsReturned)
                        .ToList();

            if (borrowBooksList.Count >= Config.MaxBorrowedBook)
            {
                return ServiceResult<string>.Failure($"User had borrow {Config.MaxBorrowedBook} books already");
            }

            BookBorrow bookBorrow = new BookBorrowBuilder()
                .IsBorrowed()
                .AddReturnDate(10)
                .AddBookId(id)
                .AddUser(user)
                .Build();

            _context.BookBorrow.Add(bookBorrow);
            _context.SaveChanges();
            return ServiceResult<string>.Success("Success");
        }

        public ServiceResult<Book> GetBookById(int id)
        {
            if (CheckIfBookIsBorrowed(id))
            {
                ServiceResult<Book>.Failure("Book is borrowed");
            }

            Book book = _context.Book.Where(x => x.Id == id).SingleOrDefault();

            if (book == null)
            {
                ServiceResult<Book>.Failure("Book dosnt exist");
            }

            return ServiceResult<Book>.Success(book);
        }

        public ServiceResult<List<BookBorrow>> GetBorrowHistory(int userId)
        {
            List<BookBorrow>bookBorrows = _context.BookBorrow.Where(x => x.UserId == userId)
                .ToList();
            return ServiceResult<List<BookBorrow>>.Success(bookBorrows);
        }

        public ServiceResult<BookBorrow> ReturnBook(int bookId)
        {
            BookBorrow bookBorrow = _context.BookBorrow.Where(x => x.BookId == bookId && !x.IsReturned)
                .SingleOrDefault();

            if (bookBorrow == null)
            {
                return ServiceResult<BookBorrow>.Failure("Not found!");
            }

            bookBorrow.IsReturned = true;
            bookBorrow.ReturnedDated = DateTime.Now;
            _context.SaveChanges();
            return ServiceResult<BookBorrow>.Success(bookBorrow);
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
