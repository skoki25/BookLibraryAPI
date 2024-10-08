using BookLibrary.Models;
using BookLibrary.WinformApp.UserControlComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformApp.Forms.UserControlComponents.CustomObject;

namespace WinformApp.Forms.UserControlComponents
{
    public partial class CategoryCreateControl : UserControl
    {
        private readonly MainViewModel _viewModel;
        private List<Category> _categories;
        public CategoryCreateControl(MainViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            panelCategory.Controls.Clear();
            CreateEditCategoryPanel createEditCategoryPanel = new CreateEditCategoryPanel(_viewModel);
            createEditCategoryPanel.Dock = DockStyle.Fill;
            createEditCategoryPanel.OnEdit += FillDataGridView;
            panelCategory.Controls.Add(createEditCategoryPanel);
            createEditCategoryPanel.Dock = DockStyle.Fill;
            FillDataGridView();
        }

        public async void FillDataGridView()
        {
            this.dataGridView1.Rows.Clear();
            _categories = await _viewModel.GetAllCategories();

            foreach (Category category in _categories)
            {
                CustomDataRow<Category> row = new CustomDataRow<Category>(this.dataGridView1, category);
                row.Add(category.Type);
                this.dataGridView1.Rows.Add(row);
            }
        }
    }
}
