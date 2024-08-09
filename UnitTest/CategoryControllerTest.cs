using BookLibraryAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    internal class CategoryControllerTest
    {
        CategoryController categoryController;

        [TestInitialize]
        public void Inicialization()
        {
            categoryController = new CategoryController();

        }
        [TestMethod]
        public void TestGetAllCategories()
        {
            var result = categoryController.GetAllCategory();

            //result.R
        }
        
    }
}
