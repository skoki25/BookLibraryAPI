using BookLibrary.Models;
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
        public async Task<User> GetUserById(int id)
        {
            return await _context.User.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.User.Where(x => x.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> GetUserByEmailWithRole(string email)
        {
            return await _context.User.Where(x => x.Email == email)
                .Include(x => x.Role)
                .SingleOrDefaultAsync();

        }

        public async Task<User> CreateUser(User user)
        {
            _context.User.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

    }
}
