using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
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
        public async Task<BookInfoDto> GetBookInfoExtra(int id)
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfoExtra, id);
            ResultMessage<BookInfoDto> resultMessage = await _apiService.GetAsync<BookInfoDto>(loginEndPoint, currentUserData.GetToken());
            return  resultMessage.Data;
        }

        public async Task<List<BookInfoDto>> GetAllBookInfo()
        {
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfo);
            ResultMessage<List<BookInfoDto>> resultMessage = await _apiService.GetAsync<List<BookInfoDto>>(loginEndPoint, currentUserData.GetToken());
            return resultMessage.Data;
        }
    }
}
