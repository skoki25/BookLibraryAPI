using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;

namespace BookLibraryAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public ServiceResult<Category> AddCategory(Category category)
        {
            CategoryCreateValidation validationRules = new CategoryCreateValidation();

            if(!validationRules.Validate(category,out string error))
            {
                return ServiceResult<Category>.Failure(error, ResultType.BadRequest);
            }

            Category catergoryResult = _categoryRepository.GetCategoryByType(category.Type);

            if ( catergoryResult != null )
            {
                return ServiceResult<Category>.Failure("This category already exist", ResultType.BadRequest);
            }
            _categoryRepository.CreateCategory(category);

            return ServiceResult<Category>.Success(category);
        }

        public ServiceResult<Category> GetCategoryById(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            return ServiceResult<Category>.Success(category);
        }

        public ServiceResult<Category> EditCategory(int id, Category category)
        {
            Category catergoryResult = _categoryRepository.GetCategoryById(id);

            if (catergoryResult == null)
            {
                return ServiceResult<Category>.Failure("Not found",ResultType.NotFound);
            }
            _categoryRepository.EditCategory(id, category);


            return ServiceResult<Category>.Success(catergoryResult);
        }

        public ServiceResult<List<Category>> GetAllCategory()
        {
            return ServiceResult<List<Category>>.Success(_categoryRepository.GetAllCategories());
        }
    }
}
