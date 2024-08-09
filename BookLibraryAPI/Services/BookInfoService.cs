using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Services
{
    public class BookInfoService : IBookInfoService
    {
        private LibraryDbContext _context = new LibraryDbContext();
        
        public void CreateBookInfo(BookInfo bookInfo)
        {
            CreateBookInfoValidation validationRules = new CreateBookInfoValidation();

            if (!validationRules.Validate(bookInfo,out string error))
            {
                throw new ValidationErrorExeption(error);
            }

            _context.BookInfo.Add(bookInfo);
            _context.SaveChanges();
        }

        public void DeleteBookInfo(int id)
        {
            BookInfo bookInfo = _context.BookInfo.Where(x => x.Id == id)
                .Include(x=> x.Books)
                .FirstOrDefault();

            if (bookInfo == null)
            {
                throw new ValidationErrorExeption("Wasnt found");
            }

            if(bookInfo.Books.Count() != 0)
            {
                throw new ValidationErrorExeption("Book info has book");
            }

            _context.Remove(bookInfo);
        }

        public void EditBookInfo(int id, BookInfo bookInfo)
        {
            CreateBookInfoValidation validationRules = new CreateBookInfoValidation();

            if (!validationRules.Validate(bookInfo, out string error))
            {
                throw new ValidationErrorExeption(error);
            }

            BookInfo editBookInfo = _context.BookInfo.Where(x => x.Id == id).SingleOrDefault();

            if(editBookInfo == null)
            {
                throw new ValidationErrorExeption("Not found");
            }

            editBookInfo.AuthorId = bookInfo.AuthorId;
            editBookInfo.CategoryId = bookInfo.CategoryId;
            editBookInfo.Description = bookInfo.Description;
            editBookInfo.Title = bookInfo.Title;

            _context.SaveChanges();
        }

        public BookInfo GetBookInfo(int id)
        {
            return _context.BookInfo.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
