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

        private MainViewModelView _viewModel;

        public UserControlFactory(MainViewModelView viewModel)
        {
            _viewModel = viewModel;
        }

        public UserControl CreateUserControl(EnumControl controlType)
        {
            switch (controlType)
            {
                case EnumControl.Menu:
                    return new MenuControl();
                case EnumControl.UserInfo:
                    return new UserInfoControl(_viewModel);
                case EnumControl.UserPassword:
                    return new UserPasswordChange();
                default:
                    return new UserControl();
            }
        }
    }
}
