using BookLibraryAPI.Models;
using LibraryWindowsApp.API_Controll.UserApiController;
using LibraryWindowsApp.APIControll;
using LibraryWindowsApp.Model;

namespace LibraryWindowsApp
{
    public class MainViewModel
    {
        public UserApiController _userApiController;
        public BookApiController _bookApiController;
        public UserData currentUserData;


        public MainViewModel(UserApiController userApiController, BookApiController bookApiController)
        {
            _userApiController = userApiController;
            _bookApiController = bookApiController;
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

        public async Task<List<Book>> GetAllBooks()
        {
            if(_bookApiController == null)
            {
                return new List<Book>();
            }

            return await _bookApiController.GetAllBook(currentUserData.GetToken());
        }
    }
}
