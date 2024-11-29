using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents.Waiting;
using WinformApp.Forms;
using WinformApp.Installation;

namespace WinformApp
{
    public partial class CreateEditBookInfoPanel : UserControl
    {
        private readonly MainViewModel _viewModel;
        public event Action OnEdit;
        public event Action<BookInfo> OnSaveAction;
        private BookInfo _bookInfo;
        private List<BookInfo> _bookInfos;
        ModeType modeType;

        public CreateEditBookInfoPanel(MainViewModel mainViewModel, int idCategory,int idAuthor)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _bookInfo = new BookInfo();
            _bookInfo.AuthorId =idAuthor;
            _bookInfo.CategoryId =idCategory;
            modeType = ModeType.Create;
            Setup();
        }

        public CreateEditBookInfoPanel(MainViewModel mainViewModel, BookInfo bookInfo)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _bookInfo = bookInfo;
            modeType = ModeType.Edit;

            Setup();
        }

        public CreateEditBookInfoPanel(MainViewModel mainViewModel, int idCategory, int idAuthor, bool isCreateMode)
        {
            InitializeComponent();
            chbCreateNewAuthor.Visible = true;
            cbCategory.Visible = true;

            _viewModel = mainViewModel;
            _bookInfo = new BookInfo();
            _bookInfo.AuthorId = idAuthor;
            _bookInfo.CategoryId = idCategory;
            Setup();
            SetupMultipleMode(isCreateMode);


        }

        private void Setup()
        {
            tbTitle.DataBindings.Add(new Binding(nameof(tbTitle.Text), _bookInfo, nameof(BookInfo.Title)));
            tbDescription.DataBindings.Add(new Binding(nameof(tbDescription.Text), _bookInfo, nameof(BookInfo.Description)));
        }
        private async void SetupMultipleMode(bool isCreateMode)
        {
            ChangeMode(isCreateMode);
            cbCategory.Enabled = isCreateMode;
            _bookInfos = await _viewModel.GetAllBookInfo();

            cbCategory.DataSource = _bookInfos;
            cbCategory.DisplayMember = nameof(Category.Type);
            cbCategory.ValueMember = nameof(Category.Id);
            cbCategory.SelectedValue = _bookInfo?.Id;
        }

        private void ChangeMode(bool isEditMode)
        {
            modeType = isEditMode ? ModeType.Readonly : ModeType.Create;
        }

        private void btCreateEdit_Click(object sender, EventArgs e)
        {
            SetMode();
        }

        private async void SetMode()
        {
            WaitingPanel waitingPanel = new WaitingPanel();
            try
            {
                BookInfo bookInfo;
                this.Controls.Clear();
                this.Controls.Add(waitingPanel);
                waitingPanel.FillDock();
                if (modeType == ModeType.Create)
                {
                    bookInfo = await _viewModel.CreateBookInfo(_bookInfo);
                }
                else if (modeType == ModeType.Edit)
                {
                    bookInfo = await _viewModel.EditBookInfo(_bookInfo);
                }
                else
                {
                    bookInfo = _bookInfo;
                }
                OnEdit?.Invoke();
                OnSaveAction?.Invoke(bookInfo);
                waitingPanel.Success();
            }
            catch (Exception ex)
            {
                waitingPanel.Fail();
            }
        }

        private void chbCreateCategory_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = this.chbCreateNewAuthor.Checked;
            this.cbCategory.Enabled = isChecked;
            ChangeMode(isChecked);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue is int)
            {
                int id = (int)cbCategory.SelectedValue;
                _bookInfo = _bookInfos.Where(x => x.Id == id).SingleOrDefault();
            }
        }
    }
}
