using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private LibraryDbContext _context;

        public UserRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public User GetUserById(int id)
        {
            return _context.User.Where(x => x.Id == id).SingleOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return _context.User.Where(x => x.Email == email).FirstOrDefault();
        }

        public User GetUserByEmailWithRole(string email)
        {
            return _context.User.Where(x => x.Email == email)
                .Include(x => x.Role)
                .SingleOrDefault();

        }

        public User CreateUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }

    }
}
