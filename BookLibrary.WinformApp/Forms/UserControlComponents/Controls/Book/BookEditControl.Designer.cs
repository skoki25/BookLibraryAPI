namespace WinformApp.Forms.UserControlComponents
{
    partial class BookEditControl
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
            createEditBookPanel1 = new CreateEditBookPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            ISOColumn = new DataGridViewTextBoxColumn();
            EanColumn = new DataGridViewTextBoxColumn();
            NemeColumn = new DataGridViewTextBoxColumn();
            DetailColumn = new DataGridViewButtonColumn();
            panelBook = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelBook.SuspendLayout();
            SuspendLayout();
            // 
            // createEditBookPanel1
            // 
            createEditBookPanel1.Location = new Point(3, 3);
            createEditBookPanel1.Name = "createEditBookPanel1";
            createEditBookPanel1.Size = new Size(693, 395);
            createEditBookPanel1.TabIndex = 0;
            createEditBookPanel1.Load += createEditBookPanel1_Load;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Location = new Point(416, 466);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(576, 51);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ISOColumn, EanColumn, NemeColumn, DetailColumn });
            dataGridView1.Location = new Point(3, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(324, 503);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ISOColumn
            // 
            ISOColumn.FillWeight = 60F;
            ISOColumn.HeaderText = "ISO";
            ISOColumn.Name = "ISOColumn";
            ISOColumn.ReadOnly = true;
            ISOColumn.Width = 60;
            // 
            // EanColumn
            // 
            EanColumn.HeaderText = "Ean";
            EanColumn.Name = "EanColumn";
            EanColumn.ReadOnly = true;
            EanColumn.Width = 60;
            // 
            // NemeColumn
            // 
            NemeColumn.HeaderText = "Name";
            NemeColumn.Name = "NemeColumn";
            NemeColumn.ReadOnly = true;
            NemeColumn.Width = 120;
            // 
            // DetailColumn
            // 
            DetailColumn.HeaderText = "Detail";
            DetailColumn.Name = "DetailColumn";
            DetailColumn.Resizable = DataGridViewTriState.False;
            DetailColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DetailColumn.Width = 80;
            // 
            // panelBook
            // 
            panelBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBook.Controls.Add(createEditBookPanel1);
            panelBook.Location = new Point(333, 14);
            panelBook.Name = "panelBook";
            panelBook.Size = new Size(710, 446);
            panelBook.TabIndex = 4;
            // 
            // BookEditControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBook);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Name = "BookEditControl";
            Size = new Size(1046, 534);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelBook.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CreateEditBookPanel createEditBookPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ISOColumn;
        private DataGridViewTextBoxColumn EanColumn;
        private DataGridViewTextBoxColumn NemeColumn;
        private DataGridViewButtonColumn DetailColumn;
        private Panel panelBook;
    }
}
