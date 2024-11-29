using BookLibrary.Model.Messages;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public interface IAuthorService
    {
        Task<IActionResult> GetAuthorById(int id);
        Task<IActionResult>GetAuthors();
        Task<IActionResult> CreateAuthor(Author author);
        Task<IActionResult> EditAuthor(int id, Author author);
        Task<IActionResult> DeleteAuthor(int id);
    }
}
