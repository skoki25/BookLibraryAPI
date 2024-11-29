using BookLibrary.Model.DTO;
using BookLibrary.Models;

namespace WinformApp.Forms.UserControlComponents
{
    public partial class CreateEditBookPanel : UserControl
    {
        public event Action OnEdit;

        public ModeType modeType;
        private MainViewModel _viewModel;
        private Book _originBook;
        private Book _book;

        public CreateEditBookPanel()
        {
            InitializeComponent();
        }

        public CreateEditBookPanel(MainViewModel viewModel)
        {
            InitializeComponent();

            this._viewModel = viewModel;
            this.modeType = ModeType.Create;
            _book = new Book();
            Setup();
        }

        public CreateEditBookPanel(MainViewModel viewModel, Book book)
        {
            InitializeComponent();

            this._viewModel = viewModel;
            this._originBook = book;
            this._book = this._originBook.Clone();
            this.modeType = ModeType.Edit;
            Setup();
        }
        private void Setup() 
        {
            FillComboBookInfo();
            BindingData();
        }

        private void BindingData()
        {
            tbEanCode.DataBindings.Add(nameof(tbEanCode.Text), _book, nameof(_book.EanCode));;
            tbIso.DataBindings.Add(nameof(tbIso.Text), _book, nameof(_book.ISO));
            dtPublicationDate.DataBindings.Add(nameof(dtPublicationDate.Value), _book, nameof(_book.PublicationDate));
            cbBookInfo.DataBindings.Add(nameof(cbBookInfo.SelectedValue), _book, nameof(_book.BookInfoId));
        }

        private async void FillComboBookInfo() 
        {
            List<BookInfo> bookInfoDtos = await _viewModel.GetAllBookInfo();

            cbBookInfo.DataSource = bookInfoDtos;
            cbBookInfo.DisplayMember = nameof(BookInfoDto.Title);
            cbBookInfo.ValueMember = nameof(BookInfoDto.Id);
            cbBookInfo.SelectedValue = _book.BookInfoId;
        }

        public void DisableAll(bool disable)
        {
            tbEanCode.Enabled = disable;
            tbIso.Enabled = disable;
            dtPublicationDate.Enabled = disable;
        }

        private void BtSaveBook(object sender, EventArgs e)
        {
            SaveOrEditBook();
        }

        public async void SaveOrEditBook()
        {
            if (modeType == ModeType.Create)
            {
                await _viewModel.CreateBook(_book);
            }
            else if(modeType == ModeType.Edit)
            {
                await _viewModel.EditBook(_book);
                Thread.Sleep(2000);
            }
            OnEdit?.Invoke();

        }
    }
}
