﻿
using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;

namespace BookLibraryAPI.Services
{
    public interface IUserService
    {
        ServiceResult<UserDto> CreateUser(User user);
        ServiceResult<UserDto> GetUserById(int id);
        ServiceResult<UserDto> GetUserByEmail(string id);
        ServiceResult<TokenMessage> Login(User user);
    }
}