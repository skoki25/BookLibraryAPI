using BookLibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace BookLibraryAPI.Services
{
    public interface IBookBorrowService
    {
        Book GetBookById(int id);
        void Borrow(int id, string userEmail);
        string ReturnBook(int id);
        List<BookBorrow>GetBorrowHistory(int userId);
        bool CheckIfBookIsBorrowed(int id);
    }
}
