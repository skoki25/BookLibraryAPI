using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public async Task<BookInfo> GetBookInfoExtra(int id)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfoExtra, id);
            ResultMessage<BookInfo> resultMessage = await _apiService.GetAsync<BookInfo>(loginEndPoint, currentUserData.GetToken());
            return  resultMessage.Data;
        }

        public async Task<List<BookInfo>> GetAllBookInfo()
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfo);
            ResultMessage<List<BookInfo>> resultMessage = await _apiService.GetAsync<List<BookInfo>>(loginEndPoint, currentUserData.GetToken());
            return resultMessage.Data;
        }
    }
}
