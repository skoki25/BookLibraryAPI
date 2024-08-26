namespace LibraryWindowsApp.Forms.UserControlComponents.Controls
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(657, 66);
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
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            Name = "BookControl";
            Size = new Size(993, 419);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
    }
}
