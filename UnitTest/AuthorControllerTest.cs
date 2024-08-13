using BookLibraryAPI.Controllers;
using BookLibraryAPI.Data.Messages;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
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

            CheckIfIsBadRequest(result);

            if (result is OkObjectResult)
            {
                OkObjectResult okRequest = (OkObjectResult)result;
            }
            else
            {
                Assert.Fail("Zly request");

            }
        }

        [TestMethod]
        public async Task GetAuthorsTest()
        {
            IActionResult result = await _authorController.GetAuthors();
            CheckIfIsBadRequest(result);

            if (result is OkObjectResult)
            {
                OkObjectResult okRequest = (OkObjectResult)result;
                List<Author> listAuthor = (List<Author>)okRequest.Value;
                if(listAuthor.Count() == 0)
                {
                    Assert.Fail("Canntot be null");

                }
            }
            else
            {
                Assert.Fail("Zly request");

            }
        }

        [TestMethod]
        public async Task EditAuthorTest()
        {
            string firstNameChange = "Erik";
            string secondNameChange = "Mandalorian";

            Author authorEdit = new Author { Id = 1, Age = 30, FirstName = firstNameChange, LastName = secondNameChange };

            IActionResult result = await _authorController.EditAuthor(1, authorEdit);
            CheckIfIsBadRequest(result);

            if (result is OkObjectResult)
            {
                CheckAuthor(firstNameChange, secondNameChange, result);
            }
            else
            {
                Assert.Fail("Zly request");

            }
        }



        [TestMethod]
        public async Task CreateAuthor()
        {
            string firstNameChange = "Erik";
            string secondNameChange = "Mandalorian";

            Author authorCreate = new Author { Id = 1, Age = 30, FirstName = firstNameChange, LastName = secondNameChange };
            IActionResult result = await _authorController.CreateAuthor(authorCreate);
            if (result is OkObjectResult)
            {
                CheckAuthor(firstNameChange, secondNameChange, result);
            }
            else
            {
                Assert.Fail("Zly request");

            }

        }
        private static void CheckAuthor(string firstNameChange, string secondNameChange, IActionResult result)
        {
            OkObjectResult okRequest = (OkObjectResult)result;
            Author author = (Author)okRequest.Value;
            if (author == null)
            {
                Assert.Fail("Nenajdeny author");
            }
            if (!author.FirstName.Equals(firstNameChange))
            {
                Assert.Fail($"First name wasnt change {author.FirstName}");
            }
            if (!author.LastName.Equals(secondNameChange))
            {
                Assert.Fail("First name wasnt change");
            }
        }

        private void CheckIfIsBadRequest(IActionResult result)
        {
            if (result is BadRequestObjectResult)
            {
                BadRequestObjectResult badRequestObjectResult = (BadRequestObjectResult)result;
                string error = JsonConvert.SerializeObject(badRequestObjectResult.Value);
                Assert.Fail(error);
            }
        }
    }


}
