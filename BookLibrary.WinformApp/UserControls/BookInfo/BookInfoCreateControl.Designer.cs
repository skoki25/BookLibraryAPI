namespace WinformApp.Forms.UserControlComponents
{
    partial class BookInfoCreateControl
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            panelContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btBookInfo = new Button();
            btAuthor = new Button();
            btCategory = new Button();
            dataGridView1 = new DataGridView();
            TypeColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.Location = new Point(70, 0);
            label4.Name = "label4";
            label4.Size = new Size(58, 225);
            label4.TabIndex = 1;
            label4.Text = "User Profile";
            // 
            // panelContent
            // 
            panelContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContent.Location = new Point(332, 4);
            panelContent.Margin = new Padding(3, 4, 3, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(592, 568);
            panelContent.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btBookInfo, 2, 0);
            tableLayoutPanel1.Controls.Add(btAuthor, 1, 0);
            tableLayoutPanel1.Controls.Add(btCategory, 0, 0);
            tableLayoutPanel1.Location = new Point(332, 592);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(592, 76);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // btBookInfo
            // 
            btBookInfo.Enabled = false;
            btBookInfo.Location = new Point(397, 4);
            btBookInfo.Margin = new Padding(3, 4, 3, 4);
            btBookInfo.Name = "btBookInfo";
            btBookInfo.Size = new Size(165, 64);
            btBookInfo.TabIndex = 12;
            btBookInfo.Text = "BookInfo";
            btBookInfo.UseVisualStyleBackColor = true;
            btBookInfo.Click += btBookInfo_Click;
            // 
            // btAuthor
            // 
            btAuthor.Location = new Point(200, 4);
            btAuthor.Margin = new Padding(3, 4, 3, 4);
            btAuthor.Name = "btAuthor";
            btAuthor.Size = new Size(165, 64);
            btAuthor.TabIndex = 11;
            btAuthor.Text = "Author";
            btAuthor.UseVisualStyleBackColor = true;
            btAuthor.Click += btAuthor_Click;
            // 
            // btCategory
            // 
            btCategory.Location = new Point(3, 4);
            btCategory.Margin = new Padding(3, 4, 3, 4);
            btCategory.Name = "btCategory";
            btCategory.Size = new Size(178, 64);
            btCategory.TabIndex = 10;
            btCategory.Text = "Category";
            btCategory.UseVisualStyleBackColor = true;
            btCategory.Click += btCategory_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TypeColumn, Column1, Column2 });
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(323, 682);
            dataGridView1.TabIndex = 7;
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
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.FillWeight = 60F;
            Column2.HeaderText = "Remove";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 80;
            // 
            // BookInfoCreateControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(panelContent);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookInfoCreateControl";
            Size = new Size(927, 690);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Panel panelContent;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btCategory;
        private Button btBookInfo;
        private Button btAuthor;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn Column2;
    }
}
