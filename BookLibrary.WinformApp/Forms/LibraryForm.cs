using WinformApp.Forms;

namespace WinformApp
{
    public partial class LibraryForm : Form
    {
        MainViewModel _mainViewModelView;
        public LibraryForm(MainViewModel mainViewModelView)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Maximized;
            _mainViewModelView = mainViewModelView;
            MenuNavigationTree userControlTree = new MenuNavigationTree(mainViewModelView, this.navigationPanel, this.contentPanel);
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
