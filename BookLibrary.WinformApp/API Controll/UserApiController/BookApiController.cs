using BookLibrary.Models;
using WinformApp.APIControll;

namespace WinformApp.API_Controll.UserApiController
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
