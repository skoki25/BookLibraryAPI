using BookLibraryAPI.Data.Messages;
using BookLibraryAPI.DTO;
using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IUserService
    {
        ServiceResult<UserDto> CreateUser(User user);
        ServiceResult<UserDto> GetUserById(int id);
        ServiceResult<TokenMessage> Login(User user);
    }
}
