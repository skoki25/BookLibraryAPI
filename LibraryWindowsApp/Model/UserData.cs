using BookLibraryAPI.Data.Messages;
using BookLibraryAPI.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Model
{
    public class UserData
    {
        public UserDto user { get; set; }
        public TokenMessage TokenMessage { get; set; }

        public string GetToken()
        {
            if(TokenMessage == null)
            {
                return string.Empty;
            }
            return TokenMessage.Token;
        }
    }
}
