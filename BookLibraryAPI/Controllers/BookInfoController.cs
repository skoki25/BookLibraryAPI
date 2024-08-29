﻿using BookLibraryAPI.Data.CustomException;
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
            return _bookInfoService.GetBookInfo(id).Result();
        }

        [HttpGet]
        [Route("Info/{id}")]
        public Task<IActionResult> GetBookInfoExtra(int id)
        {
            return _bookInfoService.GetBookInfo(id).Result();
        }

        [HttpPost]
        public Task<IActionResult> CreateBookInfo(BookInfo bookInfo)
        {
            return _bookInfoService.CreateBookInfo(bookInfo).Result();
        }

        [HttpPut]
        public Task<IActionResult> UpdateBookInfo([FromForm] int id, BookInfo bookInfo)
        {
            return _bookInfoService.EditBookInfo(id, bookInfo).Result();
        }

        [HttpDelete]
        public Task<IActionResult> DeleteBookInfo([FromForm] int id)
        {
            return _bookInfoService.DeleteBookInfo(id).Result();
        }
    }
}
