using BookLibrary.Models;
using BookLibraryAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestRepositories
{
    public class UserTestRepository : IUserRepository
    {
        public List<User> userTestList;
        public List<Role> roleTestList;

        public UserTestRepository()
        {
            userTestList = new List<User>();
            roleTestList = new List<Role>();
            AddMockedData();
        }

        public void AddMockedData()
        {
            User user1 = new User { Id = 1, Password = "Password1234", Address = "Alkalska 5", Email = "peter.radiator@gmail.com", Name = "Peter" };
            User user2 = new User { Id = 2, Password = "password", Address = "Alkalska 5", Email = "denis.radiator@gmail.com", Name = "Peter" };
            User user3 = new User { Id = 3, Password = "password", Address = "Alkalska 5", Email = "erik.radiator@gmail.com", Name = "Peter" };
            User user4 = new User { Id = 4, Password = "password", Address = "Alkalska 5", Email = "stano.radiator@gmail.com", Name = "Peter" };

            userTestList.Add(user1);
            userTestList.Add(user2);
            userTestList.Add(user3);
            userTestList.Add(user4);

            roleTestList.Add(new Role { Id = 1, Type = "User" });
            roleTestList.Add(new Role { Id = 2, Type = "Admin" });
            user4.Role = new List<Role>{ roleTestList[0] };
            user1.Role = new List<Role> { roleTestList[1] };
        }

        public async Task<User> CreateUser(User user)
        {
            userTestList.Add(user);
            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return userTestList.Where(x => x.Email == email).SingleOrDefault();
        }

        public async Task<User> GetUserByEmailWithRole(string email)
        {
            return userTestList.Where(x => x.Email == email).SingleOrDefault();
        }

        public async Task<User> GetUserById(int id)
        {
            return userTestList.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}
