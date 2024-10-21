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
using WinformApp.Installation;
using WinformApp.UserControls;

namespace WinformApp.Forms.UserControlComponents
{
    public partial class BookInfoCreateControl : UserControl
    {
        private readonly MainViewModel _viewModel;
        private List<BookInfo> _bookInfos;
        private Author _author = new Author();
        private Category _category;

        public BookInfoCreateControl(MainViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;

            panelContent.Controls.Clear();
            CreateEditCategoryPanel createEditCategoryPanel = new CreateEditCategoryPanel(_viewModel);
            createEditCategoryPanel.Dock = DockStyle.Fill;
            createEditCategoryPanel.OnEdit += FillDataGridView;
            panelContent.Controls.Add(createEditCategoryPanel);
            createEditCategoryPanel.FillDock();
            FillDataGridView();
        }

        public async void FillDataGridView()
        {
            this.dataGridView1.Rows.Clear();
            _bookInfos = await _viewModel.GetAllBookInfo();

            foreach (BookInfo category in _bookInfos)
            {
                CustomDataRow<BookInfo> row = new CustomDataRow<BookInfo>(this.dataGridView1, category);
                //row.Add(category.Type);
                this.dataGridView1.Rows.Add(row);
            }
        }
        private void btBookInfo_Click(object sender, EventArgs e)
        {

        }

        private void btCategory_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CreateEditCategoryPanel createEditCategoryPanel = new CreateEditCategoryPanel(_viewModel);
            createEditCategoryPanel.OnSaveAction += OnSaveCategory;
            createEditCategoryPanel.FillDock();

            panelContent.Controls.Add(createEditCategoryPanel);
        }

        private void btAuthor_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CreateEditAuthorPanel createEditCategoryPanel = new
            CreateEditAuthorPanel(_viewModel, _author, true);

            createEditCategoryPanel.OnSaveAction += OnSaveAuthor;
            createEditCategoryPanel.FillDock();

            panelContent.Controls.Add(createEditCategoryPanel);
        }

        public void OnSaveAuthor(Author author)
        {
            _author = author;
        }

        public void OnSaveCategory(Category category)
        {
            _category = category;
        }

    }
}
