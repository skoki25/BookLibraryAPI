﻿using BookLibrary.Models;
using BookLibraryAPI.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IBookInfoRepository
    {
        BookInfo CreateBookInfo(BookInfo bookInfo);
        void DeleteBookInfo(BookInfo bookInfo);
        BookInfo EditBookInfo(int id, BookInfo bookInfo);
        BookInfo GetBookInfoById(int id);
        List<BookInfo> GetAllBookInfo();       
        BookInfo GetBookInfoByIdWithExtra(int id);
        BookInfo GetBookInfoWithBooks(int id);
    }
}