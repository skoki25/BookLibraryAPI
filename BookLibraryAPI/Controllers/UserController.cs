using BookLibraryAPI.Data;
using BookLibraryAPI.Data.CustomException;
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
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(User user)
        {
            try
            {
                return Ok(_userService.Login(user));
            }
            catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}