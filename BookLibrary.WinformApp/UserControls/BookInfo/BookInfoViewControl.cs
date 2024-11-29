using BookLibrary.Models;

namespace WinformApp
{
    public partial class BookInfoViewControl : UserControl
    {
        private List<BookInfo> categoryList;
        private MainViewModel _viewModel;
        public BookInfoViewControl(MainViewModel viewModel)
        {
            _viewModel = viewModel;

            InitializeComponent();
            FillDataGrid();
        }

        public async void FillDataGrid()
        {
            List<BookInfo> bookInfoList = await _viewModel.GetAllBookInfo();
            this.dataGridView1.Rows.Clear();
            foreach (BookInfo bookInfo in bookInfoList)
            {
                this.dataGridView1.Rows.Add(bookInfo.Title, bookInfo.GetCategory(), bookInfo.Description, bookInfo.GetAuthorName());
            }
        }
    }
}
