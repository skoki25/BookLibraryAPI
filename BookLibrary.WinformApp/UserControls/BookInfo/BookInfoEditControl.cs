using BookLibrary.Models;
using BookLibrary.WinformApp;
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
    public partial class BookInfoEditControl : UserControl
    {

        private List<Category> _categories;
        private readonly MainViewModel _viewModel;

        public BookInfoEditControl(MainViewModel viewModel)
        {
            _viewModel = viewModel;

            InitializeComponent();
            FillDataGridView();
        }

        public async void FillDataGridView()
        {
            this.dataGridView1.Rows.Clear();
            _categories = await _viewModel.GetAllCategories();

            foreach (Category category in _categories)
            {
                CustomDataRow<Category> row = new CustomDataRow<Category>(this.dataGridView1, category);
                row.Add(category.Type, "Edit");
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row is CustomDataRow<Category> customDataRow)
            {
                panelCategory.Controls.Clear();
                CreateEditCategoryPanel createEditCategoryPanel = new CreateEditCategoryPanel(_viewModel, customDataRow.GetData());
                createEditCategoryPanel.Dock = DockStyle.Fill;
                createEditCategoryPanel.OnEdit += FillDataGridView;
                panelCategory.Controls.Add(createEditCategoryPanel);
                createEditCategoryPanel.Dock = DockStyle.Fill;
            }
        }
    }
}
