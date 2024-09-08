using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        User GetUserByEmail(string email);
        User GetUserByEmailWithRole(string email);
        User GetUserById(int id);
    }
}