using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;

namespace BookLibraryAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private LibraryDbContext _context = new LibraryDbContext();

        public ServiceResult<Category> AddCategory(Category category)
        {
            CategoryCreateValidation validationRules = new CategoryCreateValidation();

            if(!validationRules.Validate(category,out string error))
            {
                return ServiceResult<Category>.Failure(error);
            }

            Category catergoryResult = _context.Category.Where(x=> x.Type.Equals(category.Type)).FirstOrDefault();

            if( catergoryResult != null )
            {
                return ServiceResult<Category>.Failure("This category already exist");
            }

            _context.Category.Add(category);
            _context.SaveChanges();
            return ServiceResult<Category>.Success(category);
        }

        public ServiceResult<Category> EditCategory(int id, Category category)
        {
            Category catergoryResult = _context.Category.Where(x => x.Id == id).FirstOrDefault();

            if (catergoryResult == null)
            {
                return ServiceResult<Category>.Failure("Not found");
            }

            catergoryResult.Type = category.Type;
            _context.SaveChanges();

            return ServiceResult<Category>.Success(catergoryResult);
        }

        public ServiceResult<List<Category>> GetAllCategory()
        {
            return ServiceResult<List<Category>>.Success(_context.Category.ToList());
        }
    }
}
