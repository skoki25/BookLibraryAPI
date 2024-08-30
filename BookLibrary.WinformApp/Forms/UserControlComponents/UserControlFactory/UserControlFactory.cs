using LibraryWindowsApp.Forms.UserControlComponents.Controls;
using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder
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
                default:
                    return new UserControl();
            }
        }
    }
}
