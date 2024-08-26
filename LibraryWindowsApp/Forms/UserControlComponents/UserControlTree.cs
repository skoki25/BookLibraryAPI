using LibraryWindowsApp.Forms.UserControlComponents;
using LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder;
using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;

namespace LibraryWindowsApp.Forms
{
    public class UserControlTree
    {
        private Panel _contentPanel;
        private Panel _navigationPanel;
        private MainViewModel _viewModel;
        Composter main;

        public UserControlTree(MainViewModel viewModel, Panel contentPanel, Panel navigationPanel) 
        {
            _contentPanel = contentPanel;
            _navigationPanel = navigationPanel;
            _viewModel = viewModel;

            main = new Composter("Menu", viewModel, EnumControl.Menu, navigationPanel, contentPanel);
            
            Composter composterUserMain = new Composter("User", viewModel, EnumControl.UserInfo, navigationPanel, contentPanel);
            UserContainer conentUserEdit = new UserContainer("Edit Profil", viewModel, EnumControl.UserInfo, contentPanel);
            UserContainer conentUserPassword = new UserContainer("Change Password", viewModel,EnumControl.UserPassword, contentPanel);

            main.Add(composterUserMain);
            main.Add(BookButtons());
            main.Add(BorrowBookButtons());
            composterUserMain.Add(main);


            composterUserMain.Add(conentUserEdit);
            composterUserMain.Add(conentUserPassword);



            main.Button.PerformClick();
        }

        public Composter BorrowBookButtons()
        {
            Composter composterBorrowedBook = new Composter("Borrowed Book",
                _viewModel,EnumControl.Book, _navigationPanel, _contentPanel);
            UserContainer bookBorrowMyHistory = new UserContainer("My borrow history", 
               _viewModel, EnumControl.BorrowHistory, _contentPanel);

            composterBorrowedBook.Add(main);
            composterBorrowedBook.Add(bookBorrowMyHistory);

            return composterBorrowedBook;
        }

        public Composter BookButtons()
        {
            Composter composterBookMain = new Composter("Book", _viewModel, EnumControl.Book,
                _navigationPanel, _contentPanel);
            UserContainer bookContentCreate = new UserContainer("Create Book", _viewModel, EnumControl.other, _contentPanel);
            UserContainer bookContentEdit = new UserContainer("Edit Book", _viewModel, EnumControl.other, _contentPanel);
            UserContainer bookContentDelete = new UserContainer("Delete Book", _viewModel, EnumControl.other, _contentPanel);

            composterBookMain.Add(main);
            composterBookMain.Add(bookContentCreate);
            composterBookMain.Add(bookContentEdit);
            composterBookMain.Add(bookContentDelete);

            return composterBookMain;
        }
    }
}
