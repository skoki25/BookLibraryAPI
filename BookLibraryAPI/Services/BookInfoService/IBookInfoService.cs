using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IBookInfoService
    {
        void CreateBookInfo(BookInfo bookInfo);
        void EditBookInfo(int id,BookInfo bookInfo);
        void DeleteBookInfo(int id);
        BookInfo GetBookInfo(int id);
    }
}
