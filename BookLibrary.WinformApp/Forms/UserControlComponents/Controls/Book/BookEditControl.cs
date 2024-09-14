using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApp.Forms.UserControlComponents.CustomObject;

namespace WinformApp.Forms.UserControlComponents
{
    public partial class BookEditControl : UserControl
    {
        private MainViewModel _viewModel;
        private List<Book> _books;

        public BookEditControl(MainViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            FillDataGridView();
        }

        public async void FillDataGridView()
        {
            _books = await _viewModel.GetAllBooks();

            foreach (Book book in _books)
            {
                CustomDataRow<Book> row = new CustomDataRow<Book>(this.dataGridView1, book);
                row.Add(book.ISO, book.EanCode, book.BookInfo.Title, "Edit");
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row is CustomDataRow<Book>)
            {
                CustomDataRow<Book> customDataRow = row as CustomDataRow<Book>;
                panelBook.Controls.Clear();
                CreateEditBookPanel createEditBookPanel = new CreateEditBookPanel(_viewModel, customDataRow.GetData());
                panelBook.Controls.Add(createEditBookPanel);
                createEditBookPanel.Dock = DockStyle.Fill;
            }
        }

        private void createEditBookPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
