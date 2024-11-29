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

namespace WinformApp.Forms.UserControlComponents
{
    public partial class BookInfoEditControl : UserControl
    {

        private List<BookInfo> _bookInfos;
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
            _bookInfos = await _viewModel.GetAllBookInfo();

            foreach (BookInfo bookInfo in _bookInfos)
            {
                CustomDataRow<BookInfo> row = new CustomDataRow<BookInfo>(this.dataGridView1, bookInfo);
                row.Add(bookInfo.Title, "Edit");
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row is CustomDataRow<BookInfo> customDataRow)
            {
                panelCategory.Controls.Clear();
                CreateEditBookInfoExistObjPanel createEditCategoryPanel = new CreateEditBookInfoExistObjPanel(_viewModel, customDataRow.GetData());
                createEditCategoryPanel.FillDock();
                createEditCategoryPanel.OnEdit += FillDataGridView;
                panelCategory.Controls.Add(createEditCategoryPanel);
            }
        }
    }
}
