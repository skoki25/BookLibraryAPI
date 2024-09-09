using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibraryAPI.Data;
using BookLibraryAPI.Data.Config;
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
                return ServiceResult<UserDto>.Failure(error, ResultType.BadRequest);
            }
            User result = _userRepository.GetUserByEmail(user.Email);

            if (result != null)
            {
                return ServiceResult<UserDto>.Failure("Email already exist!", ResultType.BadRequest);
            }
            _userRepository.CreateUser(user);

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public ServiceResult<UserDto> GetUserById(int id)
        {
            User user = _userRepository.GetUserById(id);

            if(user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt foudd", ResultType.NotFound);
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }
        public ServiceResult<UserDto> GetUserByEmail(string email)
        {
            User user = _userRepository.GetUserByEmail(email);

            if (user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt found", ResultType.NotFound);
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public ServiceResult<TokenMessage> Login(User user)
        {
            var userResult = _userRepository.GetUserByEmailWithRole(user.Email);

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
