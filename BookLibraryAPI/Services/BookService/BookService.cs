using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BookLibraryAPI.Data.CustomException;
using Microsoft.EntityFrameworkCore;
using BookLibraryAPI.Repositories;
using AutoMapper;
using BookLibraryAPI.DTO;

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
        public ServiceResult<Book> CreateBook(Book book)
        {
            CreateBookValidation createBookValid = new CreateBookValidation();
            
            if (!createBookValid.Validate(book, out string error))
            {
                return ServiceResult<Book>.Failure(error, ResultType.BadRequest);
            }

            _bookRepository.CreateBook(book);
            return ServiceResult<Book>.Success(book);
        }

        public ServiceResult<Book> EditBook(int id, Book book)
        {
            CreateBookValidation createBookValid = new CreateBookValidation();

            if (!createBookValid.Validate(book, out string error))
            {
                return ServiceResult<Book>.Failure(error, ResultType.BadRequest);
            }

            Book bookResult = _bookRepository.GetBookById(id);
            if(bookResult == null)
            {
                return ServiceResult<Book>.Failure("Book wasnt found", ResultType.NotFound);
            }

            return ServiceResult<Book>.Success(_bookRepository.EditBook(id, book));
        }

        public ServiceResult<string> DeleteBook(int id)
        {
            Book book = _bookRepository.GetBookById(id);

            if(book == null ) 
            {
               return ServiceResult<string>.Failure("Not found!", ResultType.NotFound);
            }

            _bookRepository.DeleteBook(book);
            return ServiceResult<string>.Success("Success");
        }

        public ServiceResult<List<BookDto>> GetAllBooks()
        {
            List<Book> books = _bookRepository.GetAllBooks();

            

            return ServiceResult<List<BookDto>>.Success(_mapper.Map<List<BookDto>>(books));
        }
    }
}
