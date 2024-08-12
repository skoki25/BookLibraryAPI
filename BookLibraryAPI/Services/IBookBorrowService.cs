using BookLibraryAPI.DTO;
using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace BookLibraryAPI.Services
{
    public interface IBookBorrowService
    {
        ServiceResult<Book> GetBookById(int id);
        ServiceResult<string> BorrowBook(int id, string userEmail);
        ServiceResult<BookBorrow> ReturnBook(int id);
        ServiceResult<List<BookBorrowDto>>GetBorrowHistory(int userId);
        bool CheckIfBookIsBorrowed(int id);
    }
}
