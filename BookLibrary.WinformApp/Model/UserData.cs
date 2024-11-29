using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;

namespace WinformApp.Model
{
    public class UserData
    {
        public UserDto user { get; set; }
        public TokenMessage TokenMessage { get; set; }

        public string GetToken()
        {
            return TokenMessage?.Token ?? string.Empty;
        }
    }
}
