using BookLibraryAPI.Data;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.DTO;
using BookLibraryAPI.Installation;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost()]
        [Authorize(Roles = "Admin")]
        public Task<IActionResult> CreateUser(User user)
        {
            return _userService.CreateUser(user).Result();
        }

        [HttpGet()]
        [Authorize]
        public  Task<IActionResult> GetUserById(int id)
        {
            return _userService.GetUserById(id).Result();
        }
        [HttpGet()]
        [Authorize]
        [Route("email ={email}")]
        public Task<IActionResult> GetUserByEmail(string email)
        {
            return _userService.GetUserByEmail(email).Result();
        }

        [HttpGet()]
        [Authorize]
        [Route("Me")]
        public Task<IActionResult> GetMyself()
        {
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            return _userService.GetUserByEmail(userId).Result();
        }

        [HttpPost]
        [Route("Login")]
        public Task<IActionResult> Login(User user)
        {
            return _userService.Login(user).Result();
        }
    }
}
