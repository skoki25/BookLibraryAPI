using BookLibrary.Models;
using BookLibraryAPI.Models;

namespace BookLibraryAPI.Repositories
{
    public interface IBookInfoRepository
    {
        Task<BookInfo> CreateBookInfo(BookInfo bookInfo);
        void DeleteBookInfo(BookInfo bookInfo);
        Task<BookInfo> EditBookInfo(int id, BookInfo bookInfo);
        Task<BookInfo> GetBookInfoById(int id);
        Task<List<BookInfo>> GetAllBookInfo();       
        Task<BookInfo> GetBookInfoByIdWithExtra(int id);
        Task<BookInfo> GetBookInfoWithBooks(int id);
    }
}