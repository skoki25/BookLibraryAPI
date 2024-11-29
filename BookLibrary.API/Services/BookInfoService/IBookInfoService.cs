using BookLibrary.Model.DTO;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public interface IBookInfoService
    {
        Task<IActionResult> CreateBookInfo(BookInfo bookInfo);
        Task<IActionResult> EditBookInfo(int id,BookInfo bookInfo);
        Task<IActionResult> DeleteBookInfo(int id);
        Task<IActionResult> GetBookInfo(int id);
        Task<IActionResult> GetBookInfoExtraData(int id);
        Task<IActionResult> GetAllBookInfo();
    }
}
