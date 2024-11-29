using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents.Waiting;
using WinformApp.Forms;

namespace WinformApp
{
    public partial class CreateEditCategoryPanel : UserControl
    {
        private readonly MainViewModel _viewModel;
        public event Action OnEdit;
        public event Action<Category> OnSaveAction;
        private Category _category;
        private List<Category> _categories;
        ModeType modeType;

        public CreateEditCategoryPanel(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _category = new Category();
            modeType = ModeType.Create;
            Setup();
        }

        public CreateEditCategoryPanel(MainViewModel mainViewModel, Category category)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _category = category;
            modeType = ModeType.Edit;

            Setup();
        }

        public CreateEditCategoryPanel(MainViewModel mainViewModel, bool isCreateMode)
        {
            InitializeComponent();
            chbCreateNewAuthor.Visible = true;
            cbCategory.Visible = true;

            _viewModel = mainViewModel;
            _category = new Category();
            Setup();
            SetupMultipleMode(isCreateMode);


        }

        private void Setup()
        {
            tbEanCode.DataBindings.Add(new Binding(nameof(tbEanCode.Text), _category, nameof(Category.Type)));
        }
        private async void SetupMultipleMode(bool isCreateMode)
        {
            ChangeMode(isCreateMode);
            cbCategory.Enabled = isCreateMode;
            _categories = await _viewModel.GetAllCategories();

            cbCategory.DataSource = _categories;
            cbCategory.DisplayMember = nameof(Category.Type);
            cbCategory.ValueMember = nameof(Category.Id);
            cbCategory.SelectedValue = _category?.Id;
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
                Category category;
                this.Controls.Clear();
                this.Controls.Add(waitingPanel);
                waitingPanel.Dock = DockStyle.Fill;
                if (modeType == ModeType.Create)
                {
                    category = await _viewModel.CreateCategory(_category);
                }
                else if (modeType == ModeType.Edit)
                {
                    category = await _viewModel.EditCategory(_category);
                }
                else
                {
                    category = _category;
                }
                OnEdit?.Invoke();
                OnSaveAction?.Invoke(category);
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
                _category = _categories.Where(x => x.Id == id).SingleOrDefault();
            }
        }

        private void titlePanelCreate_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
