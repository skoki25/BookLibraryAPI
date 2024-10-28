namespace WinformApp
{
    partial class CreateEditCategoryPanel
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btCreateEdit = new Button();
            tbEanCode = new TextBox();
            lbCatTypeDes = new Label();
            cbCategory = new ComboBox();
            chbCreateNewAuthor = new CheckBox();
            titlePanelCreate.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanelCreate
            // 
            titlePanelCreate.BorderColor = Color.Black;
            titlePanelCreate.Controls.Add(tableLayoutPanel1);
            titlePanelCreate.Dock = DockStyle.Fill;
            titlePanelCreate.Location = new Point(0, 0);
            titlePanelCreate.Margin = new Padding(3, 4, 3, 4);
            titlePanelCreate.Name = "titlePanelCreate";
            titlePanelCreate.Size = new Size(608, 705);
            titlePanelCreate.TabIndex = 1;
            titlePanelCreate.TextAligns = TextAlign.Center;
            titlePanelCreate.Title = "Create Category";
            titlePanelCreate.TitleBackColor = Color.LightGray;
            titlePanelCreate.TitleFont = new Font("Arial", 12F);
            titlePanelCreate.TitleForeColor = Color.Black;
            titlePanelCreate.Paint += titlePanelCreate_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(btCreateEdit, 2, 2);
            tableLayoutPanel1.Controls.Add(tbEanCode, 2, 1);
            tableLayoutPanel1.Controls.Add(lbCatTypeDes, 1, 1);
            tableLayoutPanel1.Controls.Add(cbCategory, 2, 0);
            tableLayoutPanel1.Controls.Add(chbCreateNewAuthor, 1, 0);
            tableLayoutPanel1.Location = new Point(10, 89);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(584, 237);
            tableLayoutPanel1.TabIndex = 0;
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
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Left;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(294, 15);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(228, 28);
            cbCategory.TabIndex = 10;
            cbCategory.Visible = false;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
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
            chbCreateNewAuthor.CheckedChanged += chbCreateCategory_CheckedChanged;
            // 
            // CreateEditCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanelCreate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateEditCategoryPanel";
            Size = new Size(608, 705);
            titlePanelCreate.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TitledPanel titlePanelCreate;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btCreateEdit;
        private TextBox tbEanCode;
        private Label lbCatTypeDes;
        private ComboBox cbCategory;
        private CheckBox chbCreateNewAuthor;
    }
}
