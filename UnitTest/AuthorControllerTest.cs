using BookLibraryAPI.Controllers;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UnitTest.FakeRepositories;

namespace UnitTest
{
    [TestClass]
    public class AuthorControllerTest
    {
        private AuthorController _authorController;

        [TestInitialize]
        public void Inicialization()
        {
            IAuthorRepository repository = new AuthorTestRepository();
            IAuthorService service = new AuthorService(repository);
            _authorController = new AuthorController(service);
        }


        [TestMethod]
        public async Task TestGetAuthor()
        {
            IActionResult result = await _authorController.GetAuthorById(1);
            //Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            //OkObjectResult okObjectResult = (OkObjectResult)result;
            //Assert.IsInstanceOfType(okObjectResult.Value, typeof(Author));
            //Author author = (Author)okObjectResult.Value;
            //Assert.Fail();

            if(result is BadRequestObjectResult)
            {
                BadRequestObjectResult badRequestObjectResult = (BadRequestObjectResult)result;
                string error = JsonConvert.SerializeObject(badRequestObjectResult.Value);
                Assert.Fail(error);
            }
        }
    }


}
