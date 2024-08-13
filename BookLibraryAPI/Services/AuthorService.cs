using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;

namespace BookLibraryAPI.Services
{
    public class AuthorService : IAuthorService
    {

        IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public ServiceResult<Author> CreateAuthor(Author author)
        {
            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author,out string error))
            {
                return ServiceResult<Author>.Failure(error);
            }

            _authorRepository.CreateAuthor(author);     
            return ServiceResult<Author>.Success(author);
        }

        public ServiceResult<string> DeleteAuthor(int id)
        {
            Author author = _authorRepository.FindAuthor(id);
            if(author == null)
            {
                return ServiceResult<string>.Failure("Author want found");
            }

            List<BookInfo> bookInfo = _authorRepository.GetBookInfoByAuthorId(id);

            if(bookInfo.Count > 0)
            {
                return ServiceResult<string>.Failure("Author cannot be remove");
            }

            _context.Author.Remove(author);

            return ServiceResult<string>.Success("Success!");
        }

        public ServiceResult<Author> EditAuthor(int id, Author author)
        {
            Author authorResult = _authorRepository.FindAuthor(id);
            if (author == null)
            {
                return ServiceResult<Author>.Failure("Author wanst found");
            }

            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author, out string error))
            {
                return ServiceResult<Author>.Failure(error);
            }

            return ServiceResult<Author>.Success(_authorRepository.Update(id, author));
        }

        public ServiceResult<Author> GetAuthorById(int id)
        {
            Author author = _authorRepository.FindAuthor(id);
            if (author == null)
            {
                return ServiceResult<Author>.Failure("Author wanst found");
            }

            return ServiceResult<Author>.Success(author);
        }

        public ServiceResult<List<Author>> GetAuthors()
        {
            return ServiceResult<List<Author>>.Success(_authorRepository.GetAuthors());
        }
    }
}
