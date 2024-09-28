namespace WinformApp.Forms.UserControlComponents.Controls
{
    partial class BookBorrowHistoryControl
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
            BookNameColumn = new DataGridViewTextBoxColumn();
            BorrowDateColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookNameColumn, BorrowDateColumn });
            dataGridView1.Location = new Point(3, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(884, 341);
            dataGridView1.TabIndex = 0;
            // 
            // BookNameColumn
            // 
            BookNameColumn.HeaderText = "Book";
            BookNameColumn.Name = "BookNameColumn";
            // 
            // BorrowDateColumn
            // 
            BorrowDateColumn.HeaderText = "Borrow Date";
            BorrowDateColumn.Name = "BorrowDateColumn";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 17);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(884, 55);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.Location = new Point(324, 0);
            label4.Name = "label4";
            label4.Size = new Size(234, 45);
            label4.TabIndex = 1;
            label4.Text = "Bottow History";
            // 
            // BookBorrowHistoryControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Name = "BookBorrowHistoryControl";
            Size = new Size(890, 435);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookNameColumn;
        private DataGridViewTextBoxColumn BorrowDateColumn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
    }
}
