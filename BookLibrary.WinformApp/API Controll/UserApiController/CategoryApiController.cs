using BookLibrary.Model.Messages;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp;
using WinformApp.APIControll;

namespace BookLibrary.WinformApp.API_Controll.UserApiController
{
    public class CategoryApiController : ApiControllerBase
    {
        public CategoryApiController(IApiService apiService) 
            : base(apiService)
        {
        }

        public async Task<Category> CreateCategory(Category book, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategory);
                ResultMessage<Category> resultMessage = await _apiService.PostAsync<Category>(loginEndPoint, book, token);
                if (resultMessage.Data == null)
                {
                    _apiService.ErrorMessage(new ArgumentNullException("No data"));
                    return new Category();
                }
                return resultMessage.Data;
            }
            catch (Exception ex)
            {
                _apiService.ErrorMessage(ex);
                return new Category();
            }
        }

        public async Task<Category> EditCategory(Category category, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategory, category.Id);
                ResultMessage<Category> resultMessage = await _apiService.PutAsync<Category>(loginEndPoint, category, token);
                if (resultMessage.Data == null)
                {
                    _apiService.ErrorMessage(new ArgumentNullException("No data"));
                    return new Category();
                }
                return resultMessage.Data;
            }
            catch (Exception ex)
            {
                _apiService.ErrorMessage(ex);
                return new Category();
            }
        }
        public async Task<List<Category>> GetAllCategories(string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiCategory);
                ResultMessage<List<Category>> resultMessage = await _apiService.GetAsync<List<Category>>(loginEndPoint, token);
                if (resultMessage.Data == null)
                {
                    _apiService.ErrorMessage(new ArgumentNullException("No data"));
                    return new List<Category>();
                }
                return resultMessage.Data;
            }
            catch (Exception ex)
            {
                _apiService.ErrorMessage(ex);
                return new List<Category>();
            }
        }
    }
}
