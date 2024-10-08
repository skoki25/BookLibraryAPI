using BookLibrary.Models;
using BookLibraryAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.TestRepositories
{
    public class CategoryTestRepository :ICategoryRepository
    {
        public List<Category> listCategory;
        public CategoryTestRepository()
        {
            listCategory = new List<Category>();
            AddCategory();
        }

        public void AddCategory()
        {
            listCategory.Add(new Category { Id = 1, Type = "Scifi" });
            listCategory.Add(new Category { Id = 2, Type = "Fantasy" });
            listCategory.Add(new Category { Id = 3, Type = "Roman" });
            listCategory.Add(new Category { Id = 4, Type = "History" });
            listCategory.Add(new Category { Id = 5, Type = "Documentarne" });
        }

        public async Task<Category> CreateCategory(Category category)
        {
            listCategory.Add(category);
            return category;
        }

        public async Task<Category> EditCategory(int id, Category category)
        {
            Category categoryResult = listCategory.Where(x=> x.Id == id).SingleOrDefault();
            categoryResult.Type = category.Type;
            return categoryResult;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return listCategory;
        }

        public Task<Category> GetAllCategoriesWithBooks(string type)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return listCategory.Where(x => x.Id == id).SingleOrDefault();
        }

        public async Task<Category> GetCategoryByType(string type)
        {
            return listCategory.Where(x => x.Type.Equals(type)).SingleOrDefault();
        }
    }
}
