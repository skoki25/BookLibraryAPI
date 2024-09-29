using BookLibrary.Models;
using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Author> CreateAuthor(Author author)
        {
            _context.Author.Add(author);
            await _context.SaveChangesAsync();
            return author;
        }

        public async Task<Author> FindAuthor(int id)
        {
            return await _context.Author.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<List<Author>> GetAuthors()
        {
            return await _context.Author.ToListAsync();
        }

        public async Task<List<BookInfo>> GetBookInfoByAuthorId(int id)
        {
            return await _context.BookInfo.Where(x => x.AuthorId == id).ToListAsync();
        }

        public async Task<Author> Update(int id, Author author)
        {
            Author authorResult = await FindAuthor(id);
            authorResult.Age = author.Age;
            authorResult.FirstName = author.FirstName;
            authorResult.LastName = author.LastName;
            await _context.SaveChangesAsync();

            return authorResult;
        }
    }
}
