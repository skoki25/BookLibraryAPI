using BookLibrary.WinformApp.Forms;
using WinformApp.APIControll;

namespace WinformApp
{
    public partial class LibraryForm : Form
    {
        MainViewModel _mainViewModelView;
        public LibraryForm(MainViewModel mainViewModelView, IApiService apiService)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            _mainViewModelView = mainViewModelView;
            MenuNavigationTree userControlTree = new MenuNavigationTree(mainViewModelView, this.navigationPanel, this.contentPanel);

            apiService.OnErrorMessage += OnErrorMessage;
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void OnErrorMessage(Exception ex)
        {
            if (ex is UnauthorizedAccessException)
            {
                this.Enabled =false;

                LoginForm loginForm = new LoginForm(_mainViewModelView);
                if(loginForm.ShowDialog() == DialogResult.OK)
                {
                    if (loginForm.UserSuccessfullyAuthenticated)
                    {
                        this.Enabled = true;
                    }
                }

            }
        }
    }
}
