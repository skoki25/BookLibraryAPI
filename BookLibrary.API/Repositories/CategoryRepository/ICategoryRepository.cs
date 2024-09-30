using BookLibrary.Models;

namespace BookLibraryAPI.Repositories
{
    public interface ICategoryRepository
    {
        public Task<Category> CreateCategory(Category category);
        public Task<Category> EditCategory(int id, Category category);
        public Task<List<Category>> GetAllCategories();
        public Task<Category> GetCategoryById(int id);
        public Task<Category> GetCategoryByType(string type);

    }
}