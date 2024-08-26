using LibraryWindowsApp.Forms;

namespace LibraryWindowsApp
{
    public partial class LibraryForm : Form
    {
        MainViewModel _mainViewModelView;
        public LibraryForm(MainViewModel mainViewModelView)
        {
            InitializeComponent();

            _mainViewModelView = mainViewModelView;
            UserControlTree userControlTree = new UserControlTree(mainViewModelView,this.navigationPanel, this.contentPanel);
        }
    }
}
