using LibraryWindowsApp.APIControll;
using LibraryWindowsApp.Model;

namespace LibraryWindowsApp
{
    public class MainViewModelView
    {
        public UserApiController _userApiController;
        public UserData currentUserData;


        public MainViewModelView(UserApiController userApiController)
        {
            _userApiController = userApiController;
        }

        public async Task<bool> Login(string loginName, string password)
        {

            UserLogin login = new UserLogin { Email = loginName, Password = password };
            currentUserData = await _userApiController.Login(login);
            if(currentUserData == null)
            {
               throw new Exception("Current urrent cant be null");
            }
            return true;
        }
    }
}
