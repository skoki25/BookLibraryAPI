using BookLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private LibraryDbContext _context;

        public CategoryRepository(LibraryDbContext context = null)
        {
            _context = context;
        }

        public Category GetCategoryByType(string type)
        {
            return _context.Category.Where(x => x.Type.Equals(type)).SingleOrDefault();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Category.Where(x => x.Id == id).SingleOrDefault();
        }

        public Category CreateCategory(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category EditCategory(int id, Category category)
        {
            Category catergoryResult = GetCategoryById(id);
            catergoryResult.Type = category.Type;
            _context.SaveChanges();
            return catergoryResult;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Category.ToList();
        }
    }
}
