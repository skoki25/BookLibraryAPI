using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IAuthorRepository
    {
        public Author CreateAuthor(Author author);
        public Author FindAuthor(int author);
        public List<BookInfo> GetBookInfoByAuthorId(int id);
        public Author Update(int id, Author author);
        public List<Author> GetAuthors();
    }
}
