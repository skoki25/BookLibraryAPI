using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibraryAPI.Data;
using BookLibraryAPI.Data.Config;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Services
{
    public class UserService : IUserService
    {
        private TokenService _tokenService = new TokenService();
        private IUserRepository _userRepository;
        private IMapper _map;

        public UserService(IMapper map, IUserRepository userRepository) 
        {
            _map = map;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> CreateUser(User user)
        {
            CreateUserValidation userValidator = new CreateUserValidation();
            if (!userValidator.Validate(user, out string error))
            {
                return ServiceResult<UserDto>.Failure(error, ResultType.BadRequest);
            }
            User result = await _userRepository.GetUserByEmail(user.Email);

            if (result != null)
            {
                return ServiceResult<UserDto>.Failure("Email already exist!", ResultType.BadRequest);
            }
            User userCreate = await _userRepository.CreateUser(user);

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(userCreate));
        }

        public async Task<IActionResult> GetUserById(int id)
        {
            User user = await _userRepository.GetUserById(id);

            if(user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt foudd", ResultType.NotFound);
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            User user = await _userRepository.GetUserByEmail(email);

            if (user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt found", ResultType.NotFound);
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public async Task<IActionResult> Login(User user)
        {
            var userResult = await _userRepository.GetUserByEmailWithRole(user.Email);

            if (userResult == null)
            {
                return ServiceResult<TokenMessage>.Failure("User dosnt exit", ResultType.NotFound);
            }

            if (userResult.Password != user.Password)
            {
                return ServiceResult<TokenMessage>.Failure("Unauthorized", ResultType.NotAuthorized);
            }

            if (userResult.Role == null)
            {
                return ServiceResult<TokenMessage>.Failure("User dont have any role", ResultType.NotFound);
            }
            if (userResult.Role.Count() == 0)
            {
                return ServiceResult<TokenMessage>.Failure("User dont have any role", ResultType.NotFound);
            }

            string token = _tokenService.GenerateJwtToken(userResult.Email, userResult.Role.ToList());

            return ServiceResult<TokenMessage>.Success(new TokenMessage(Config.SuccessMessage,token));
        }

    }
}
