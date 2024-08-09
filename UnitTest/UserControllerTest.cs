using BookLibraryAPI.Controllers;
using BookLibraryAPI.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit.Sdk;

namespace UnitTest
{
    [TestClass]
    public class UserControllerTest
    {
        private UserController userController;

        public UserControllerTest()
        {
            userController = new UserController(new Logger<UserController>(new LoggerFactory()));
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