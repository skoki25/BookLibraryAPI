using BookLibrary.Model.Messages;
using BookLibrary.Models;
using Newtonsoft.Json.Linq;
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
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategory);
            ResultMessage<List<Category>> resultMessage = await _apiService.GetAsync<List<Category>>(loginEndPoint, currentUserData.GetToken());

            return resultMessage.Data;
        }

        public async Task<List<Category>> GetAllCategoriesWithBooks()
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategoryBooks);
            ResultMessage<List<Category>> resultMessage = await _apiService.GetAsync<List<Category>>(loginEndPoint, currentUserData.GetToken());
            return resultMessage.Data;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategory);
            ResultMessage<Category> resultMessage = await _apiService.PostAsync<Category>(loginEndPoint, category, currentUserData.GetToken());
            return resultMessage.Data;
        }

        public async Task<Category> EditCategory(Category category)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategory, category.Id);
            ResultMessage<Category> resultMessage = await _apiService.PutAsync<Category>(loginEndPoint, category, currentUserData.GetToken());
            return resultMessage.Data;
        }

        
    }
}
