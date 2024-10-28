using BookLibrary.Model.DTO;
using BookLibrary.Models;
using WinformApp.Forms.UserControlComponents.CustomObject;

namespace WinformApp.Forms.UserControlComponents
{
    public partial class BookViewControl : UserControl
    {
        private MainViewModel _mainViewModel;
        private List<Book> _books;

        public BookViewControl(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _mainViewModel = mainViewModel;

            FillDataGridView();
        }

        public async void FillDataGridView()
        {
            _books = await _mainViewModel.GetAllBooks();

            foreach (Book book in _books)
            {
                CustomDataRow<Book> row = new CustomDataRow<Book>(this.dataGridView1, book);
                row.Add(book.ISO, book.EanCode, book.BookInfo.Title, "Details");
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if(row is CustomDataRow<Book>)
            {
                CustomDataRow<Book> customDataRow = row as CustomDataRow<Book>;
                GetBookDetail(customDataRow.GetData());
            }
        }

        private async void GetBookDetail(Book book)
        {
            BookInfo bookInfo = await _mainViewModel.GetBookInfoExtra(book.BookInfoId);

            if (bookInfo == null)
                return;

            this.lbAuthor.Text = bookInfo.GetAuthorName();
            this.lbCategory.Text = bookInfo.GetCategory();
            this.lbUsername.Text = bookInfo.Title;
            this.lbDescription.Text = bookInfo.Description;
            this.lbISO.Text = book.ISO;
        }
    }
}
