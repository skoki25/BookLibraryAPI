namespace LibraryWindowsApp.Forms.UserControlComponents
{
    partial class BookControl
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            dataGridView1 = new DataGridView();
            ISOColumn = new DataGridViewTextBoxColumn();
            EanColumn = new DataGridViewTextBoxColumn();
            NemeColumn = new DataGridViewTextBoxColumn();
            DetailColumn = new DataGridViewButtonColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            lbDescription = new Label();
            lbUsername = new Label();
            label1 = new Label();
            label2 = new Label();
            lbAuthor = new Label();
            label5 = new Label();
            label6 = new Label();
            lbCategory = new Label();
            lbISO = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
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
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(324, 413);
            dataGridView1.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Location = new Point(333, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(657, 51);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.Location = new Point(234, 0);
            label4.Name = "label4";
            label4.Size = new Size(188, 45);
            label4.TabIndex = 2;
            label4.Text = "Book Detail";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(lbUsername, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(lbAuthor, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(lbDescription, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(lbCategory, 1, 3);
            tableLayoutPanel2.Controls.Add(lbISO, 1, 4);
            tableLayoutPanel2.Location = new Point(333, 60);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0007973F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0007973F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0008011F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9988022F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9988022F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(657, 295);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(259, 140);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 7;
            label3.Text = "Desciption:";
            // 
            // lbDescription
            // 
            lbDescription.Anchor = AnchorStyles.Left;
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(331, 140);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(55, 15);
            lbDescription.TabIndex = 8;
            lbDescription.Text = "                ";
            // 
            // lbUsername
            // 
            lbUsername.Anchor = AnchorStyles.Left;
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(331, 22);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(82, 15);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "                         ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(263, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Title:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(278, 81);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Author:";
            // 
            // lbAuthor
            // 
            lbAuthor.Anchor = AnchorStyles.Left;
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(331, 81);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(70, 15);
            lbAuthor.TabIndex = 6;
            lbAuthor.Text = "                     ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(267, 198);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Category:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(297, 257);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 10;
            label6.Text = "ISO:";
            // 
            // lbCategory
            // 
            lbCategory.Anchor = AnchorStyles.Left;
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(331, 198);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 11;
            lbCategory.Text = "                ";
            // 
            // lbISO
            // 
            lbISO.Anchor = AnchorStyles.Left;
            lbISO.AutoSize = true;
            lbISO.Location = new Point(331, 257);
            lbISO.Name = "lbISO";
            lbISO.Size = new Size(55, 15);
            lbISO.TabIndex = 12;
            lbISO.Text = "                ";
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "BookControl";
            Size = new Size(993, 419);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ISOColumn;
        private DataGridViewTextBoxColumn EanColumn;
        private DataGridViewTextBoxColumn NemeColumn;
        private DataGridViewButtonColumn DetailColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label lbDescription;
        private Label lbUsername;
        private Label label1;
        private Label label2;
        private Label lbAuthor;
        private Label label6;
        private Label label5;
        private Label lbCategory;
        private Label lbISO;
    }
}
