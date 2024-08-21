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
        public IActionResult CreateUser(User user)
        {
            return this.ServiceToActionResult(_userService.CreateUser(user));
        }

        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> GetUserById(int id)
        {
            return await this.ServiceToActionTask<UserDto>(_userService.GetUserById(id));
        }
        [HttpGet()]
        [Authorize]
        [Route("email ={email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            return await this.ServiceToActionTask<UserDto>(_userService.GetUserByEmail(email));
        }

        [HttpGet()]
        [Authorize]
        [Route("Me")]
        public async Task<IActionResult> GetMyself()
        {
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            return await this.ServiceToActionTask<UserDto>(_userService.GetUserByEmail(userId));
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(User user)
        {
            return await this.ServiceToActionTask(_userService.Login(user));
        }
    }
}
