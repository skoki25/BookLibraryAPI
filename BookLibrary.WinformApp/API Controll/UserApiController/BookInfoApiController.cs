using BookLibrary.Model.DTO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using WinformApp.APIControll;

namespace WinformApp.API_Controll.UserApiController
{
    public  class BookInfoApiController
    {
        IApiService _apiService;
        public BookInfoApiController(IApiService apiService) 
        {
            _apiService = apiService;
        }

        public async Task<BookInfoDto?> GetBookInfoExtra(int id, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfoExtra, id);
                return await _apiService.GetAsync<BookInfoDto>(loginEndPoint, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }

        public async Task<List<BookInfoDto>> GetAllBookInfo(string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfo);
                return await _apiService.GetAsync<List< BookInfoDto>> (loginEndPoint, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
