using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByEmailWithRole(string email);
        Task<User> GetUserById(int id);
    }
}