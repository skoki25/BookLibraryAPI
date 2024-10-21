using AutoMapper;
using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibraryAPI.Controllers;
using BookLibraryAPI.Mapper;
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
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProfileMapping());
            });

            ICategoryRepository categoryRepository = new CategoryTestRepository();
            ICategoryService categoryService = new CategoryService(categoryRepository, config.CreateMapper());
            categoryController = new CategoryController(categoryService);

        }
        [TestMethod]
        public void GetCategoryByIdTest()
        {
            int id = 2;
            IActionResult result = categoryController.GetCategoryById(id).Result;
            ResultMessage<Category> category = TestDataGetItem.ConvertItem<ResultMessage<Category>>(result);
            TestDataGetItem.IsObjectNull(category);

            if (category.Data == null)
            {
                Assert.Fail("ResiltMessage.Data cant be null");
            }
        }

        [TestMethod]
        public void TestGetAllCategories()
        {
            var result = categoryController.GetAllCategory().Result;
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);

            OkObjectResult resultOk = (OkObjectResult)result;

            ResultMessage<List<CategoryDto>> categoryList = (ResultMessage<List<CategoryDto>>)resultOk.Value;

            if(categoryList == null)
            {
                Assert.Fail("ResiltMessage.Data cant be null");
            }

            if (categoryList.Data.Count() == 0) 
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
            var result = categoryController.EditCategory(id, category).Result;
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);
            IActionResult result22 = categoryController.GetCategoryById(id).Result;
            ResultMessage < Category >category2 = TestDataGetItem.ConvertItem<ResultMessage<Category>>(result);
            TestDataGetItem.IsObjectNull(category2);

            if(category2.Data == null)
            {
                Assert.Fail("TYpe dont match");
            }

            if (category2.Data.Type != type)
            {
                Assert.Fail("TYpe dont match");
            }
        }
        public void AddCategory()
        {
            int id = 500;
            string type = "Scifi-mici";
            Category category = new Category { Id = id, Type = type };
            var result = categoryController.AddCategory(category).Result;
            TestMethod.CheckIfIsBadRequest(result);
            TestMethod.IsBadRequest(result);
            IActionResult result22 = categoryController.GetCategoryById(id).Result;
            Category category2 = TestDataGetItem.ConvertItem<Category>(result);
            TestDataGetItem.IsObjectNull(category2);
            if (category2.Type != type)
            {
                Assert.Fail("TYpe dont match");
            }
        }
    }
}
