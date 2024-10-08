using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class CategoryViewControl : UserControl
    {
        private List<Category> categoryList;
        private MainViewModel _viewModel;
        public CategoryViewControl(MainViewModel viewModel)
        {
            _viewModel = viewModel;

            InitializeComponent();
            FillDataGrid();
        }

        public async void FillDataGrid()
        {
            List<Category> categoryList = await _viewModel.GetAllCategoriesWithBooks();

            foreach (Category category in categoryList)
            {
                int count = category.BookInfo?.Count() ?? 0;
                this.dataGridView1.Rows.Add(category.Type, count);
            }
        }
    }
}
