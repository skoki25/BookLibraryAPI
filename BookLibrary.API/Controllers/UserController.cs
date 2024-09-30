using BookLibrary.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> CreateUser(User user)
        {
            return await _userService.CreateUser(user);
        }

        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }
        [HttpGet()]
        [Authorize]
        [Route("email ={email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            return await _userService.GetUserByEmail(email);
        }

        [HttpGet()]
        [Authorize]
        [Route("Me")]
        public async Task<IActionResult> GetMyself()
        {
            string userId = User.FindFirst(ClaimTypes.Name)?.Value;
            return await _userService.GetUserByEmail(userId);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(User user)
        {
            return await _userService.Login(user);
        }
    }
}
