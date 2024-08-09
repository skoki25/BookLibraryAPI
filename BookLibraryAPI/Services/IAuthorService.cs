using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IAuthorService
    {
        Task<Author>GetAuthorById(int id);
        Task<List<Author>>GetAuthors();
        Task<ServiceResult<Author>> CreateAuthor(Author author);
        Task<Author> EditAuthor(int id, Author author);
        Task<string> DeleteAuthor(int id);
    }
}
