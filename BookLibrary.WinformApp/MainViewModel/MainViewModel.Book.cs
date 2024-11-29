using BookLibrary.Model.Messages;
using BookLibrary.Models;
using Newtonsoft.Json.Linq;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public async Task<List<Book>> GetAllBooks()
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook);
            ResultMessage<List<Book>> resultMessage = await _apiService.GetAsync<List<Book>>(loginEndPoint, currentUserData.GetToken());
            return resultMessage.Data;
        }

        public async Task<Book> CreateBook(Book book)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook);
            ResultMessage<Book> resultMessage = await _apiService.PostAsync<Book>(loginEndPoint, currentUserData.GetToken());
            return resultMessage.Data;
        }
        public async Task EditBook(Book book)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBook, book.Id);
            ResultMessage<Book> resultMessage = await _apiService.PutAsync<Book>(loginEndPoint, book, currentUserData.GetToken());
        }
    }
}
