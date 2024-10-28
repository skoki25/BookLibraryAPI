namespace WinformApp
{
    partial class CreateEditBookInfoExistObjPanel
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
            btCreateEdit = new Button();
            tbEanCode = new TextBox();
            lbCatTypeDes = new Label();
            chbCreateNewAuthor = new CheckBox();
            titlePanelCreate = new TitledPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tbTitle = new TextBox();
            lbTitle = new Label();
            cbAuthor = new ComboBox();
            btEditBookInfo = new Button();
            tbDescription = new TextBox();
            lbDescription = new Label();
            lbDesAuthor = new Label();
            lbDesCategory = new Label();
            cbCategory = new ComboBox();
            titlePanelCreate.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btCreateEdit
            // 
            btCreateEdit.Location = new Point(294, 122);
            btCreateEdit.Margin = new Padding(3, 4, 3, 4);
            btCreateEdit.Name = "btCreateEdit";
            btCreateEdit.Size = new Size(229, 51);
            btCreateEdit.TabIndex = 3;
            btCreateEdit.Text = "Create Category";
            btCreateEdit.UseVisualStyleBackColor = true;
            btCreateEdit.Click += btCreateEdit_Click;
            // 
            // tbEanCode
            // 
            tbEanCode.Anchor = AnchorStyles.Left;
            tbEanCode.Location = new Point(294, 75);
            tbEanCode.Margin = new Padding(3, 4, 3, 4);
            tbEanCode.Name = "tbEanCode";
            tbEanCode.Size = new Size(228, 27);
            tbEanCode.TabIndex = 2;
            // 
            // lbCatTypeDes
            // 
            lbCatTypeDes.Anchor = AnchorStyles.Right;
            lbCatTypeDes.AutoSize = true;
            lbCatTypeDes.Location = new Point(208, 78);
            lbCatTypeDes.Name = "lbCatTypeDes";
            lbCatTypeDes.Size = new Size(80, 20);
            lbCatTypeDes.TabIndex = 0;
            lbCatTypeDes.Text = "EAN Code:";
            // 
            // chbCreateNewAuthor
            // 
            chbCreateNewAuthor.Anchor = AnchorStyles.Right;
            chbCreateNewAuthor.Appearance = Appearance.Button;
            chbCreateNewAuthor.AutoSize = true;
            chbCreateNewAuthor.Checked = true;
            chbCreateNewAuthor.CheckState = CheckState.Checked;
            chbCreateNewAuthor.Location = new Point(128, 14);
            chbCreateNewAuthor.Name = "chbCreateNewAuthor";
            chbCreateNewAuthor.Size = new Size(160, 30);
            chbCreateNewAuthor.TabIndex = 11;
            chbCreateNewAuthor.Text = "Create New Category";
            chbCreateNewAuthor.TextAlign = ContentAlignment.MiddleRight;
            chbCreateNewAuthor.TextImageRelation = TextImageRelation.TextBeforeImage;
            chbCreateNewAuthor.UseVisualStyleBackColor = true;
            chbCreateNewAuthor.Visible = false;
            // 
            // titlePanelCreate
            // 
            titlePanelCreate.BorderColor = Color.Black;
            titlePanelCreate.Controls.Add(tableLayoutPanel2);
            titlePanelCreate.Dock = DockStyle.Fill;
            titlePanelCreate.Location = new Point(0, 0);
            titlePanelCreate.Margin = new Padding(3, 4, 3, 4);
            titlePanelCreate.Name = "titlePanelCreate";
            titlePanelCreate.Size = new Size(756, 705);
            titlePanelCreate.TabIndex = 2;
            titlePanelCreate.TextAligns = TextAlign.Center;
            titlePanelCreate.Title = "Edit Book Info";
            titlePanelCreate.TitleBackColor = Color.LightGray;
            titlePanelCreate.TitleFont = new Font("Arial", 12F);
            titlePanelCreate.TitleForeColor = Color.Black;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Controls.Add(tbTitle, 2, 2);
            tableLayoutPanel2.Controls.Add(lbTitle, 1, 2);
            tableLayoutPanel2.Controls.Add(cbAuthor, 2, 0);
            tableLayoutPanel2.Controls.Add(btEditBookInfo, 2, 4);
            tableLayoutPanel2.Controls.Add(tbDescription, 2, 3);
            tableLayoutPanel2.Controls.Add(lbDescription, 1, 3);
            tableLayoutPanel2.Controls.Add(lbDesAuthor, 1, 0);
            tableLayoutPanel2.Controls.Add(lbDesCategory, 1, 1);
            tableLayoutPanel2.Controls.Add(cbCategory, 2, 1);
            tableLayoutPanel2.Location = new Point(6, 60);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(747, 453);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Left;
            tbTitle.Location = new Point(376, 211);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(228, 27);
            tbTitle.TabIndex = 2;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.Right;
            lbTitle.AutoSize = true;
            lbTitle.Location = new Point(329, 215);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(41, 20);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Title:";
            // 
            // cbAuthor
            // 
            cbAuthor.Anchor = AnchorStyles.Left;
            cbAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(376, 31);
            cbAuthor.Margin = new Padding(3, 4, 3, 4);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(228, 28);
            cbAuthor.TabIndex = 10;
            // 
            // btEditBookInfo
            // 
            btEditBookInfo.Location = new Point(376, 364);
            btEditBookInfo.Margin = new Padding(3, 4, 3, 4);
            btEditBookInfo.Name = "btEditBookInfo";
            btEditBookInfo.Size = new Size(229, 64);
            btEditBookInfo.TabIndex = 3;
            btEditBookInfo.Text = "Edit BookInfo";
            btEditBookInfo.UseVisualStyleBackColor = true;
            btEditBookInfo.Click += btEditBookInfo_Click;
            // 
            // tbDescription
            // 
            tbDescription.Anchor = AnchorStyles.Left;
            tbDescription.Location = new Point(376, 301);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(228, 27);
            tbDescription.TabIndex = 12;
            // 
            // lbDescription
            // 
            lbDescription.Anchor = AnchorStyles.Right;
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(282, 305);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(88, 20);
            lbDescription.TabIndex = 13;
            lbDescription.Text = "Description:";
            // 
            // lbDesAuthor
            // 
            lbDesAuthor.Anchor = AnchorStyles.Right;
            lbDesAuthor.AutoSize = true;
            lbDesAuthor.Location = new Point(313, 35);
            lbDesAuthor.Name = "lbDesAuthor";
            lbDesAuthor.Size = new Size(57, 20);
            lbDesAuthor.TabIndex = 14;
            lbDesAuthor.Text = "Author:";
            // 
            // lbDesCategory
            // 
            lbDesCategory.Anchor = AnchorStyles.Right;
            lbDesCategory.AutoSize = true;
            lbDesCategory.Location = new Point(298, 125);
            lbDesCategory.Name = "lbDesCategory";
            lbDesCategory.Size = new Size(72, 20);
            lbDesCategory.TabIndex = 15;
            lbDesCategory.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Left;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(376, 121);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(228, 28);
            cbCategory.TabIndex = 16;
            // 
            // CreateEditBookInfoExistObjPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanelCreate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateEditBookInfoExistObjPanel";
            Size = new Size(756, 705);
            titlePanelCreate.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btCreateEdit;
        private TextBox tbEanCode;
        private Label lbCatTypeDes;
        private CheckBox chbCreateNewAuthor;
        private TitledPanel titlePanelCreate;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbTitle;
        private Label lbTitle;
        private ComboBox cbAuthor;
        private Button btEditBookInfo;
        private TextBox tbDescription;
        private Label lbDescription;
        private Label lbDesAuthor;
        private Label lbDesCategory;
        private ComboBox cbCategory;
    }
}
