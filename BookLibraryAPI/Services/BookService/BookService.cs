﻿using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using BookLibraryAPI.Data.CustomException;
using Microsoft.EntityFrameworkCore;
using BookLibraryAPI.Repositories;

namespace BookLibraryAPI.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public ServiceResult<Book> CreateBook(Book book)
        {
            CreateBookValidation createBookValid = new CreateBookValidation();
            
            if (!createBookValid.Validate(book, out string error))
            {
                return ServiceResult<Book>.Failure(error);
            }

            _bookRepository.CreateBook(book);
            return ServiceResult<Book>.Success(book);
        }

        public ServiceResult<Book> EditBook(int id, Book book)
        {
            CreateBookValidation createBookValid = new CreateBookValidation();

            if (!createBookValid.Validate(book, out string error))
            {
                return ServiceResult<Book>.Failure(error);
            }

            Book bookResult = _bookRepository.GetBookById(id);
            if(bookResult == null)
            {
                return ServiceResult<Book>.Failure("Book wasnt found");
            }

            return ServiceResult<Book>.Success(_bookRepository.EditBook(id, book));
        }

        public ServiceResult<string> DeleteBook(int id)
        {
            Book book = _bookRepository.GetBookById(id);

            if(book == null ) 
            {
               return ServiceResult<string>.Failure("Not found!");
            }

            _bookRepository.DeleteBook(book);
            return ServiceResult<string>.Success("Success");
        }

        public ServiceResult<List<Book>> GetAllBooks()
        {
            return ServiceResult<List<Book>>.Success(_bookRepository.GetAllBooks());
        }
    }
}
