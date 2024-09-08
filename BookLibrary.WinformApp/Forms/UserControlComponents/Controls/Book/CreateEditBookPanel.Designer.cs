namespace WinformApp.Forms.UserControlComponents
{
    partial class CreateEditBookPanel
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
            titlePanelCreate = new BookLibrary.WinformApp.Forms.Custom_Form_Item.TitledPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tbEanCode = new TextBox();
            tbIso = new TextBox();
            dtPublicationDate = new DateTimePicker();
            label3 = new Label();
            titlePanelCreate.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanelCreate
            // 
            titlePanelCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titlePanelCreate.BorderColor = Color.Black;
            titlePanelCreate.Controls.Add(tableLayoutPanel1);
            titlePanelCreate.Location = new Point(14, 3);
            titlePanelCreate.Name = "titlePanelCreate";
            titlePanelCreate.Size = new Size(910, 484);
            titlePanelCreate.TabIndex = 0;
            titlePanelCreate.TextAligns = BookLibrary.WinformApp.Forms.Custom_Form_Item.TextAlign.Center;
            titlePanelCreate.Title = "Edit Book";
            titlePanelCreate.TitleBackColor = Color.LightGray;
            titlePanelCreate.TitleFont = new Font("Arial", 12F);
            titlePanelCreate.TitleForeColor = Color.Black;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(tbEanCode, 2, 0);
            tableLayoutPanel1.Controls.Add(tbIso, 2, 1);
            tableLayoutPanel1.Controls.Add(dtPublicationDate, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Location = new Point(14, 44);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(882, 226);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(373, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "EAN Code:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(409, 76);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "ISO:";
            // 
            // tbEanCode
            // 
            tbEanCode.Anchor = AnchorStyles.Left;
            tbEanCode.Location = new Point(443, 16);
            tbEanCode.Name = "tbEanCode";
            tbEanCode.Size = new Size(200, 23);
            tbEanCode.TabIndex = 2;
            // 
            // tbIso
            // 
            tbIso.Anchor = AnchorStyles.Left;
            tbIso.Location = new Point(443, 72);
            tbIso.Name = "tbIso";
            tbIso.Size = new Size(200, 23);
            tbIso.TabIndex = 3;
            // 
            // dtPublicationDate
            // 
            dtPublicationDate.Anchor = AnchorStyles.Left;
            dtPublicationDate.Location = new Point(443, 128);
            dtPublicationDate.Name = "dtPublicationDate";
            dtPublicationDate.Size = new Size(200, 23);
            dtPublicationDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(340, 132);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Publication Date:";
            // 
            // CreateEditBookPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanelCreate);
            Name = "CreateEditBookPanel";
            Size = new Size(936, 505);
            titlePanelCreate.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BookLibrary.WinformApp.Forms.Custom_Form_Item.TitledPanel titlePanelCreate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox tbEanCode;
        private TextBox tbIso;
        private DateTimePicker dtPublicationDate;
        private Label label3;
    }
}
