using BookLibraryAPI.Models;
using LibraryWindowsApp.APIControll;
using LibraryWindowsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.API_Controll.UserApiController
{
    public class BookApiController
    {
        private IApiService _apiService;
        public BookApiController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<List<Book>> GetAllBook(string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook);
                return await _apiService.GetAsync<List<Book>>(loginEndPoint, token);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new List<Book>();
            }
        }
    }
}
