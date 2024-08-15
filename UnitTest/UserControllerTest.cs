using AutoMapper;
using BookLibraryAPI.Controllers;
using BookLibraryAPI.Mapper;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Xunit.Sdk;

namespace UnitTest
{
    [TestClass]
    public class UserControllerTest
    {
        private UserController userController;

        public UserControllerTest()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProfileMapping());
            });
            userController = new UserController(new UserService(config.CreateMapper(), null));
        }

        [TestMethod]
        public void TestCorrectLogin()
        {
            User user = new User { Email = "peter.hokage@gmail.com", Password = "Password1234" };
            if (!Login(user))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestWrongLogin()
        {
            User user = new User { Email = "peter.hokage@gmail.com", Password = "WrongPassword" };
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