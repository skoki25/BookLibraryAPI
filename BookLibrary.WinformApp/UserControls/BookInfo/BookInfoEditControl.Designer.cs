namespace WinformApp.Forms.UserControlComponents
{
    partial class BookInfoEditControl
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
            dataGridView1 = new DataGridView();
            TypeColumn = new DataGridViewTextBoxColumn();
            DetailColumn = new DataGridViewButtonColumn();
            panelCategory = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(256, 627);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TypeColumn
            // 
            TypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TypeColumn.HeaderText = "Type";
            TypeColumn.MinimumWidth = 6;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            // 
            // DetailColumn
            // 
            DetailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DetailColumn.HeaderText = "Detail";
            DetailColumn.MinimumWidth = 6;
            DetailColumn.Name = "DetailColumn";
            DetailColumn.Resizable = DataGridViewTriState.False;
            DetailColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // panelCategory
            // 
            panelCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCategory.Location = new Point(265, 4);
            panelCategory.Margin = new Padding(3, 4, 3, 4);
            panelCategory.Name = "panelCategory";
            panelCategory.Size = new Size(641, 627);
            panelCategory.TabIndex = 6;
            // 
            // CategoryEditControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelCategory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CategoryEditControl";
            Size = new Size(911, 635);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panelCategory;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewButtonColumn DetailColumn;
    }
}
