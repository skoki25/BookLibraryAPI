using AutoMapper;
using BookLibraryAPI.Data;
using BookLibraryAPI.Data.Config;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Data.Messages;
using BookLibraryAPI.DTO;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;
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

        public ServiceResult<UserDto> CreateUser(User user)
        {
            CreateUserValidation userValidator = new CreateUserValidation();
            if (!userValidator.Validate(user, out string error))
            {
                return ServiceResult<UserDto>.Failure(error);
            }
            User result = _userRepository.GetUserByEmail(user.Email);

            if (result != null)
            {
                return ServiceResult<UserDto>.Failure("Email already exist!");
            }
            _userRepository.CreateUser(user);

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public ServiceResult<UserDto> GetUserById(int id)
        {
            User user = _userRepository.GetUserById(id);

            if(user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt foudd");
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }
        public ServiceResult<UserDto> GetUserByEmail(string email)
        {
            User user = _userRepository.GetUserByEmail(email);

            if (user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt foudd");
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public ServiceResult<TokenMessage> Login(User user)
        {
            var userResult = _userRepository.GetUserByEmailWithRole(user.Email);

            if (userResult == null)
            {
                return ServiceResult<TokenMessage>.Failure("User dosnt exit");
            }

            if (userResult.Password != user.Password)
            {
                return ServiceResult<TokenMessage>.Failure("Unauthorized");
            }

            if (userResult.Role == null)
            {
                return ServiceResult<TokenMessage>.Failure("User dont have any role");
            }
            if (userResult.Role.Count() == 0)
            {
                return ServiceResult<TokenMessage>.Failure("User dont have any role");
            }

            string token = _tokenService.GenerateJwtToken(userResult.Email, userResult.Role.ToList());

            return ServiceResult<TokenMessage>.Success(new TokenMessage(Config.SuccessMessage,token));
        }

    }
}
