using BookLibraryAPI.Models;
using LibraryWindowsApp.APIControll;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.API_Controll.UserApiController
{
    public  class BookInfoApiController
    {
        IApiService _apiService;
        public BookInfoApiController(IApiService apiService) 
        {
            _apiService = apiService;
        }

        public async Task<BookInfo?> GetBookInfoExtra(int id, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfoExtra, id);
                return await _apiService.GetAsync<BookInfo>(loginEndPoint, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
