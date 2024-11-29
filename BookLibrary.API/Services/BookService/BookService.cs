using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;
using AutoMapper;
using BookLibrary.Models;
using BookLibrary.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private IMapper _mapper;
        public BookService(IBookRepository bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> CreateBook(Book book)
        {
            CreateBookValidation createBookValid = new CreateBookValidation();
            
            if (!createBookValid.Validate(book, out string error))
            {
                return ServiceResult<Book>.Failure(error, ResultType.BadRequest);
            }

            _bookRepository.CreateBook(book);
            return ServiceResult<Book>.Success(book);
        }

        public async Task<IActionResult> EditBook(int id, BookSimpleDto bookSimple)
        {
            Book book = _mapper.Map<Book>(bookSimple);
            CreateBookValidation createBookValid = new CreateBookValidation();
            if (!createBookValid.Validate(book, out string error))
            {
                return ServiceResult<Book>.Failure(error, ResultType.BadRequest);
            }

            Book bookResult = await _bookRepository.GetBookById(id);
            if(bookResult == null)
            {
                return ServiceResult<Book>.Failure("Book wasnt found", ResultType.NotFound);
            }

            return ServiceResult<Book>.Success(await _bookRepository.EditBook(id, book));
        }

        public async Task<IActionResult> DeleteBook(int id)
        {
            Book book = await _bookRepository.GetBookById(id);

            if(book == null ) 
            {
               return ServiceResult<string>.Failure("Not found!", ResultType.NotFound);
            }

            _bookRepository.DeleteBook(book);
            return ServiceResult<string>.Success("Success");
        }

        public async Task<IActionResult> GetAllBooks()
        {
            List<Book> books = await _bookRepository.GetAllBooks();
            return ServiceResult<List<BookDto>>.Success( _mapper.Map<List<BookDto>>(books));
        }
    }
}
