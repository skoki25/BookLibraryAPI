using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IUserService
    {
        void CreateUser(User user);
        User GetUserById(int id);
        string Login(User user);
    }
}
