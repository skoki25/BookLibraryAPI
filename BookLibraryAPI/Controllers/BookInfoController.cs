using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Controllers
{
    [Authorize]
    public class BookInfoController: ControllerBase
    {
        private IBookInfoService _bookInfoService;
        public BookInfoController(IBookInfoService bookInfoService)
        {
            _bookInfoService = bookInfoService;
        }

        [HttpGet]
        public IActionResult GetBookInfo(int id)
        {
            BookInfo bookInfo = _bookInfoService.GetBookInfo(id);
            if(bookInfo == null)
            {
                return NoContent();
            }
            return Ok(bookInfo);
        }

        [HttpPost]
        public IActionResult CreateBookInfo(BookInfo bookInfo)
        {
            try
            {
                _bookInfoService.CreateBookInfo(bookInfo);
                return Ok(bookInfo);
            }
            catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult UpdateBookInfo([FromForm] int id, BookInfo bookInfo)
        {
            try
            {
                _bookInfoService.EditBookInfo(id,bookInfo);
                return Ok();
            }
            catch (ValidationErrorExeption ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteBookInfo([FromForm] int id)
        {
            try
            {
                _bookInfoService.DeleteBookInfo(id);
                return Ok();
            }
            catch(ValidationErrorExeption ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
