namespace WinformApp.UserControls
{
    partial class CreateEditAuthorPanel
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
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tbEanCode = new TextBox();
            tbIso = new TextBox();
            dtPublicationDate = new DateTimePicker();
            label3 = new Label();
            cbBookInfo = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            chbCreateNewAuthor = new CheckBox();
            btCreateEdit = new Button();
            titlePanelCreate.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanelCreate
            // 
            titlePanelCreate.BorderColor = Color.Black;
            titlePanelCreate.Controls.Add(button1);
            titlePanelCreate.Controls.Add(tableLayoutPanel1);
            titlePanelCreate.Dock = DockStyle.Fill;
            titlePanelCreate.Location = new Point(0, 0);
            titlePanelCreate.Margin = new Padding(3, 4, 3, 4);
            titlePanelCreate.Name = "titlePanelCreate";
            titlePanelCreate.Size = new Size(854, 752);
            titlePanelCreate.TabIndex = 1;
            titlePanelCreate.TextAligns = BookLibrary.WinformApp.Forms.Custom_Form_Item.TextAlign.Center;
            titlePanelCreate.Title = "Edit Author";
            titlePanelCreate.TitleBackColor = Color.LightGray;
            titlePanelCreate.TitleFont = new Font("Arial", 12F);
            titlePanelCreate.TitleForeColor = Color.Black;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(1461, 1220);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(231, 59);
            button1.TabIndex = 1;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(tbEanCode, 2, 1);
            tableLayoutPanel1.Controls.Add(tbIso, 2, 2);
            tableLayoutPanel1.Controls.Add(dtPublicationDate, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(cbBookInfo, 2, 4);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(comboBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(chbCreateNewAuthor, 1, 0);
            tableLayoutPanel1.Controls.Add(btCreateEdit, 2, 5);
            tableLayoutPanel1.Location = new Point(19, 55);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(817, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(324, 96);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "EAN Code:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(369, 167);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "ISO:";
            // 
            // tbEanCode
            // 
            tbEanCode.Anchor = AnchorStyles.Left;
            tbEanCode.Location = new Point(410, 93);
            tbEanCode.Margin = new Padding(3, 4, 3, 4);
            tbEanCode.Name = "tbEanCode";
            tbEanCode.Size = new Size(228, 27);
            tbEanCode.TabIndex = 2;
            // 
            // tbIso
            // 
            tbIso.Anchor = AnchorStyles.Left;
            tbIso.Location = new Point(410, 164);
            tbIso.Margin = new Padding(3, 4, 3, 4);
            tbIso.Name = "tbIso";
            tbIso.Size = new Size(228, 27);
            tbIso.TabIndex = 3;
            // 
            // dtPublicationDate
            // 
            dtPublicationDate.Anchor = AnchorStyles.Left;
            dtPublicationDate.Location = new Point(410, 235);
            dtPublicationDate.Margin = new Padding(3, 4, 3, 4);
            dtPublicationDate.Name = "dtPublicationDate";
            dtPublicationDate.Size = new Size(228, 27);
            dtPublicationDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(282, 238);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 5;
            label3.Text = "Publication Date:";
            // 
            // cbBookInfo
            // 
            cbBookInfo.Anchor = AnchorStyles.Left;
            cbBookInfo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBookInfo.FormattingEnabled = true;
            cbBookInfo.Location = new Point(410, 305);
            cbBookInfo.Margin = new Padding(3, 4, 3, 4);
            cbBookInfo.Name = "cbBookInfo";
            cbBookInfo.Size = new Size(228, 28);
            cbBookInfo.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(332, 309);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "BookInfo:";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(410, 21);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 28);
            comboBox2.TabIndex = 9;
            comboBox2.Visible = false;
            // 
            // chbCreateNewAuthor
            // 
            chbCreateNewAuthor.Anchor = AnchorStyles.Right;
            chbCreateNewAuthor.Appearance = Appearance.Button;
            chbCreateNewAuthor.AutoSize = true;
            chbCreateNewAuthor.Checked = true;
            chbCreateNewAuthor.CheckState = CheckState.Checked;
            chbCreateNewAuthor.Location = new Point(259, 20);
            chbCreateNewAuthor.Name = "chbCreateNewAuthor";
            chbCreateNewAuthor.Size = new Size(145, 30);
            chbCreateNewAuthor.TabIndex = 10;
            chbCreateNewAuthor.Text = "Create New Author";
            chbCreateNewAuthor.TextAlign = ContentAlignment.MiddleRight;
            chbCreateNewAuthor.TextImageRelation = TextImageRelation.TextBeforeImage;
            chbCreateNewAuthor.UseVisualStyleBackColor = true;
            chbCreateNewAuthor.Visible = false;
            // 
            // btCreateEdit
            // 
            btCreateEdit.Location = new Point(410, 359);
            btCreateEdit.Margin = new Padding(3, 4, 3, 4);
            btCreateEdit.Name = "btCreateEdit";
            btCreateEdit.Size = new Size(229, 64);
            btCreateEdit.TabIndex = 11;
            btCreateEdit.Text = "Create Author";
            btCreateEdit.UseVisualStyleBackColor = true;
            btCreateEdit.Click += btCreateEdit_Click;
            // 
            // CreateEditAuthorPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanelCreate);
            Name = "CreateEditAuthorPanel";
            Size = new Size(854, 752);
            titlePanelCreate.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BookLibrary.WinformApp.Forms.Custom_Form_Item.TitledPanel titlePanelCreate;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox tbEanCode;
        private TextBox tbIso;
        private DateTimePicker dtPublicationDate;
        private Label label3;
        private ComboBox cbBookInfo;
        private Label label4;
        private ComboBox comboBox2;
        private CheckBox chbCreateNewAuthor;
        private Button btCreateEdit;
    }
}
