using BookLibraryAPI.Controllers;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.FakeRepositories;

namespace UnitTest
{
    [TestClass]
    internal class AuthorControllerTest
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
        public void TestGetAuthor()
        {
            _authorController.GetAuthorById(1);
        }
    }


}
