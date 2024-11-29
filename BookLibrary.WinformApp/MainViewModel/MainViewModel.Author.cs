using BookLibrary.Model.Messages;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public async Task<Author> CreateAuthor(Author author)
        {

            string loginEndPoint = Config.Settings.GetRoute(Config.ApiAuthor);
            ResultMessage<Author> resultMessage = await _apiService.PostAsync<Author>(loginEndPoint,author, currentUserData.GetToken());
            return resultMessage.Data;
        }

        public async Task<Author> EditAuthor(Author author)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiAuthor, author.Id);
            ResultMessage<Author> resultMessage = await _apiService.PutAsync<Author>(loginEndPoint, author, currentUserData.GetToken());
            return resultMessage.Data;
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiAuthor);
            ResultMessage<List<Author>> resultMessage = await _apiService.GetAsync<List<Author>>(loginEndPoint, currentUserData.GetToken());
            return resultMessage.Data;
        }
    }
}
