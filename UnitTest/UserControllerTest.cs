using AutoMapper;
using BookLibraryAPI.Controllers;
using BookLibraryAPI.Mapper;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using UnitTest.TestRepositories;
using Xunit.Sdk;

namespace UnitTest
{
    [TestClass]
    public class UserControllerTest
    {
        private UserController userController;

        [TestInitialize]
        public void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProfileMapping());
            });
            IUserRepository repository = new UserTestRepository();
            IUserService service = new UserService(config.CreateMapper(), repository);

            userController = new UserController(service);
        }

        [TestMethod]
        public void TestCorrectLogin()
        {
            User user = new User { Email = "peter.radiator@gmail.com", Password = "Password1234" };
            if (!Login(user))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestWrongLogin()
        {
            string email = "peter.radiator@gmail.com";
            User user = new User { Email = "peter.radiator@gmail.com", Password = "WrongPassword" };
            if (Login(user))
            {
                Assert.Fail();
            }
        }
        private bool Login(User user)
        {
            var result = userController.Login(user);
            bool isOkObjectResult = result.Result is OkObjectResult;
            return isOkObjectResult;

        }
    }
}