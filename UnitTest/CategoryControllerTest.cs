using BookLibraryAPI.Controllers;
using BookLibraryAPI.Models;
using BookLibraryAPI.Repositories;
using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using UnitTest.Data;
using UnitTest.TestRepositories;

namespace UnitTest
{
    [TestClass]
    public class CategoryControllerTest
    {
        CategoryController categoryController;

        [TestInitialize]
        public void Inicialization()
        {
            ICategoryRepository categoryRepository = new CategoryRepositoryTest();
            ICategoryService categoryService = new CategoryService(categoryRepository);
            categoryController = new CategoryController(categoryService);

        }
        [TestMethod]
        public void GetCategoryByIdTest()
        {
            int id = 2;
            IActionResult result = categoryController.GetCategoryById(id);
            Category category = TestDataGetItem.ConvertItem<Category>(result);
            TestDataGetItem.IsObjectNull(category);
        }

        [TestMethod]
        public void TestGetAllCategories()
        {
            var result = categoryController.GetAllCategory();
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            OkObjectResult resultOk = (OkObjectResult)result;

            List<Category> categoryList= (List<Category>)resultOk.Value;

            if (categoryList.Count == 0) 
            {
                Assert.Fail("Failed");
            }
        }
        [TestMethod]
        public void EditCategoryTest()
        {
            int id = 2;
            string type = "Scifi-mici";
            Category category = new Category { Id = id, Type = type };
            var result = categoryController.EditCategory(id, category);
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);
            IActionResult result22 = categoryController.GetCategoryById(id);
            Category category2 = TestDataGetItem.ConvertItem<Category>(result);
            TestDataGetItem.IsObjectNull(category2);
            if(category2.Type != type)
            {
                Assert.Fail("TYpe dont match");
            }
        }
        public void AddCategory()
        {
            int id = 500;
            string type = "Scifi-mici";
            Category category = new Category { Id = id, Type = type };
            var result = categoryController.AddCategory(category);
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);
            IActionResult result22 = categoryController.GetCategoryById(id);
            Category category2 = TestDataGetItem.ConvertItem<Category>(result);
            TestDataGetItem.IsObjectNull(category2);
            if (category2.Type != type)
            {
                Assert.Fail("TYpe dont match");
            }
        }

    }
}
