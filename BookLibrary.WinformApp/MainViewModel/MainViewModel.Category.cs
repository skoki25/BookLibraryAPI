using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public async Task<List<Category>> GetAllCategories()
        {
            return await _categoryApiController.GetAllCategories(currentUserData.GetToken());
        }

        public async Task<Category> CreateCategory(Category category)
        {
            return await _categoryApiController.CreateCategory(category,currentUserData.GetToken());
        }

        public async Task<Category> EditCategory(Category category)
        {
            return await _categoryApiController.EditCategory(category, currentUserData.GetToken());
        }
    }
}
