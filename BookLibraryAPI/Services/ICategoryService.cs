using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface ICategoryService
    {
        ServiceResult<List<Category>> GetAllCategory();
        ServiceResult<Category> EditCategory(int id, Category category);
        ServiceResult<Category> AddCategory(Category category);
    }
}
