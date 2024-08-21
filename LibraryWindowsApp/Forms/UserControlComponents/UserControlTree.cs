using LibraryWindowsApp.Forms.UserControlComponents;
using LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWindowsApp.Forms
{
    public class UserControlTree
    {
        public UserControlTree(MainViewModelView viewModel, Panel contentPanel, Panel navigationPanel) 
        {
            UserControlFactory userFactory = new UserControlFactory(viewModel);
            Composter main = new Composter("Menu", userFactory.MenuControl, navigationPanel, contentPanel);
            Composter composterUserMain = new Composter("User", userFactory.UserInfoControl, navigationPanel, contentPanel);
            Composter composterBookMain = new Composter("Book",new UserControl(), navigationPanel, contentPanel);
            Composter composterBorrowedBook = new Composter("Borrowed Book",new UserControl(), navigationPanel, contentPanel);
            UserContainer conentUserEdit = new UserContainer("Edit Profil",new UserControl(),contentPanel);
            UserContainer conentUserPassword = new UserContainer("Change Password",userFactory.UserChangeControl,contentPanel);
            UserContainer bookContentCreate= new UserContainer("Create Book",new UserControl(),contentPanel);
            UserContainer bookContentEdit = new UserContainer("Edit Book", new UserControl(), contentPanel);
            UserContainer bookContentDelete = new UserContainer("Delete Book", new UserControl(), contentPanel);
            Composter BookSe = new Composter("Book Searc", new UserControl(), navigationPanel, contentPanel);
            UserContainer bookContentDelete11 = new UserContainer("Delete 1 Book", new UserControl(), contentPanel);
            UserContainer bookContentDelete2 = new UserContainer("Delete 2 Book", new UserControl(), contentPanel);
            BookSe.Add(main);
            BookSe.Add(composterBorrowedBook);
            BookSe.Add(bookContentDelete11);
            BookSe.Add(bookContentDelete2);

            main.Add(composterUserMain);
            main.Add(composterBookMain);
            main.Add(composterBorrowedBook);
            composterUserMain.Add(main);
            composterBookMain.Add(main);
            composterBorrowedBook.Add(main);

            composterBorrowedBook.Add(BookSe);

            composterUserMain.Add(conentUserEdit);
            composterUserMain.Add(conentUserPassword);

            composterBookMain.Add(bookContentCreate);
            composterBookMain.Add(bookContentEdit);
            composterBookMain.Add(bookContentDelete);

            //main.GenerateMenu();
            main.Button.PerformClick();
        }
    }
}
