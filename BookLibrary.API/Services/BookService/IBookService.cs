using BookLibrary.Model.DTO;
using BookLibrary.Models;

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
