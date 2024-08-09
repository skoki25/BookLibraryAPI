using BookLibraryAPI.Models;

namespace BookLibraryAPI.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategory();
        Category EditCategory(int id, Category category);
        Category AddCategory(Category category);
    }
}
