using BookLibrary.WinformApp.Forms.Context;
using BookLibrary.WinformApp.Forms.Menu;
using WinformApp;
using WinformApp.Forms;

namespace BookLibrary.WinformApp.Forms
{
    public class MenuNavigationTree
    {
        private ComponentContext _context;
        private MenuComposite _main;

        public MenuNavigationTree(MainViewModel viewModel, Panel navigationPanel, Panel contentPanel)
        {
            _context = new ComponentContext(viewModel, contentPanel, navigationPanel);
            _main = new MenuComposite("Menu",EnumControl.Menu, _context);
            _main.Add(CreateUserMenu());
            _main.Add(CreateBookMenu());
            _main.Add(CreateBorrowBookMenu());
            _main.Add(CreateCategoryMenu());
            _main.Add(CreateAuthor());
            _main.Button.PerformClick();
        }

        public MenuComposite CreateUserMenu()
        {
            MenuComposite menuComposite = new MenuComposite("User", EnumControl.UserInfo, _context);
            MenuItem conentUserEdit = new MenuItem("Edit Profil", EnumControl.UserInfo, _context);
            MenuItem conentUserPassword = new MenuItem("Change Password", EnumControl.UserPassword, _context);

            menuComposite.Add(_main, 0);
            menuComposite.Add(conentUserEdit);
            menuComposite.Add(conentUserPassword);

            return menuComposite;
        }

        public MenuComposite CreateBorrowBookMenu()
        {
            MenuComposite menuComposite = new MenuComposite("Borrowed Book", EnumControl.Book, _context);
            MenuItem bookBorrowMyHistory = new MenuItem("My borrow history", EnumControl.BorrowHistory, _context);

            menuComposite.Add(_main, 0);
            menuComposite.Add(bookBorrowMyHistory);
            return menuComposite;
        }

        public MenuComposite CreateBookMenu()
        {
            MenuComposite menuComposite = new MenuComposite("Book", EnumControl.Book, _context);
            MenuItem bookCreateItem = new MenuItem("Create Book", EnumControl.BookCreate, _context);
            MenuItem bookEditItem = new MenuItem("Edit Book", EnumControl.BookEdit, _context);
            MenuItem bookDeleteItem = new MenuItem("Delete Book", EnumControl.BookDelete, _context);

            menuComposite.Add(_main, 0);
            menuComposite.Add(bookCreateItem);
            menuComposite.Add(bookEditItem);
            menuComposite.Add(bookDeleteItem);
            return menuComposite;
        }

        public MenuComposite CreateCategoryMenu()
        {
            MenuComposite menuComposite = new MenuComposite("Category", EnumControl.Category, _context);
            MenuItem categoryCreateItem = new MenuItem("Create Category", EnumControl.CategoryCreate, _context);
            MenuItem categoryEditItem = new MenuItem("Edit Category", EnumControl.CategoryEdit, _context);

            menuComposite.Add(_main, 0);
            menuComposite.Add(categoryCreateItem);
            menuComposite.Add(categoryEditItem);

            return menuComposite;
        }

        public MenuComposite CreateAuthor()
        {
            MenuComposite menuComposite = new MenuComposite("Author", EnumControl.Author, _context);
            MenuItem authorCreateItem = new MenuItem("Create Author", EnumControl.AuthorCreate, _context);
            MenuItem authorEditItem = new MenuItem("Edit Author", EnumControl.AuthorEdit, _context);

            menuComposite.Add(_main, 0);
            menuComposite.Add(authorCreateItem);
            menuComposite.Add(authorEditItem);

            return menuComposite;
        }
    }
}
