using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class LoginForm : Form
    {
        private readonly MainViewModel _mainViewMode;
        public bool UserSuccessfullyAuthenticated { get; private set; } = false;
        public LoginForm(MainViewModel mainViewMode)
        {
            InitializeComponent();
            this._mainViewMode = mainViewMode;
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool response =  await _mainViewMode.Login(tbLgin.Text, tbPassword.Text);
                if (response)
                {
                    UserSuccessfullyAuthenticated = true;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            
        }
    }
}
