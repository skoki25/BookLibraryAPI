using BookLibrary.Models;
using BookLibrary.WinformApp;
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

namespace WinformApp.UserControls
{
    public partial class AuthorEditControl : UserControl
    {
        readonly private MainViewModel _viewModel;
        private List<Author> _authors;

        public AuthorEditControl(MainViewModel viewModel)
        {
            _viewModel = viewModel;

            InitializeComponent();
            FillDataGridView();
        }



        public async void FillDataGridView()
        {
            this.dataGridView1.Rows.Clear();
            _authors = await _viewModel.GetAllAuthors();

            foreach (Author author in _authors)
            {
                CustomDataRow<Author> row = new CustomDataRow<Author>(this.dataGridView1, author);
                row.Add(author.FirstName,author.LastName, "Edit");
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (row is CustomDataRow<Author> customDataRow)
            {
                panelBook.Controls.Clear();
                CreateEditAuthorPanel createEditCategoryPanel = new CreateEditAuthorPanel(_viewModel, customDataRow.GetData());
                createEditCategoryPanel.FillDock();
                createEditCategoryPanel.OnEdit += FillDataGridView;
                panelBook.Controls.Add(createEditCategoryPanel);
            }
        }
    }
}
