using LibraryWindowsApp.Forms;

namespace LibraryWindowsApp
{
    public partial class LibraryForm : Form
    {
        MainViewModelView _mainViewModelView;
        public LibraryForm(MainViewModelView mainViewModelView)
        {
            InitializeComponent();

            _mainViewModelView = mainViewModelView;
            UserControlTree userControlTree = new UserControlTree(mainViewModelView,this.navigationPanel, this.contentPanel);
        }
    }
}
