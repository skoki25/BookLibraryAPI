using BookLibraryAPI.Models;

namespace BookLibraryAPI.Repositories
{
    public class AuthorRepository: IAuthorRepository
    {
        private LibraryDbContext _context;
        private bool _disposed =false;

        public AuthorRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public Author CreateAuthor(Author author)
        {
            _context.Author.Add(author);
            _context.SaveChanges();
            return author;
        }

        public Author FindAuthor(int id)
        {
            return _context.Author.Where(x => x.Id == id).SingleOrDefault();
        }

        public List<Author> GetAuthors()
        {
            return _context.Author.ToList();
        }

        public List<BookInfo> GetBookInfoByAuthorId(int id)
        {
            return _context.BookInfo.Where(x => x.AuthorId == id).ToList();
        }

        public Author Update(int id, Author author)
        {
            Author authorResult = FindAuthor(id);
            authorResult.Age = author.Age;
            authorResult.FirstName = author.FirstName;
            authorResult.LastName = author.LastName;
            _context.SaveChanges();

            return authorResult;
        }
    }
}
