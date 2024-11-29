using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IAuthorRepository
    {
        public Task<Author> CreateAuthor(Author author);
        public Task<Author> FindAuthor(int author);
        public Task<List<BookInfo>> GetBookInfoByAuthorId(int id);
        public Task<Author> Update(int id, Author author);
        public Task<List<Author>> GetAuthors();
    }
}
