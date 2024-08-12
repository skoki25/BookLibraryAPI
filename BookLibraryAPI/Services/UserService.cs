using AutoMapper;
using BookLibraryAPI.Data;
using BookLibraryAPI.Data.Config;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Data.Messages;
using BookLibraryAPI.DTO;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Services
{
    public class UserService : IUserService
    {
        private LibraryDbContext _context = new LibraryDbContext();
        private TokenService _tokenService = new TokenService();
        private IMapper _map;

        public UserService(IMapper map) 
        {
            _map = map;
        }

        public ServiceResult<UserDto> CreateUser(User user)
        {
            CreateUserValidation userValidator = new CreateUserValidation();
            if (!userValidator.Validate(user, out string error))
            {
                return ServiceResult<UserDto>.Failure(error);
            }
            User result = _context.User.Where(x => x.Email == user.Email).FirstOrDefault();

            if (result != null)
            {
                return ServiceResult<UserDto>.Failure("Email already exist!");
            }

            _context.User.Add(user);
            _context.SaveChanges();

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public ServiceResult<UserDto> GetUserById(int id)
        {
            User user = _context.User.Where(x => x.Id == id).SingleOrDefault();

            if(user == null)
            {
                return ServiceResult<UserDto>.Failure("Wasnt foudd");
            }

            return ServiceResult<UserDto>.Success(_map.Map<UserDto>(user));
        }

        public ServiceResult<TokenMessage> Login(User user)
        {
            var userResult = _context.User.Where(x => x.Email == user.Email)
                .Include(x => x.Role)
                .SingleOrDefault();

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
