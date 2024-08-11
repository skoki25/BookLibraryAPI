using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IAuthorService
    {
        ServiceResult<Author> GetAuthorById(int id);
        ServiceResult<List<Author>>GetAuthors();
        ServiceResult<Author> CreateAuthor(Author author);
        ServiceResult<Author> EditAuthor(int id, Author author);
        ServiceResult<string> DeleteAuthor(int id);
    }
}
