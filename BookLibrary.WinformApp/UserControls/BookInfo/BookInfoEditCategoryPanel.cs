using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents.Waiting;
using WinformApp;
using WinformApp.Forms;

namespace BookLibrary.WinformApp
{
    public partial class BookInfoEditCategoryPanel : UserControl
    {
        private readonly MainViewModel _viewModel;
        public event Action OnEdit;
        private Category _category;
        ModeType modeType;

        public BookInfoEditCategoryPanel(MainViewModel mainViewModel)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _category = new Category();
            modeType = ModeType.Create;
            Setup();
        }

        public BookInfoEditCategoryPanel(MainViewModel mainViewModel, Category category)
        {
            InitializeComponent();

            _viewModel = mainViewModel;
            _category = category;
            modeType = ModeType.Edit;

            Setup();
        }

        private void Setup()
        {
            tbEanCode.DataBindings.Add(new Binding(nameof(tbEanCode.Text), _category, nameof(Category.Type)));
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
                        await _viewModel.CreateCategory(_category);
                        break;
                    case ModeType.Edit:
                        await _viewModel.EditCategory(_category);
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
