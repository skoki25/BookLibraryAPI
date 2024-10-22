using BookLibraryAPI.Controllers;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;

namespace UnitTest
{
    [TestClass]
    public class BookInfoControllerTest
    {
        private AuthorController _authorController;

        public BookInfoControllerTest() 
        {
            IAuthorRepository authorRepository = new AuthorRepository(new LibraryDbContext());
            IAuthorService authorService = new AuthorService(authorRepository);
            _authorController = new AuthorController(authorService);
        }

        [TestMethod]
        public void GetAuthorByIdTest()
        {
            int id = 7;
            var result = _authorController.GetAuthorById(id).Result;

        }

        [TestMethod]
        public void GetAuthorsTest()
        {

        }
    }
}
