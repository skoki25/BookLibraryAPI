using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibrary.WinformApp.API_Controll.UserApiController;
using Newtonsoft.Json.Linq;
using WinformApp.APIControll;

namespace WinformApp.API_Controll.UserApiController
{
    public class BookApiController: ApiControllerBase
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
                ResultMessage<List<Book>> resultMessage = await _apiService.GetAsync<List<Book>>(loginEndPoint, token);
                if (resultMessage.Data == null)
                {
                    ErrorMessage(resultMessage.Message);
                    return new List<Book>();
                }
                return resultMessage.Data;
            }
            catch(Exception ex)
            {
                ErrorMessage(ex.Message);
                return new List<Book>();
            }
        }

        public async Task<Book> CreateBook(Book book, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook);
                ResultMessage<Book> resultMessage = await _apiService.PostAsync<Book>(loginEndPoint, token);
                if(resultMessage.Data == null)
                {
                    ErrorMessage(resultMessage.Message);
                    return new Book();
                }
                return resultMessage.Data;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                return new Book();
            }
        }

        public async Task<Book> EditBook(Book book, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook, book.Id);
                ResultMessage<Book> resultMessage = await _apiService.PutAsync<Book>(loginEndPoint, book, token);
                if (resultMessage.Data == null)
                {
                    MessageBox.Show($"{resultMessage.Message}");
                    return new Book();
                }
                return resultMessage.Data;
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                return new Book();
            }
        }
    }
}
