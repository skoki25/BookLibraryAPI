using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IBookRepository
    {
        public Task<Book> CreateBook(Book book);
        public Task<Book> GetBookById(int id);
        public Task<List<BookInfo>> GetBookBookInfoId(int bookInfoId);
        public void DeleteBook(Book book);
        public Task<List<Book>>GetAllBooks();
        public Task<Book> EditBook(int id, Book book);
    }
}
