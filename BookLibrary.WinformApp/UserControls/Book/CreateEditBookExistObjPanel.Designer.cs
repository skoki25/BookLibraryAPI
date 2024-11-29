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
            titlePanelCreate = new TitledPanel();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tbEanCode = new TextBox();
            tbIso = new TextBox();
            dtPublicationDate = new DateTimePicker();
            label3 = new Label();
            cbBookInfo = new ComboBox();
            label4 = new Label();
            titlePanelCreate.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanelCreate
            // 
            titlePanelCreate.BorderColor = Color.Black;
            titlePanelCreate.Controls.Add(button1);
            titlePanelCreate.Controls.Add(tableLayoutPanel2);
            titlePanelCreate.Controls.Add(tableLayoutPanel1);
            titlePanelCreate.Location = new Point(0, 0);
            titlePanelCreate.Name = "titlePanelCreate";
            titlePanelCreate.Size = new Size(934, 501);
            titlePanelCreate.TabIndex = 0;
            titlePanelCreate.TextAligns = TextAlign.Center;
            titlePanelCreate.Title = "Edit Book";
            titlePanelCreate.TitleBackColor = Color.LightGray;
            titlePanelCreate.TitleFont = new Font("Arial", 12F);
            titlePanelCreate.TitleForeColor = Color.Black;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(706, 426);
            button1.Name = "button1";
            button1.Size = new Size(202, 44);
            button1.TabIndex = 1;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtSaveBook;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.631579F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.68421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.68421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.68421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.68421F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.631579F));
            tableLayoutPanel2.Location = new Point(26, 335);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(882, 50);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(tbEanCode, 2, 0);
            tableLayoutPanel1.Controls.Add(tbIso, 2, 1);
            tableLayoutPanel1.Controls.Add(dtPublicationDate, 2, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 2);
            tableLayoutPanel1.Controls.Add(cbBookInfo, 2, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Location = new Point(26, 44);
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
            // cbBookInfo
            // 
            cbBookInfo.Anchor = AnchorStyles.Left;
            cbBookInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBookInfo.FormattingEnabled = true;
            cbBookInfo.Location = new Point(443, 185);
            cbBookInfo.Name = "cbBookInfo";
            cbBookInfo.Size = new Size(200, 23);
            cbBookInfo.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(379, 189);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "BookInfo:";
            // 
            // CreateEditBookPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanelCreate);
            Name = "CreateEditBookPanel";
            Size = new Size(934, 501);
            titlePanelCreate.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TitledPanel titlePanelCreate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox tbEanCode;
        private TextBox tbIso;
        private DateTimePicker dtPublicationDate;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private ComboBox cbBookInfo;
        private Label label4;
    }
}
