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
                return ServiceResult<Author>.Failure(error, ResultType.BadRequest);
            }

            _authorRepository.CreateAuthor(author);     
            return ServiceResult<Author>.Success(author);
        }

        public ServiceResult<string> DeleteAuthor(int id)
        {
            Author author = _authorRepository.FindAuthor(id);
            if(author == null)
            {
                return ServiceResult<string>.Failure("Author want found", ResultType.NotFound);
            }

            List<BookInfo> bookInfo = _authorRepository.GetBookInfoByAuthorId(id);

            if(bookInfo.Count > 0)
            {
                return ServiceResult<string>.Failure("Author cannot be remove", ResultType.BadRequest);
            }

           // _context.Author.Remove(author);

            return ServiceResult<string>.Success("Success!");
        }

        public ServiceResult<Author> EditAuthor(int id, Author author)
        {
            Author authorResult = _authorRepository.FindAuthor(id);
            if (author == null)
            {
                return ServiceResult<Author>.Failure("Author wanst found", ResultType.NotFound);
            }

            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author, out string error))
            {
                return ServiceResult<Author>.Failure(error, ResultType.BadRequest);
            }

            return ServiceResult<Author>.Success(_authorRepository.Update(id, author));
        }

        public ServiceResult<Author> GetAuthorById(int id)
        {
            Author author = _authorRepository.FindAuthor(id);
            if (author == null)
            {
                return ServiceResult<Author>.Failure("Author wanst found", ResultType.NotFound);
            }

            return ServiceResult<Author>.Success(author);
        }

        public ServiceResult<List<Author>> GetAuthors()
        {
            return ServiceResult<List<Author>>.Success(_authorRepository.GetAuthors());
        }
    }
}
