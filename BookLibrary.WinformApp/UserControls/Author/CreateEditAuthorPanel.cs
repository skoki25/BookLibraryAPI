using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents.Waiting;
using System.Data;
using WinformApp.Forms;

namespace WinformApp
{
    public partial class CreateEditAuthorPanel : UserControl
    {
        public event Action OnEdit;
        public event Action<Author> OnSaveAction;
        private readonly MainViewModel _viewModel;
        private Author _author;
        private List<Author> authors;
        ModeType modeType;

        public CreateEditAuthorPanel(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _author = new Author();
            modeType = ModeType.Create;
            Setup();
        }

        public CreateEditAuthorPanel(MainViewModel mainViewModel, Author author)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _author = author;
            modeType = ModeType.Edit;

            Setup();
        }

        public CreateEditAuthorPanel(MainViewModel mainViewModel, Author author, bool isCreateMode)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _author = author;
            modeType = ModeType.Edit;
            if(_author == null)
            {
                _author = new Author();
            }
            Setup();
            SetupMultipleMode(isCreateMode);


        }

        private async void SetupMultipleMode(bool isCreateMode)
        {
            ChangeMode(isCreateMode);
            chbCreateNewAuthor.Visible = true;
            cbAuthor.Visible = true;
            cbAuthor.Enabled = isCreateMode;
            authors = await _viewModel.GetAllAuthors();

            cbAuthor.DataSource = authors;
            cbAuthor.DisplayMember = nameof(Author.FullName);
            cbAuthor.ValueMember = nameof(Author.Id);
            cbAuthor.SelectedValue = _author.Id;
        }



        private void Setup()
        {
            tbFirstName.DataBindings.Add(new Binding(nameof(tbFirstName.Text), _author, nameof(Author.FirstName)));
            tbLastName.DataBindings.Add(new Binding(nameof(tbLastName.Text), _author, nameof(Author.LastName)));
            tbAge.Text = _author.Age.ToString();
        }

        private void btCreateEdit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbAge.Text, out var age))
            {
                _author.Age = age;
                SetMode();
            }
            else
            {
                MessageBox.Show($"Text '{tbAge.Text}' isnt number");
            }
        }

        private async void SetMode()
        {
            WaitingPanel waitingPanel = new WaitingPanel();
            try
            {
                Author author = new Author();
                this.Controls.Clear();
                this.Controls.Add(waitingPanel);
                waitingPanel.Dock = DockStyle.Fill;
                if (modeType == ModeType.Create)
                {
                    author = await _viewModel.CreateAuthor(_author);
                }
                else
                {
                    author = await _viewModel.EditAuthor(_author);
                }
                OnEdit?.Invoke();
                OnSaveAction?.Invoke(author);
                waitingPanel.Success();
            }
            catch (Exception ex)
            {
                waitingPanel.Fail();
            }
        }

        private void chbCreateNewAuthor_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = this.chbCreateNewAuthor.Checked;
            this.cbAuthor.Enabled = isChecked;
            ChangeMode(isChecked);
        }

        private void ChangeMode(bool isEditMode)
        {
            modeType = isEditMode ? ModeType.Edit : ModeType.Create;
        }

        private void cbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbAuthor.SelectedValue is int)
            {
                int id = (int)cbAuthor.SelectedValue;
                _author = authors.Where(x=> x.Id == id).SingleOrDefault();
                tbAge.Text = _author.Age.ToString();
                tbFirstName.Text = _author.FirstName;
                tbLastName.Text = _author.LastName;
                
            }

        }
    }
}