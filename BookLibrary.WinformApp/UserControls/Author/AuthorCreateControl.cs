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
using WinformApp.Installation;

namespace WinformApp.UserControls
{
    public partial class AuthorCreateControl : UserControl
    {
        private readonly MainViewModel _viewModel;
        public AuthorCreateControl(MainViewModel vieModel)
        {
            _viewModel = vieModel;

            InitializeComponent();

            CreateEditAuthorPanel createEditAuthorPanel = new CreateEditAuthorPanel(_viewModel);
            createEditAuthorPanel.OnEdit += FillDatagrid;
            createEditAuthorPanel.FillDock();
            panelAuthor.Controls.Add(createEditAuthorPanel);

            FillDatagrid();

        }

        public async void FillDatagrid()
        {
            dataGridView1.Rows.Clear();
            List<Author> authors = await _viewModel.GetAllAuthors();

            foreach(var author in authors)
            {
                dataGridView1.Rows.Add(author.FirstName, author.LastName);
            }
        }
    }
}
