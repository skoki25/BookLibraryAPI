using BookLibraryAPI.DTO;
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
        public BookInfoApiController _bookInfoApiController;
        public UserData currentUserData;


        public MainViewModel(UserApiController userApiController, BookApiController bookApiController, BookInfoApiController bookInfoApiController)
        {
            _userApiController = userApiController;
            _bookApiController = bookApiController;
            _bookInfoApiController = bookInfoApiController ;
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

        public async Task<BookInfoDto> GetBookInfoExtra(int id)
        {
            return await _bookInfoApiController.GetBookInfoExtra(id, currentUserData.GetToken());
        }
    }
}
