using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;

namespace UnitTest.FakeRepositories
{
    public class AuthorTestRepository : IAuthorRepository
    {
        List<Author> authorList;

        public AuthorTestRepository()
        {
            authorList = new List<Author>();
            AddTestAuthors();
        }

        private void AddTestAuthors()
        {
            authorList.Add(new Author { Id = 1, Age = 25, FirstName = "Arthur", LastName = "Last" });
            authorList.Add(new Author { Id = 2, Age = 14, FirstName = "Ben", LastName = "Last" });
            authorList.Add(new Author { Id = 3, Age = 59, FirstName = "Daniel", LastName = "Last" });
            authorList.Add(new Author { Id = 4, Age = 87, FirstName = "Cecil", LastName = "Last" });
            authorList.Add(new Author { Id = 5, Age = 52, FirstName = "Fan", LastName = "Last" });
        }

        public Author CreateAuthor(Author author)
        {
            authorList.Add(author);
            return author;

        }

        public Author FindAuthor(int id)
        {

            return authorList.Where(x=> x.Id == id).FirstOrDefault();
        }

        public List<Author> GetAuthors()
        {
            return authorList;
        }

        public List<BookInfo> GetBookInfoByAuthorId(int id)
        {
            throw new NotImplementedException();
        }

        public Author Update(int id, Author author)
        {
            Author authorSearch = authorList.Where(x => x.Id == id).SingleOrDefault();
            authorSearch.FirstName = author.FirstName;
            authorSearch.LastName = author.LastName;
            authorSearch.Age = author.Age;
            return authorSearch;

        }
    }
}
