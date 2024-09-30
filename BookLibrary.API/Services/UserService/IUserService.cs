
using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public interface IUserService
    {
        Task<IActionResult> CreateUser(User user);
        Task<IActionResult> GetUserById(int id);
        Task<IActionResult> GetUserByEmail(string id);
        Task<IActionResult> Login(User user);
    }
}
