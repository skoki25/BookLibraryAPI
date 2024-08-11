using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;

namespace BookLibraryAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private LibraryDbContext _context = new LibraryDbContext();
        public ServiceResult<Author> CreateAuthor(Author author)
        {
            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author,out string error))
            {
                return ServiceResult<Author>.Failure(error);
            }

            _context.Add(author);
            return ServiceResult<Author>.Success(author);
        }

        public ServiceResult<string> DeleteAuthor(int id)
        {
            Author author = _context.Author.Where(x => x.Id == id).SingleOrDefault();
            if(author == null)
            {
                return ServiceResult<string>.Failure("Author want found");
            }

            List<BookInfo> bookInfo = _context.BookInfo.Where(x=> x.AuthorId == id).ToList();

            if(bookInfo.Count > 0)
            {
                return ServiceResult<string>.Failure("Author cannot be remove");
            }

            _context.Author.Remove(author);

            return ServiceResult<string>.Success("Success!");
        }

        public ServiceResult<Author> EditAuthor(int id, Author author)
        {
            Author authorResult = _context.Author.Where(x => x.Id == id).SingleOrDefault();
            if (author == null)
            {
                return ServiceResult<Author>.Failure("Author wanst found");
            }

            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author, out string error))
            {
                return ServiceResult<Author>.Failure(error);
            }

            authorResult.Age = author.Age;
            authorResult.FirstName = author.FirstName;
            authorResult.LastName = author.LastName;
            _context.SaveChanges();
            return ServiceResult<Author>.Success(authorResult);
        }

        public ServiceResult<Author> GetAuthorById(int id)
        {
            Author author = _context.Author.Where(x => x.Id == id).SingleOrDefault();
            if (author == null)
            {
                return ServiceResult<Author>.Failure("Author wanst found");
            }

            return ServiceResult<Author>.Success(author);
        }

        public ServiceResult<List<Author>> GetAuthors()
        {
            return ServiceResult<List<Author>>.Success(_context.Author.ToList());
        }
    }
}
