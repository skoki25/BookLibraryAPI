using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public interface ICategoryService
    {
        Task<IActionResult> GetAllCategory();
        Task<IActionResult> EditCategory(int id, Category category);
        Task<IActionResult> CreateCategory(Category category);
        Task<IActionResult> GetCategoryById(int id);
        Task<IActionResult> GetCategoriesWithBooks();
    }
}
