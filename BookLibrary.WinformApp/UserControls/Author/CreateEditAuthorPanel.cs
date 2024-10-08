using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents.Waiting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApp.Forms;

namespace WinformApp.UserControls
{
    public partial class CreateEditAuthorPanel : UserControl
    {
        private readonly MainViewModel _viewModel;
        public event Action OnEdit;
        private Author _author;
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

        private void Setup()
        {
            tbFirstName.DataBindings.Add(new Binding(nameof(tbFirstName.Text), _author, nameof(Author.FirstName)));
            tbLastName.DataBindings.Add(new Binding(nameof(tbLastName.Text), _author, nameof(Author.LastName)));
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

                this.Controls.Clear();
                this.Controls.Add(waitingPanel);
                waitingPanel.Dock = DockStyle.Fill;
                switch (modeType)
                {
                    case ModeType.Create:
                        await _viewModel.CreateAuthor(_author);
                        break;
                    case ModeType.Edit:
                        await _viewModel.EditAuthor(_author);
                        break;
                    default:
                        break;
                }
                OnEdit?.Invoke();
                waitingPanel.Success();
            }
            catch (Exception ex)
            {
                waitingPanel.Fail();
            }
        }

    }
}
