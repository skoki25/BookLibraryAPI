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

        public async Task<BookInfo> CreateBookInfo(BookInfo bookInfo)
        {
            _context.BookInfo.Add(bookInfo);
            await _context.SaveChangesAsync();
            return bookInfo;
        }

        public async Task<BookInfo> GetBookInfoWithBooks(int id)
        {
            BookInfo bookInfo = await _context.BookInfo.Where(x => x.Id == id)
                .Include(x => x.Books)
                .FirstOrDefaultAsync();
            return bookInfo;
        }

        public async void DeleteBookInfo(BookInfo bookInfo)
        {
            _context.Remove(bookInfo);
            await _context.SaveChangesAsync();
        }

        public async  Task<BookInfo> EditBookInfo(int id, BookInfo bookInfo)
        {
            BookInfo editBookInfo = await GetBookInfoWithBooks(id);

            editBookInfo.AuthorId = bookInfo.AuthorId;
            editBookInfo.CategoryId = bookInfo.CategoryId;
            editBookInfo.Description = bookInfo.Description;
            editBookInfo.Title = bookInfo.Title;

            _context.SaveChangesAsync();
            return editBookInfo;
        }

        public async Task<BookInfo> GetBookInfoById(int id)
        {
            return await _context.BookInfo.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<BookInfo> GetBookInfoByIdWithExtra(int id)
        {
            return await _context.BookInfo.Where(x => x.Id == id)
                .Include(x => x.Author)
                .Include(x => x.Category)
                .SingleOrDefaultAsync();
        }

        public async Task<List<BookInfo>> GetAllBookInfo()
        {
            return await _context.BookInfo.Include(x => x.Author)
                .Include(x => x.Category)
                .ToListAsync();
        }
    }
}
