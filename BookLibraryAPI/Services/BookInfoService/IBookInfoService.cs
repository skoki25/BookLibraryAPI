using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface IBookInfoService
    {
        ServiceResult<BookInfo> CreateBookInfo(BookInfo bookInfo);
        ServiceResult<BookInfo> EditBookInfo(int id,BookInfo bookInfo);
        ServiceResult<string> DeleteBookInfo(int id);
        ServiceResult<BookInfo> GetBookInfo(int id);
        ServiceResult<BookInfo> GetBookInfoExtraData(int id);
    }
}
