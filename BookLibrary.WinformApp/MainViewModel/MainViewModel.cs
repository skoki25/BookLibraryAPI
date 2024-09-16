using BookLibrary.Model.DTO;
using BookLibrary.Models;
using WinformApp.API_Controll.UserApiController;
using WinformApp.APIControll;
using WinformApp.Model;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public UserApiController _userApiController;
        public BookApiController _bookApiController;
        public BookInfoApiController _bookInfoApiController;
        public UserData currentUserData;

        public MainViewModel(UserApiController userApiController, BookApiController bookApiController, BookInfoApiController bookInfoApiController)
        {
            _userApiController = userApiController;
            _bookApiController = bookApiController;
            _bookInfoApiController = bookInfoApiController ;

            _userApiController.OnErrorMessage     += HandleErrorMessage;
            _bookApiController.OnErrorMessage     += HandleErrorMessage;
            _bookInfoApiController.OnErrorMessage += HandleErrorMessage;
        }

        public void HandleErrorMessage(string error)
        {
            MessageBox.Show(error);
        }

        public async Task<bool> Login(string loginName, string password)
        {

            UserLogin login = new UserLogin { Email = loginName, Password = password };
            currentUserData = await _userApiController.Login(login);
            if(currentUserData == null)
            {
               throw new Exception("Current user cant be null");
            }
            return true;
        }
    }
}
