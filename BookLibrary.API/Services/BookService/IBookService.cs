using BookLibrary.Model.DTO;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public interface IBookService
    {
        Task<IActionResult> CreateBook(Book book);
        Task<IActionResult> GetAllBooks();
        Task<IActionResult> DeleteBook(int id);
        Task<IActionResult> EditBook(int id, BookSimpleDto book);
    }
}
