using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibraryAPI.Controllers;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Data;
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

            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            OkObjectResult okRequest = (OkObjectResult)result;
            ResultMessage<Author> resultMessage = (ResultMessage<Author>)okRequest.Value;
            Author author = resultMessage.Data;
            if(author == null)
            {
                Assert.Fail("Author nebol najdeny");
            }
        }

        [TestMethod]
        public async Task GetAuthorsTest()
        {
            IActionResult result = await _authorController.GetAuthors();
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            OkObjectResult okRequest = (OkObjectResult)result;
            ResultMessage<List<Author>> resultMessage = (ResultMessage<List<Author>>)okRequest.Value;
            List<Author> listAuthor = resultMessage.Data;
            if(listAuthor.Count() == 0)
            {
                Assert.Fail("Canntot be null");
            }
        }

        [TestMethod]
        public async Task EditAuthorTest()
        {
            string firstNameChange = "Erik";
            string secondNameChange = "Mandalorian";

            Author authorEdit = new Author { Id = 1, Age = 30, FirstName = firstNameChange, LastName = secondNameChange };

            IActionResult result = await _authorController.EditAuthor(1, authorEdit);
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);
            CheckAuthor(firstNameChange, secondNameChange, result);
        }



        [TestMethod]
        public async Task CreateAuthor()
        {
            string firstNameChange = "Erik";
            string secondNameChange = "Mandalorian";

            Author authorCreate = new Author { Id = 1, Age = 30, FirstName = firstNameChange, LastName = secondNameChange };
            IActionResult result = await _authorController.CreateAuthor(authorCreate);
            TestMethod.IsBadRequest(result);
            CheckAuthor(firstNameChange, secondNameChange, result);
        }

        private static void CheckAuthor(string firstNameChange, string secondNameChange, IActionResult result)
        {
            OkObjectResult okRequest = (OkObjectResult)result;
            ResultMessage<Author> resultMessage = (ResultMessage<Author>)okRequest.Value;
            Author author = resultMessage.Data;
            TestDataGetItem.IsObjectNull(author);
            if (!author.FirstName.Equals(firstNameChange))
            {
                Assert.Fail($"First name wasnt change {author.FirstName}");
            }
            if (!author.LastName.Equals(secondNameChange))
            {
                Assert.Fail("First name wasnt change");
            }
        }
    }


}
