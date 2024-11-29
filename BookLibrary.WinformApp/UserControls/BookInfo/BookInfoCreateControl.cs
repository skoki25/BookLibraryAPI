using BookLibrary.Models;
using BookLibrary.WinformApp;
using WinformApp.Installation;

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
            CreateEditCategoryPanel createEditCategoryPanel = new CreateEditCategoryPanel(_viewModel, true);
            createEditCategoryPanel.FillDock();
            panelContent.Controls.Add(createEditCategoryPanel);
            createEditCategoryPanel.FillDock();
        }

        private void btCategory_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CreateEditCategoryPanel createEditCategoryPanel = new CreateEditCategoryPanel(_viewModel, true);
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
            UnlockBookInfoButton();
        }

        private void btBookInfo_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CreateEditBookInfoPanel createEditCategoryPanel = 
                new CreateEditBookInfoPanel(_viewModel, _category.Id, _author.Id);

            //createEditCategoryPanel.OnSaveAction += OnSaveAuthor;
            createEditCategoryPanel.FillDock();

            panelContent.Controls.Add(createEditCategoryPanel);
            btBookInfo.Enabled = false;

        }

        public void OnSaveAuthor(Author author)
        {
            dataGridView1.Rows.Add(nameof(Author),author.FullName, "Remove");
            _author = author;

            btAuthor.Enabled = false;
            UnlockBookInfoButton();
        }

        public void OnSaveCategory(Category category)
        {
            dataGridView1.Rows.Add(nameof(Category),category.Type, "Remove");
            _category = category;
            btCategory.Enabled = false;
            UnlockBookInfoButton();
        }

        private void UnlockBookInfoButton()
        {
            if (_category == null)
                return;
            if (_author == null)
                return;

            btBookInfo.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //if (sender is not DataGridViewButtonColumn)
            //    return;

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string typeName = row.Cells[0].Value.ToString();

            if (typeName.Equals(nameof(Author)))
            {
                btAuthor.Enabled = true;
                btBookInfo.Enabled = false;
                _author = null;
                this.dataGridView1.Rows.Remove(row);
            }
            else if (typeName.Equals(nameof(Category)))
            {
                btCategory.Enabled = true;
                btBookInfo.Enabled = false;
                _category = null;
                this.dataGridView1.Rows.Remove(row);
            }
        }
    }
}
