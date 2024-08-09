using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;

namespace BookLibraryAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private LibraryDbContext _context = new LibraryDbContext();

        public Category AddCategory(Category category)
        {
            CategoryCreateValidation validationRules = new CategoryCreateValidation();

            if(!validationRules.Validate(category,out string error))
            {
                throw new ValidationErrorExeption(error);
            }

            Category catergoryResult = _context.Category.Where(x=> x.Type.Equals(category.Type)).FirstOrDefault();

            if( catergoryResult != null )
            {
                throw new ValidationErrorExeption("This category already exist");
            }

            _context.Category.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category? EditCategory(int id, Category category)
        {
            Category catergoryResult = _context.Category.Where(x => x.Id == id).FirstOrDefault();

            if (catergoryResult == null)
            {
                return null;
            }

            catergoryResult.Type = category.Type;
            _context.SaveChanges();

            return catergoryResult;
        }

        public List<Category> GetAllCategory()
        {
            return _context.Category.ToList();
        }
    }
}
