using BookLibrary.Models;
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

        public async Task<Category> GetCategoryByType(string type)
        {
            return await _context.Category.Where(x => x.Type.Equals(type)).SingleOrDefaultAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Category.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<Category> CreateCategory(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> EditCategory(int id, Category category)
        {
            Category catergoryResult = await GetCategoryById(id);
            catergoryResult.Type = category.Type;
            _context.SaveChanges();
            return catergoryResult;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Category.ToListAsync();
        }
    }
}
