using WinformApp.Forms.UserControlComponents.Controls;
using WinformApp.Forms.UserControlComponents;
using BookLibrary.WinformApp.Forms.UserControlComponents.Controls.Book;

namespace WinformApp.Forms
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
                case EnumControl.CategoryCreate:
                    return new CategoryCreateControl(_viewModel);
                case EnumControl.CategoryEdit:
                    return new CategoryEditControl(_viewModel);
                default:
                    return new UserControl();
            }
        }
    }
}