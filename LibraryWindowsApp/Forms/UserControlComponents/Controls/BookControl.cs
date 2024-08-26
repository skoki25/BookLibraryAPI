using BookLibraryAPI.Models;
using LibraryWindowsApp.Forms.UserControlComponents.CustomObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWindowsApp.Forms.UserControlComponents.Controls
{
    public partial class BookControl : UserControl
    {
        private MainViewModel _mainViewModel;
        private List<Book> _books;

        public BookControl(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;

            FillDataGridView();
        }

        public async void FillDataGridView()
        {
            _books = await _mainViewModel.GetAllBooks();

            foreach(Book book in _books)
            {
                CustomDataRow<Book> row = new CustomDataRow<Book>(this.dataGridView1,book);
                row.Add(book.ISO, book.EanCode, book.BookInfo.Title, "Details");
                this.dataGridView1.Rows.Add(row);
            }
        }
    }
}
