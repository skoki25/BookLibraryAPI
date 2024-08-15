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
        public Book CreateBook(Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
            return book;
        }

        public void DeleteBook(Book book)
        {
            List<BookInfo> bookInfo = GetBookBookInfoId(book.BookInfoId);

            if (bookInfo.Count() == 1)
            {
                _context.Remove(bookInfo[0]);
            }
            _context.Remove(book);

            _context.SaveChanges();
        }

        public Book EditBook(int id, Book book)
        {
            Book bookResult = _context.Book.Where(x => x.Id == id).SingleOrDefault();
            bookResult.EanCode = book.EanCode;
            bookResult.ISO = book.ISO;
            bookResult.PublicationDate = book.PublicationDate;
            return bookResult;
        }

        public List<Book> GetAllBooks()
        {
            return _context.Book.ToList();
        }

        public List<BookInfo> GetBookBookInfoId(int bookInfoId)
        {
            return _context.BookInfo.Where(x => x.Id == bookInfoId)
                .Include(x=> x.Books)
                .ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Book.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
