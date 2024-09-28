using BookLibrary.Model.DTO;
using BookLibrary.Models;
using BookLibrary.WinformApp.API_Controll.UserApiController;
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
        public CategoryApiController _categoryApiController;
        public AuthorApiController _authorApiController;
        public UserData currentUserData;

        public MainViewModel(
            UserApiController userApiController, 
            BookApiController bookApiController, 
            BookInfoApiController bookInfoApiController,
            CategoryApiController categoryApiController,
            AuthorApiController authorApiController)
        {
            _userApiController = userApiController;
            _bookApiController = bookApiController;
            _bookInfoApiController = bookInfoApiController;
            _categoryApiController = categoryApiController;
            _authorApiController = authorApiController;

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
