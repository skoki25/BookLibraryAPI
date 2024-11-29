using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Models;
using BookLibraryAPI.Data.CustomException;
using BookLibraryAPI.Models;
using BookLibraryAPI.Models.Validation;
using BookLibraryAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _map;

        public CategoryService(ICategoryRepository categoryRepository, IMapper map)
        {
            _categoryRepository = categoryRepository;
            _map = map;
        }
        public async Task<IActionResult> CreateCategory(Category category)
        {
            CategoryCreateValidation validationRules = new CategoryCreateValidation();

            if(!validationRules.Validate(category,out string error))
            {
                return ServiceResult<Category>.Failure(error, ResultType.BadRequest);
            }

            Category catergoryResult = await _categoryRepository.GetCategoryByType(category.Type);

            if ( catergoryResult != null )
            {
                return ServiceResult<Category>.Failure("This category already exist", ResultType.BadRequest);
            }
            Category categoryCreate = await _categoryRepository.CreateCategory(category);

            return ServiceResult<Category>.Success(categoryCreate);
        }

        public async Task<IActionResult> GetCategoryById(int id)
        {
            Category category = await _categoryRepository.GetCategoryById(id);
            return ServiceResult<Category>.Success(category);
        }

        public async Task<IActionResult> EditCategory(int id, Category category)
        {
            Category catergoryResult = await _categoryRepository.GetCategoryById(id);

            if (catergoryResult == null)
            {
                return ServiceResult<Category>.Failure("Not found",ResultType.NotFound);
            }
            Category categoryEdit = await _categoryRepository.EditCategory(id, category);


            return ServiceResult<Category>.Success(categoryEdit);
        }

        public async Task<IActionResult> GetAllCategory()
        {
            List<Category> categories = await _categoryRepository.GetAllCategories();
            List<CategoryDto> categoriesDto = _map.Map<List<CategoryDto>>(categories);
            return ServiceResult<List<CategoryDto>>.Success(categoriesDto);
        }

        public async Task<IActionResult> GetCategoriesWithBooks()
        {
            List<Category> listCateg0ry = await _categoryRepository.GetAllCategoriesWithBooks();
            List<CategoriesWithBooks> categoriesWithBooks = _map.Map<List<CategoriesWithBooks>>(listCateg0ry);
            return ServiceResult<List<CategoriesWithBooks>>.Success(categoriesWithBooks);
        }
    }
}
