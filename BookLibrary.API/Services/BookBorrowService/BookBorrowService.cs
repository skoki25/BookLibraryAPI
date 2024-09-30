using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Models;
using BookLibraryAPI.Data.Builder;
using BookLibraryAPI.Data.Config;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;

namespace BookLibraryAPI.Services
{
    public class BookBorrowService : IBookBorrowService
    {
        private LibraryDbContext _context = new LibraryDbContext();
        private IMapper _map;
        private IBookRepository _bookRepository;

        public BookBorrowService(IMapper map, IBookRepository bookRepository)
        {
            _map = map;
            _bookRepository = bookRepository;
        }

        public async Task<IActionResult> BorrowBook(int id, string userEmail)
        {
            Book book = await _bookRepository.GetBookById(id);
            if(book == null)
            {
                return ServiceResult<string>.Failure("Book dosnt exist!", ResultType.NotFound);
            }

            if (await CheckIfBookIsBorrowed(id))
            {
                return ServiceResult<string>.Failure("Book is borrowed!", ResultType.BadRequest);
            }
            User user = _context.User.Where(x => x.Email == userEmail).SingleOrDefault();

            if (user == null)
            {
                return ServiceResult<string>.Failure("Problem",ResultType.NotFound);
            }

            List<BookBorrow> borrowBooksList = _context.BookBorrow.Where(x => x.UserId == user.Id && !x.IsReturned)
                        .ToList();

            if (borrowBooksList.Count >= Config.MaxBorrowedBook)
            {
                return ServiceResult<string>.Failure($"User had borrow {Config.MaxBorrowedBook} books already",ResultType.BadRequest);
            }

            BookBorrow bookBorrow = new BookBorrowBuilder()
                .IsBorrowed()
                .AddReturnDate(10)
                .AddBookId(id)
                .AddUser(user)
                .Build();

            _context.BookBorrow.Add(bookBorrow);
            _context.SaveChanges();
            return ServiceResult<string>.Success("Success");
        }

        public async Task<IActionResult> GetBookById(int id)
        {
            bool isBookBorrowed = await CheckIfBookIsBorrowed(id);
            if (isBookBorrowed)
            {
                ServiceResult<Book>.Failure("Book is borrowed", ResultType.BadRequest);
            }

            Book book = await _context.Book.Where(x => x.Id == id).SingleOrDefaultAsync();

            if (book == null)
            {
                ServiceResult<Book>.Failure("Book dosnt exist", ResultType.NotFound);
            }

            return ServiceResult<Book>.Success(book);
        }

        public async Task<IActionResult> GetBorrowHistory(int userId)
        {
            List<BookBorrow>bookBorrows = await _context.BookBorrow.Where(x => x.UserId == userId)
                .Include(x=> x.Book)
                .ThenInclude(x=> x.BookInfo)
                .ToListAsync();
            List<BookBorrowDto>mapped  =_map.Map<List<BookBorrowDto>>(bookBorrows);

            return ServiceResult<List<BookBorrowDto>>.Success(mapped);
        }

        public async Task<IActionResult> ReturnBook(int bookId)
        {
            BookBorrow bookBorrow = await _context.BookBorrow.Where(x => x.BookId == bookId && !x.IsReturned)
                .SingleOrDefaultAsync();

            if (bookBorrow == null)
            {
                return ServiceResult<BookBorrow>.Failure("Not found!", ResultType.NotFound);
            }

            bookBorrow.IsReturned = true;
            bookBorrow.ReturnedDated = DateTime.Now;
            await _context.SaveChangesAsync();
            return ServiceResult<BookBorrow>.Success(bookBorrow);
        }

        public async Task<bool> CheckIfBookIsBorrowed(int id)
        {
            BookBorrow isBookBorrower = await _context.BookBorrow.Where(x => x.BookId == id && !x.IsReturned)
                .Include(x => x.Book)
                .FirstOrDefaultAsync();
            return isBookBorrower != null ? true : false;
        }
    }
}
