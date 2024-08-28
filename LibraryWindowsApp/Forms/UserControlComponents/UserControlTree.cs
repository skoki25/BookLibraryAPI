using LibraryWindowsApp.Forms.UserControlComponents;
using LibraryWindowsApp.Forms.UserControlComponents.UserComponentBuilder;
using LibraryWindowsApp.Forms.UserControlComponents.UserControlFactory;

namespace LibraryWindowsApp.Forms
{
    public class UserControlTree
    {
        private ComponentContext _context;
        private MenuComposite _main;

        public UserControlTree(MainViewModel viewModel, Panel contentPanel, Panel navigationPanel) 
        {
            _context = new ComponentContext(viewModel, contentPanel, navigationPanel);
            _main = new MenuComposite("Menu", EnumControl.Menu, _context);
            _main.Add(CreateUserMenu());
            _main.Add(CreateBookMenu());
            _main.Add(CreateBorrowBookMenu());
            _main.Add(CreateCategoryMenu());
            _main.Button.PerformClick();
        }

        public MenuComposite CreateUserMenu()
        {
            MenuComposite menuComposite = new MenuComposite("User", EnumControl.UserInfo, _context);
            MenuItem conentUserEdit = new MenuItem("Edit Profil", EnumControl.UserInfo, _context);
            MenuItem conentUserPassword = new MenuItem("Change Password", EnumControl.UserPassword, _context);

            menuComposite.Add(_main);
            menuComposite.Add(conentUserEdit);
            menuComposite.Add(conentUserPassword);

            return menuComposite;
        }

        public MenuComposite CreateBorrowBookMenu()
        {
            MenuComposite menuComposite = new MenuComposite("Borrowed Book",EnumControl.Book, _context);
            MenuItem bookBorrowMyHistory = new MenuItem("My borrow history",  EnumControl.BorrowHistory, _context);

            menuComposite.Add(_main);
            menuComposite.Add(bookBorrowMyHistory);
            return menuComposite;
        }

        public MenuComposite CreateBookMenu()
        {
            MenuComposite menuComposite = new MenuComposite("Book", EnumControl.Book, _context);
            MenuItem bookCreateItem = new MenuItem("Create Book", EnumControl.Other, _context);
            MenuItem bookEditItem = new MenuItem("Edit Book", EnumControl.Other, _context);
            MenuItem bookDeleteItem = new MenuItem("Delete Book", EnumControl.Other, _context);

            menuComposite.Add(_main);
            menuComposite.Add(bookCreateItem);
            menuComposite.Add(bookEditItem);
            menuComposite.Add(bookDeleteItem);
            return menuComposite;
        }

        public MenuComposite CreateCategoryMenu()
        {
            MenuComposite menuComposite = new MenuComposite("Category", EnumControl.Book,_context);
            MenuItem categoryCreateItem = new MenuItem("Create Category", EnumControl.Other, _context);
            MenuItem categoryEditItem = new MenuItem("Edit Category",EnumControl.Other, _context);

            menuComposite.Add(categoryCreateItem);
            menuComposite.Add(categoryEditItem);
            return menuComposite;
        }
    }
}
