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
            tbEanCode.DataBindings.Add(new Binding(nameof(tbEanCode.Text), _author, nameof(Author.FirstName)));
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
                //this.Controls.Clear();
                //this.Controls.Add(this.tableLayoutPanel1);
            }
            catch (Exception ex)
            {
                waitingPanel.Fail();
            }
        }

    }
}
