using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Installation;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class BookInfoController: ControllerBase
    {
        private IBookInfoService _bookInfoService;

        public BookInfoController(IBookInfoService bookInfoService)
        {
            _bookInfoService = bookInfoService;
        }

        [HttpGet]
        public Task<IActionResult> GetBookInfo(int id)
        {
            return this.ServiceToActionTask(_bookInfoService.GetBookInfo(id));
        }

        [HttpGet]
        [Route("Info/{id}")]
        public Task<IActionResult> GetBookInfoExtra(int id)
        {
            return this.ServiceToActionTask(_bookInfoService.GetBookInfo(id));
        }

        [HttpPost]
        public Task<IActionResult> CreateBookInfo(BookInfo bookInfo)
        {
            return this.ServiceToActionTask(_bookInfoService.CreateBookInfo(bookInfo));
        }

        [HttpPut]
        public Task<IActionResult> UpdateBookInfo([FromForm] int id, BookInfo bookInfo)
        {
            return this.ServiceToActionTask(_bookInfoService.EditBookInfo(id, bookInfo));
        }

        [HttpDelete]
        public Task<IActionResult> DeleteBookInfo([FromForm] int id)
        {
            return this.ServiceToActionTask(_bookInfoService.DeleteBookInfo(id));
        }
    }
}
