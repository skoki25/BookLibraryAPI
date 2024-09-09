using BookLibrary.Models;

namespace WinformApp.Forms.UserControlComponents
{
    public partial class CreateEditBookPanel : UserControl
    {
        public ModeType modeType;
        private MainViewModel _viewModel;
        private Book _book;

        public CreateEditBookPanel() {
            InitializeComponent();

        }

        public void Create(MainViewModel viewModel)
        {
            this._viewModel = viewModel;
            this.modeType = ModeType.Create;
            _book = new Book();


        }

        public CreateEditBookPanel(MainViewModel viewModel,Book book)
        {
            InitializeComponent();

            this._viewModel = viewModel;
            this._book = book;
            this.modeType = ModeType.Edit;
            FillWithData();
        }

        private void FillWithData()
        {
            tbEanCode.Text = _book.EanCode;
            tbIso.Text = _book.ISO;
            dtPublicationDate.Value = _book.PublicationDate;
        }
    }
}
