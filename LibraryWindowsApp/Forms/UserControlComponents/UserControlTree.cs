using LibraryWindowsApp.Forms.UserControlComponents;
using LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder;
using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;

namespace LibraryWindowsApp.Forms
{
    public class UserControlTree
    {
        public UserControlTree(MainViewModelView viewModel, Panel contentPanel, Panel navigationPanel) 
        {
            UserControlFactory userFactory = new UserControlFactory(viewModel);
            Composter main = new Composter("Menu", userFactory.CreateUserControl(EnumControl.Menu), navigationPanel, contentPanel);
            Composter composterUserMain = new Composter("User", userFactory.CreateUserControl(EnumControl.UserInfo), navigationPanel, contentPanel);
            Composter composterBookMain = new Composter("Book",new UserControl(), navigationPanel, contentPanel);
            Composter composterBorrowedBook = new Composter("Borrowed Book",new UserControl(), navigationPanel, contentPanel);
            UserContainer conentUserEdit = new UserContainer("Edit Profil",new UserControl(),contentPanel);
            UserContainer conentUserPassword = new UserContainer("Change Password", userFactory.CreateUserControl(EnumControl.UserPassword), contentPanel);
            UserContainer bookContentCreate= new UserContainer("Create Book",new UserControl(),contentPanel);
            UserContainer bookContentEdit = new UserContainer("Edit Book", new UserControl(), contentPanel);
            UserContainer bookContentDelete = new UserContainer("Delete Book", new UserControl(), contentPanel);

            main.Add(composterUserMain);
            main.Add(composterBookMain);
            main.Add(composterBorrowedBook);
            composterUserMain.Add(main);
            composterBookMain.Add(main);
            composterBorrowedBook.Add(main);


            composterUserMain.Add(conentUserEdit);
            composterUserMain.Add(conentUserPassword);

            composterBookMain.Add(bookContentCreate);
            composterBookMain.Add(bookContentEdit);
            composterBookMain.Add(bookContentDelete);

            main.Button.PerformClick();
        }
    }
}
