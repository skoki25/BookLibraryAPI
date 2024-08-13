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
            try
            {
                _userService.CreateUser(user);
                return Ok(user);
            }catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> GetUserById(int id)
        {
            return await this.ServiceToActionTask<UserDto>(_userService.GetUserById(id));
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(User user)
        {
            return await this.ServiceToActionTask(_userService.Login(user));
        }
    }
}
