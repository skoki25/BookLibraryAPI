using BookLibrary.Model.DTO;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace BookLibraryAPI.Services
{
    public interface IBookBorrowService
    {
        Task<IActionResult> GetBookById(int id);
        Task<IActionResult> BorrowBook(int id, string userEmail);
        Task<IActionResult> ReturnBook(int id);
        Task<IActionResult> GetBorrowHistory(int userId);
        Task<bool> CheckIfBookIsBorrowed(int id);
    }
}
