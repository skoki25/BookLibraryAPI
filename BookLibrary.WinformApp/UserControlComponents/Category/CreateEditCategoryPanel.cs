using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary.Models;
using WinformApp;
using WinformApp.Forms;

namespace BookLibrary.WinformApp.UserControlComponents
{
    public partial class CreateEditCategoryPanel : UserControl
    {
        private readonly MainViewModel _viewModel;
        public event Action OnEdit;
        private Category _category;
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
        }
    }
}
