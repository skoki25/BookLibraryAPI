using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IBookRepository
    {
        public Book CreateBook(Book book);
        public Book GetBookById(int id);
        public List<BookInfo> GetBookBookInfoId(int bookInfoId);
        public void DeleteBook(Book book);
        public List<Book>GetAllBooks();
        public Book EditBook(int id, Book book);
    }
}
