﻿using BookLibrary.Model.DTO;
using BookLibrary.Models;

namespace BookLibraryAPI.Services
{
    public interface IBookInfoService
    {
        ServiceResult<BookInfo> CreateBookInfo(BookInfo bookInfo);
        ServiceResult<BookInfo> EditBookInfo(int id,BookInfo bookInfo);
        ServiceResult<string> DeleteBookInfo(int id);
        ServiceResult<BookInfo> GetBookInfo(int id);
        ServiceResult<BookInfoDto> GetBookInfoExtraData(int id);
        ServiceResult<List<BookInfoDto>> GetAllBookInfo();
    }
}