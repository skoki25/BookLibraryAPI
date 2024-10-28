using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents.Waiting;
using WinformApp.Forms;

namespace WinformApp
{
    public partial class CreateEditBookInfoExistObjPanel : UserControl
    {
        private readonly MainViewModel _viewModel;
        public event Action OnEdit;
        private Category _category;
        private Author _author;
        private BookInfo _bookInfo;
        private List<Category> _categories;
        private List<Author> _authors;
        ModeType modeType;

        public CreateEditBookInfoExistObjPanel(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _category = new Category();
            modeType = ModeType.Create;
            FillComboBoxes();
            Setup();
        }

        public CreateEditBookInfoExistObjPanel(MainViewModel mainViewModel,BookInfo bookInfo)
        {
            InitializeComponent();
            _bookInfo = bookInfo;
            _viewModel = mainViewModel;
            _category = new Category();
            modeType = ModeType.Edit;
            FillComboBoxes();
            Setup();
        }

        private void FillComboBoxes()
        {
            FillAuthorCombo();
            FillCategoryCombo();
        }

        private async void FillAuthorCombo()
        {
            _authors = await _viewModel.GetAllAuthors();

            cbAuthor.DataSource = _authors;
            cbAuthor.DisplayMember = nameof(Author.FullName);
            cbAuthor.ValueMember = nameof(Author.Id);
            cbAuthor.SelectedValue = _bookInfo.AuthorId;
        }
        private async void FillCategoryCombo()
        {
            _categories = await _viewModel.GetAllCategories();

            cbCategory.DataSource = _categories;
            cbCategory.DisplayMember = nameof(Category.Type);
            cbCategory.ValueMember = nameof(Category.Id);
            cbCategory.SelectedValue = _bookInfo.CategoryId;
        }

        private void Setup()
        {
            tbTitle.DataBindings.Add(new Binding(nameof(tbTitle.Text), _bookInfo, nameof(BookInfo.Title)));
            tbDescription.DataBindings.Add(new Binding(nameof(tbDescription.Text), _bookInfo, nameof(BookInfo.Description)));
            cbAuthor.DataBindings.Add(new Binding(nameof(cbAuthor.SelectedValue),_bookInfo, nameof(BookInfo.AuthorId)));
            cbCategory.DataBindings.Add(new Binding(nameof(cbCategory.SelectedValue),_bookInfo, nameof(BookInfo.CategoryId)));
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

                OnEdit?.Invoke();
                waitingPanel.Success();
            }
            catch (Exception ex)
            {
                waitingPanel.Fail();
            }
        }

        private void btEditBookInfo_Click(object sender, EventArgs e)
        {
            SaveBookInfo();
        }

        private async void SaveBookInfo()
        {
            WaitingPanel waitingPanel = new WaitingPanel();
            try
            {
                BookInfo bookInfo;
                this.Controls.Clear();
                this.Controls.Add(waitingPanel);
                waitingPanel.Dock = DockStyle.Fill;
                if (modeType == ModeType.Create)
                {
                    bookInfo = await _viewModel.CreateBookInfo(_bookInfo);
                }
                else if (modeType == ModeType.Edit)
                {
                    _bookInfo.Category = null;
                    _bookInfo.Author = null;
                    bookInfo = await _viewModel.EditBookInfo(_bookInfo);
                }
                else
                {
                    bookInfo = _bookInfo;
                }
                OnEdit?.Invoke();
                //OnSaveAction?.Invoke(category);
                waitingPanel.Success();
            }
            catch (Exception ex)
            {
                waitingPanel.Fail();
            }
        }
    }
}
