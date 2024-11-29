using AutoMapper;
using BookLibraryAPI.Controllers;
using BookLibraryAPI.Mapper;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;

namespace UnitTest
{
    [TestClass]
    public class BookInfoControllerTest
    {
        private BookInfoController _bookInfoController;

        public BookInfoControllerTest()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProfileMapping());
            });
            IBookInfoRepository bookInfoRepository = new BookInfoRepository(new LibraryDbContext());
            IBookInfoService authorService = new BookInfoService(bookInfoRepository, config.CreateMapper());
            _bookInfoController = new BookInfoController(authorService);
        }

        [TestMethod]
        public void GetBookInfoTest()
        {
            int id = 7;
            var result = _bookInfoController.GetBookInfo(id).Result;

        }

        [TestMethod]
        public void GetAllBookInfoTest()
        {
            var result = _bookInfoController.GetAllBookInfo().Result;

        }

        [TestMethod]
        public void EditBookInfoTest()
        {
            var result = _bookInfoController.GetAllBookInfo().Result;
        }
    }
}
