using BookLibrary.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class BookInfoController : ControllerBase
    {
        private IBookInfoService _bookInfoService;

        public BookInfoController(IBookInfoService bookInfoService)
        {
            _bookInfoService = bookInfoService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBookInfo(int id)
        {
            return _bookInfoService.GetBookInfo(id).Result();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookInfo()
        {
            return _bookInfoService.GetAllBookInfo().Result();
        }

        [HttpGet]
        [Route("Info/{id}")]
        public async Task<IActionResult> GetBookInfoExtra(int id)
        {
            return _bookInfoService.GetBookInfoExtraData(id).Result();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookInfo(BookInfo bookInfo)
        {
            return _bookInfoService.CreateBookInfo(bookInfo).Result();
        }

        [HttpPut]
        public async Task<IActionResult> EditBookInfo([FromForm] int id, BookInfo bookInfo)
        {
            return _bookInfoService.EditBookInfo(id, bookInfo).Result();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookInfo([FromForm] int id)
        {
            return _bookInfoService.DeleteBookInfo(id).Result();
        }
    }
}
