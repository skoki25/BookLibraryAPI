using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{

    public class AuthorService : IAuthorService
    {

        IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<IActionResult> CreateAuthor(Author author)
        {
            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author,out string error))
            {
                return ServiceResult<Author>.Failure2(error, ResultType.BadRequest);
            }

            _authorRepository.CreateAuthor(author);     
            return ServiceResult<Author>.Success2(author);
        }

        public async Task<IActionResult> DeleteAuthor(int id)
        {
            Author author = await _authorRepository.FindAuthor(id);
            if(author == null)
            {
                return ServiceResult<string>.Failure2("Author want found", ResultType.NotFound);
            }

            List<BookInfo> bookInfo = await _authorRepository.GetBookInfoByAuthorId(id);

            if(bookInfo.Count > 0)
            {
                return ServiceResult<string>.Failure2("Author cannot be remove", ResultType.BadRequest);
            }

           // _context.Author.Remove(author);

            return ServiceResult<string>.Success2("Success!");
        }

        public async Task<IActionResult> EditAuthor(int id, Author author)
        {
            Author authorResult = await _authorRepository.FindAuthor(id);
            if (author == null)
            {
                return ServiceResult<Author>.Failure2("Author wanst found", ResultType.NotFound);
            }

            AuthorValidation validationRules = new AuthorValidation();

            if (!validationRules.Validate(author, out string error))
            {
                return ServiceResult<Author>.Failure2(error, ResultType.BadRequest);
            }

            return ServiceResult<Author>.Success2(await _authorRepository.Update(id, author));
        }

        public async Task<IActionResult> GetAuthorById(int id)
        {
            Author author = await _authorRepository.FindAuthor(id);
            if (author == null)
            {
                return ServiceResult<Author>.Failure2("Author wanst found", ResultType.NotFound);
            }

            return ServiceResult<Author>.Success2(author);
        }

        public async Task<IActionResult> GetAuthors()
        {
            return ServiceResult<List<Author>>.Success2(await _authorRepository.GetAuthors());
        }
    }
}
