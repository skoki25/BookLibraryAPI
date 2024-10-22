using BookLibrary.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [ApiController]
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
            return await _bookInfoService.GetBookInfo(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookInfo()
        {
            return await _bookInfoService.GetAllBookInfo();
        }

        [HttpGet]
        [Route("Info/{id}")]
        public async Task<IActionResult> GetBookInfoExtra(int id)
        {
            return await _bookInfoService.GetBookInfoExtraData(id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookInfo(BookInfo bookInfo)
        {
            return await _bookInfoService.CreateBookInfo(bookInfo);
        }

        [HttpPut]
        public async Task<IActionResult> EditBookInfo([FromForm] int id, BookInfo bookInfo)
        {
            return await _bookInfoService.EditBookInfo(id, bookInfo);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookInfo([FromForm] int id)
        {
            return await _bookInfoService.DeleteBookInfo(id);
        }
    }
}
