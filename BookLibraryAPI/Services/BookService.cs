using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BookLibraryAPI.Data.CustomException;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Services
{
    public class BookService : IBookService
    {
        private LibraryDbContext _context = new LibraryDbContext();

        public void CreateBook(Book book)
        {
            CreateBookValidation createBookValid = new CreateBookValidation();
            
            if (!createBookValid.Validate(book, out string error))
            {
                throw new ValidationErrorExeption(error);
            }

            _context.Book.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(int id)
        {
            Book book = _context.Book.Where(x => x.Id == id).SingleOrDefault();

            if(book == null ) 
            {
                throw new ValidationErrorExeption("Not found!");
            }

            List<BookInfo> bookInfo = _context.BookInfo.Where(x => x.Id == book.BookInfoId)
                .Include(x => x.Books)
                .ToList();

            _context.Remove(book);
            if(bookInfo.Count() == 1)
            {
                _context.Remove(bookInfo[0]);
            }

            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Book.ToList();
        }
    }
}
