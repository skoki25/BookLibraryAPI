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
            MenuNavigationTree userControlTree = new MenuNavigationTree(mainViewModelView,this.navigationPanel, this.contentPanel);
        }
    }
}
