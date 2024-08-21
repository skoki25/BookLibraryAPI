using LibraryWindowsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWindowsApp.Forms
{
    public partial class UserInfoControl : UserControl
    {
        private MainViewModelView _mainViewModelView;
        private UserData currentUser;
        public UserInfoControl(MainViewModelView mainViewModelView)
        {
            InitializeComponent();
            _mainViewModelView = mainViewModelView;
            currentUser = mainViewModelView.currentUserData;
            this.lbUsername.Text = currentUser.user.Email;
            this.lbFirstName.Text = currentUser.user.Name;
            this.lbAdress.Text = currentUser.user.Address;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
