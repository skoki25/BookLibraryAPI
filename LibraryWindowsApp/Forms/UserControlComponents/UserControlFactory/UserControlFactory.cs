using LibraryWindowsApp.Forms.UserControlComponents.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder
{
    public class UserControlFactory 
    {
        public UserInfoControl UserInfoControl { get; set; }
        public UserPasswordChange UserChangeControl { get; set; }
        public MenuControl MenuControl { get; set; }

        private MainViewModelView _viewModel;

        public UserControlFactory(MainViewModelView viewModel)
        {
            _viewModel = viewModel;
            UserInfoControl = new UserInfoControl(viewModel);
            UserChangeControl = new UserPasswordChange();
            MenuControl = new MenuControl();
        }
    }
}
