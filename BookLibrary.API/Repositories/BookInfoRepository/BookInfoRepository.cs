using BookLibrary.Models;
using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Repositories
{
    public class BookInfoRepository : IBookInfoRepository
    {
        private LibraryDbContext _context;

        public BookInfoRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public BookInfo CreateBookInfo(BookInfo bookInfo)
        {
            _context.BookInfo.Add(bookInfo);
            _context.SaveChanges();
            return bookInfo;
        }

        public BookInfo GetBookInfoWithBooks(int id)
        {
            BookInfo bookInfo = _context.BookInfo.Where(x => x.Id == id)
                .Include(x => x.Books)
                .FirstOrDefault();
            return bookInfo;
        }

        public void DeleteBookInfo(BookInfo bookInfo)
        {
            _context.Remove(bookInfo);
        }

        public BookInfo EditBookInfo(int id, BookInfo bookInfo)
        {
            BookInfo editBookInfo = GetBookInfoWithBooks(id);

            editBookInfo.AuthorId = bookInfo.AuthorId;
            editBookInfo.CategoryId = bookInfo.CategoryId;
            editBookInfo.Description = bookInfo.Description;
            editBookInfo.Title = bookInfo.Title;

            _context.SaveChangesAsync();
            return editBookInfo;
        }

        public BookInfo GetBookInfoById(int id)
        {
            return _context.BookInfo.Where(x => x.Id == id).SingleOrDefault();
        }

        public BookInfo GetBookInfoByIdWithExtra(int id)
        {
            return _context.BookInfo.Where(x => x.Id == id)
                .Include(x => x.Author)
                .Include(x => x.Category)
                .SingleOrDefault();
        }
    }
}
