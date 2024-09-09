using WinformApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary.WinformApp.Forms.UserControlComponents.Controls.Book
{
    public partial class BookCreateControl : UserControl
    {
        private MainViewModel _viewModel;
        public BookCreateControl(MainViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            createEditBookPanel1.Create(viewModel);
        }
    }
}
