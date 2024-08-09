using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IBookService
    {
        void CreateBook(Book book);
        List<Book> GetAllBooks();
        void DeleteBook(int id);
    }
}
