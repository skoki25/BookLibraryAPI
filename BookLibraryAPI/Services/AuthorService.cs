using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;

namespace BookLibraryAPI.Services
{
    public class AuthorService : IAuthorService
    {
        public async Task<ServiceResult<Author>> CreateAuthor(Author author)
        {
            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author,out string error))
            {
                return ServiceResult<Author>.Failure(error);
            }

            throw new ValidationErrorExeption("");
        }

        public Task<string> DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Author> EditAuthor(int id, Author author)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Author>> GetAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
