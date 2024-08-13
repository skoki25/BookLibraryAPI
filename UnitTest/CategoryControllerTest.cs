using BookLibraryAPI.Controllers;
using BookLibraryAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class CategoryControllerTest
    {
        CategoryController categoryController;

        [TestInitialize]
        public void Inicialization()
        {
            categoryController = new CategoryController(new CategoryService());

        }
        [TestMethod]
        public void TestGetAllCategories()
        {
            var result = categoryController.GetAllCategory();

            //result.R
        }
        
    }
}
