namespace WinformApp.Forms.UserControlComponents.Controls.Category
{
    partial class CategoryEditControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBook = new Panel();
            dataGridView1 = new DataGridView();
            TypeColumn = new DataGridViewTextBoxColumn();
            DetailColumn = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelBook
            // 
            panelBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBook.Location = new Point(193, 3);
            panelBook.Name = "panelBook";
            panelBook.Size = new Size(581, 444);
            panelBook.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TypeColumn, DetailColumn });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(184, 444);
            dataGridView1.TabIndex = 5;
            // 
            // TypeColumn
            // 
            TypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            TypeColumn.HeaderText = "Type";
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            TypeColumn.Width = 56;
            // 
            // DetailColumn
            // 
            DetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DetailColumn.HeaderText = "Detail";
            DetailColumn.Name = "DetailColumn";
            DetailColumn.Resizable = DataGridViewTriState.False;
            DetailColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DetailColumn.Width = 62;
            // 
            // CategoryEditControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelBook);
            Name = "CategoryEditControl";
            Size = new Size(777, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBook;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewButtonColumn DetailColumn;
    }
}
