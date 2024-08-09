using BookLibraryAPI.Data;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Services
{
    public class UserService : IUserService
    {
        private LibraryDbContext _context = new LibraryDbContext();
        private TokenService _tokenService = new TokenService();

        public void CreateUser(User user)
        {
            CreateUserValidation userValidator = new CreateUserValidation();
            if (!userValidator.Validate(user, out string error))
            {
                throw new ValidationErrorExeption(error);
            }
            User result = _context.User.Where(x => x.Email == user.Email).FirstOrDefault();

            if (result != null)
            {
                throw new ValidationErrorExeption("Email already exist!");
            }

            _context.User.Add(user);
            _context.SaveChanges();
        }

        public User GetUserById(int id)
        {
            User user = _context.User.Where(x => x.Id == id).SingleOrDefault();

            return user;
        }

        public string Login(User user)
        {
            var userResult = _context.User.Where(x => x.Email == user.Email)
                .Include(x => x.Role)
                .SingleOrDefault();

            if (userResult == null)
            {
                throw new ValidationErrorExeption("User dosnt exit");
            }

            if (userResult.Password != user.Password)
            {
                throw new ValidationErrorExeption("Unauthorized");
            }

            if (userResult.Role == null)
            {
                throw new ValidationErrorExeption("User dont have any role");
            }
            if (userResult.Role.Count() == 0)
            {
                throw new ValidationErrorExeption("User dont have any role");
            }


            return _tokenService.GenerateJwtToken(userResult.Email, userResult.Role.ToList());
        }
    }
}
