using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.Models;
using BookLibrary.WinformApp.API_Controll.UserApiController;
using Microsoft.VisualBasic.Logging;
using WinformApp.API_Controll.UserApiController;
using WinformApp.APIControll;
using WinformApp.Model;

namespace WinformApp
{
    public partial class MainViewModel
    {

        public UserData currentUserData;
        public IApiService _apiService;

        public MainViewModel(IApiService apiService)
        {
            _apiService = apiService;

        }

        public async Task<bool> Login(string loginName, string password)
        {

            UserLogin login = new UserLogin { Email = loginName, Password = password };

            currentUserData = new UserData();
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiUserLogin);
            ResultMessage<TokenMessage> resultMessage = await _apiService.PostAsync<TokenMessage>(loginEndPoint, login);
            TokenMessage tokenMessage = resultMessage.Data;
            string myselfEndPoint = Config.Settings.GetRoute(Config.ApiUserMyself);
            currentUserData.TokenMessage = tokenMessage;
            ResultMessage<UserDto> resultMessageUser = await _apiService.GetAsync<UserDto>(myselfEndPoint, currentUserData.GetToken());
            currentUserData.user = resultMessageUser.Data;
            if (currentUserData == null)
            {
                throw new Exception("Current user cant be null");
            }
            return true;
        }
    }
}
