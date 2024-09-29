using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.WinformApp.API_Controll.UserApiController;
using WinformApp.Model;

namespace WinformApp.APIControll
{
    public class UserApiController: ApiControllerBase
    {
        public UserApiController(IApiService apiService) : base(apiService) 
        { 
        }

        public async Task<UserData>? Login(UserLogin login)
        {
            UserData userData= new UserData();
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiUserLogin);
            ResultMessage<TokenMessage> resultMessage = await _apiService.PostAsync<TokenMessage>(loginEndPoint, login);
            if (resultMessage?.Data != null)
            {
                TokenMessage tokenMessage = resultMessage.Data;
                string myselfEndPoint = Config.Settings.GetRoute(Config.ApiUserMyself);
                userData.TokenMessage = tokenMessage;
                ResultMessage<UserDto> resultMessageUser = await _apiService.GetAsync<UserDto>(myselfEndPoint, userData.GetToken());

                userData.user = resultMessageUser.Data;
            }
            return userData;
        }
    }
}
