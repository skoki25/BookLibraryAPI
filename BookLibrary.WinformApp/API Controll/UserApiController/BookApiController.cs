using BookLibrary.Models;
using Newtonsoft.Json.Linq;
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

        public async Task<Book> CreateBook(Book book, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook);
                return await _apiService.PostAsync<Book>(loginEndPoint, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new Book();
            }
        }

        public async Task<Book> EditBook(Book book, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook, book.Id);
                return await _apiService.PutAsync<Book>(loginEndPoint, book, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new Book();
            }
        }
    }
}
