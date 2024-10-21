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
            List<BookInfo> categoryList = await _viewModel.GetAllBookInfo();

            foreach (BookInfo category in categoryList)
            {
                //int count = category?.Count() ?? 0;
                //this.dataGridView1.Rows.Add(category.Type, count);
            }
        }
    }
}
