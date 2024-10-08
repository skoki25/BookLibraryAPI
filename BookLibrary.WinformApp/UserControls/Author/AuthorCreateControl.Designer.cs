namespace WinformApp.UserControls
{
    partial class AuthorCreateControl
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
            clnFirstName = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panelAuthor = new Panel();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clnFirstName, Column1 });
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(272, 623);
            dataGridView1.TabIndex = 9;
            // 
            // clnFirstName
            // 
            clnFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clnFirstName.HeaderText = "First Name";
            clnFirstName.MinimumWidth = 6;
            clnFirstName.Name = "clnFirstName";
            clnFirstName.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Last Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // panelAuthor
            // 
            panelAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelAuthor.Location = new Point(281, 4);
            panelAuthor.Margin = new Padding(3, 4, 3, 4);
            panelAuthor.Name = "panelAuthor";
            panelAuthor.Size = new Size(658, 623);
            panelAuthor.TabIndex = 10;
            // 
            // AuthorCreateControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panelAuthor);
            Name = "AuthorCreateControl";
            Size = new Size(942, 631);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panelAuthor;
        private DataGridViewTextBoxColumn clnFirstName;
        private DataGridViewTextBoxColumn Column1;
    }
}
