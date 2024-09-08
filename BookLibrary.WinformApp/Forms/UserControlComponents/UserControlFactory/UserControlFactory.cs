using BookLibrary.WinformApp.Forms.UserControlComponents.Controls.Book;
using WinformApp.Forms.UserControlComponents.Controls;
using WinformApp.Forms.UserControlComponents.UserControlFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp.Forms.UserControlComponents.UserComponentBuilder
{
    public class UserControlFactory 
    {
        static public UserControl CreateUserControl(EnumControl controlType, MainViewModel _viewModel)
        {
            switch (controlType)
            {
                case EnumControl.Menu:
                    return new MenuControl();
                case EnumControl.UserInfo:
                    return new UserInfoControl(_viewModel);
                case EnumControl.UserPassword:
                    return new UserPasswordChange();
                case EnumControl.Book:
                    return new BookControl(_viewModel);
                case EnumControl.BookCreate:
                    return new BookCreateControl(_viewModel);
                case EnumControl.BookEdit:
                    return new BookEditControl(_viewModel);
                default:
                    return new UserControl();
            }
        }
    }
}
