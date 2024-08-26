using BookLibraryAPI.DTO;
using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IBookService
    {
        ServiceResult<Book> CreateBook(Book book);
        ServiceResult<List<BookDto>> GetAllBooks();
        ServiceResult<string> DeleteBook(int id);
        ServiceResult<Book> EditBook(int id, Book book);
    }
}
