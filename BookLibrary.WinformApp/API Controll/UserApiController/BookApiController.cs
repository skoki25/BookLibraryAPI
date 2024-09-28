using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibrary.WinformApp.API_Controll.UserApiController;
using Newtonsoft.Json.Linq;
using WinformApp.APIControll;

namespace WinformApp.API_Controll.UserApiController
{
    public class BookApiController: ApiControllerBase
    {
        public BookApiController(IApiService apiService)
            :base(apiService)
        {
        }

        public async Task<List<Book>> GetAllBook(string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook);
                ResultMessage<List<Book>> resultMessage = await _apiService.GetAsync<List<Book>>(loginEndPoint, token);
                if (resultMessage.Data == null)
                {
                    _apiService.ErrorMessage(new ArgumentNullException("No data"));
                    return new List<Book>();
                }
                return resultMessage.Data;
            }
            catch(Exception ex)
            {
                _apiService.ErrorMessage(ex);
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
                    _apiService.ErrorMessage(new ArgumentNullException("No data"));
                    return new Book();
                }
                return resultMessage.Data;
            }
            catch (Exception ex)
            {
                _apiService.ErrorMessage(ex);
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
                _apiService.ErrorMessage(ex);
                return new Book();
            }
        }
    }
}
