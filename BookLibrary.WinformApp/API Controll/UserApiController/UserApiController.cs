using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using WinformApp.Model;

namespace WinformApp.APIControll
{
    public class UserApiController
    {
        private IApiService _apiService;
        public UserApiController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<UserData>? Login(UserLogin login)
        {
            UserData userData= new UserData();
            string loginEndPoint = Config.Settings.GetRoute(Config.ApiUserLogin);
            TokenMessage tokenMessage = await _apiService.PostAsync<TokenMessage>(loginEndPoint, login);
            if (tokenMessage != null)
            {
                string myselfEndPoint = Config.Settings.GetRoute(Config.ApiUserMyself);
                userData.TokenMessage = tokenMessage;
                userData.user = await _apiService.GetAsync<UserDto>(myselfEndPoint, userData.GetToken());
            }
            return userData;
        }
    }
}
