namespace BookLibrary.WinformApp
{
    partial class BookInfoEditCategoryPanel
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
            titlePanelCreate = new Forms.Custom_Form_Item.TitledPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbCatTypeDes = new Label();
            tbEanCode = new TextBox();
            btCreateEdit = new Button();
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
            titlePanelCreate.Size = new Size(950, 705);
            titlePanelCreate.TabIndex = 1;
            titlePanelCreate.TextAligns = Forms.Custom_Form_Item.TextAlign.Center;
            titlePanelCreate.Title = "Create Category";
            titlePanelCreate.TitleBackColor = Color.LightGray;
            titlePanelCreate.TitleFont = new Font("Arial", 12F);
            titlePanelCreate.TitleForeColor = Color.Black;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(lbCatTypeDes, 1, 0);
            tableLayoutPanel1.Controls.Add(tbEanCode, 2, 0);
            tableLayoutPanel1.Controls.Add(btCreateEdit, 2, 1);
            tableLayoutPanel1.Location = new Point(13, 157);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(925, 288);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbCatTypeDes
            // 
            lbCatTypeDes.Anchor = AnchorStyles.Right;
            lbCatTypeDes.AutoSize = true;
            lbCatTypeDes.Location = new Point(379, 26);
            lbCatTypeDes.Name = "lbCatTypeDes";
            lbCatTypeDes.Size = new Size(80, 20);
            lbCatTypeDes.TabIndex = 0;
            lbCatTypeDes.Text = "EAN Code:";
            // 
            // tbEanCode
            // 
            tbEanCode.Anchor = AnchorStyles.Left;
            tbEanCode.Location = new Point(465, 22);
            tbEanCode.Margin = new Padding(3, 4, 3, 4);
            tbEanCode.Name = "tbEanCode";
            tbEanCode.Size = new Size(228, 27);
            tbEanCode.TabIndex = 2;
            // 
            // btCreateEdit
            // 
            btCreateEdit.Location = new Point(465, 76);
            btCreateEdit.Margin = new Padding(3, 4, 3, 4);
            btCreateEdit.Name = "btCreateEdit";
            btCreateEdit.Size = new Size(229, 64);
            btCreateEdit.TabIndex = 3;
            btCreateEdit.Text = "Create Category";
            btCreateEdit.UseVisualStyleBackColor = true;
            btCreateEdit.Click += btCreateEdit_Click;
            // 
            // CreateEditCategoryPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanelCreate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateEditCategoryPanel";
            Size = new Size(950, 705);
            titlePanelCreate.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Forms.Custom_Form_Item.TitledPanel titlePanelCreate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbCatTypeDes;
        private TextBox tbEanCode;
        private Button btCreateEdit;
    }
}
