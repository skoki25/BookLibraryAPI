using BookLibraryAPI.Models;

namespace BookLibraryAPI.Repositories
{
    public interface ICategoryRepository
    {
        public Category CreateCategory(Category category);
        public Category EditCategory(int id, Category category);
        public List<Category> GetAllCategories();
        public Category GetCategoryById(int id);
        public Category GetCategoryByType(string type);

    }
}