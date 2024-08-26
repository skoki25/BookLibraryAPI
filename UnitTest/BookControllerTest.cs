using AutoMapper;
using BookLibraryAPI.Controllers;
using BookLibraryAPI.Mapper;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Data;
using UnitTest.TestRepositories;

namespace UnitTest
{
    [TestClass]
    public class BookControllerTest
    {
        private BookController bookController;

        [TestInitialize]
        public void TestInicialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProfileMapping());
            });
            IBookRepository bookRepository = new BookTestRepository();
            BookService bookService = new BookService(bookRepository, config.CreateMapper());
            bookController = new BookController(bookService);
        }

        [TestMethod]
        public void GetAllBookTest()
        {
            IActionResult result = bookController.GetAllBooks();
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            OkObjectResult okRequest = (OkObjectResult)result;
            List<Book> bookList = (List<Book>)okRequest.Value;
            if (bookList.Count() == 0)
            {
                Assert.Fail("Count cannot be 0");

            }
        }

        [TestMethod]
        public void CreateBook()
        {
            string isoChange = "ISO66666";
            string eanChange = "AAAA-BBBB-CCCC";
            Book bookCreate = new Book { ISO = isoChange, EanCode = eanChange, PublicationDate = DateTime.Now };
            IActionResult result = bookController.CreateBook(bookCreate);
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            CheckBook(isoChange, eanChange, result);
        }

        [TestMethod]
        public void EditBookTest()
        {
            string isoChange = "ISO66666";
            string eanChange = "AAAA-BBBB-CCCC";
            Book bookUpdate = new Book { ISO = isoChange, EanCode = eanChange, PublicationDate = DateTime.Now };
            IActionResult result = bookController.EditBook(2,bookUpdate);
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            CheckBook(isoChange, eanChange, result);
        }

        private static void CheckBook(string isoChange, string eanChange, IActionResult result)
        {
            OkObjectResult okRequest = (OkObjectResult)result;
            Book book = (Book)okRequest.Value;
            TestDataGetItem.IsObjectNull(book);

            if (!book.ISO.Equals(isoChange))
            {
                Assert.Fail($"Iso wasnt change {book.ISO}");
            }
            if (!book.EanCode.Equals(eanChange))
            {
                Assert.Fail("Ean  wasnt change");
            }
        }
    }
}
