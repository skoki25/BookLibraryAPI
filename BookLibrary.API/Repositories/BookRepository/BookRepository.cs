using BookLibrary.Models;
using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Repositories
{
    public class BookRepository: IBookRepository
    {
        private LibraryDbContext _context;

        public BookRepository(LibraryDbContext context) 
        {
            _context = context;
        }
        public async Task<Book> CreateBook(Book book)
        {
            _context.Book.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async void DeleteBook(Book book)
        {
            List<BookInfo> bookInfo = await GetBookBookInfoId(book.BookInfoId);

            if (bookInfo.Count() == 1)
            {
                _context.Remove(bookInfo[0]);
            }
            _context.Remove(book);

            await _context.SaveChangesAsync();
        }

        public async Task<Book> EditBook(int id, Book book)
        {
            Book bookResult = await _context.Book.Where(x => x.Id == id).SingleOrDefaultAsync();
            bookResult.EanCode = book.EanCode;
            bookResult.ISO = book.ISO;
            bookResult.PublicationDate = book.PublicationDate;
            bookResult.BookInfoId = book.BookInfoId;
            await _context.SaveChangesAsync();
            return bookResult;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            return await _context.Book
                .Include(x=> x.BookInfo) 
                .ToListAsync();
        }

        public async Task<List<BookInfo>> GetBookBookInfoId(int bookInfoId)
        {
            return await _context.BookInfo.Where(x => x.Id == bookInfoId)
                .Include(x=> x.Books)
                .ToListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Book.Where(x => x.Id == id).SingleOrDefaultAsync();
        }
    }
}
