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
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            lbAge = new Label();
            comboBox2 = new ComboBox();
            chbCreateNewAuthor = new CheckBox();
            btCreateEdit = new Button();
            tbAge = new TextBox();
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
            tableLayoutPanel1.Controls.Add(tbFirstName, 2, 1);
            tableLayoutPanel1.Controls.Add(tbLastName, 2, 2);
            tableLayoutPanel1.Controls.Add(lbAge, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(chbCreateNewAuthor, 1, 0);
            tableLayoutPanel1.Controls.Add(btCreateEdit, 2, 5);
            tableLayoutPanel1.Controls.Add(tbAge, 2, 3);
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
            label1.Location = new Point(321, 96);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(322, 167);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.Left;
            tbFirstName.Location = new Point(410, 93);
            tbFirstName.Margin = new Padding(3, 4, 3, 4);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(228, 27);
            tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Left;
            tbLastName.Location = new Point(410, 164);
            tbLastName.Margin = new Padding(3, 4, 3, 4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(228, 27);
            tbLastName.TabIndex = 3;
            // 
            // lbAge
            // 
            lbAge.Anchor = AnchorStyles.Right;
            lbAge.AutoSize = true;
            lbAge.Location = new Point(365, 238);
            lbAge.Name = "lbAge";
            lbAge.Size = new Size(39, 20);
            lbAge.TabIndex = 5;
            lbAge.Text = "Age:";
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
            // tbAge
            // 
            tbAge.Anchor = AnchorStyles.Left;
            tbAge.Location = new Point(410, 235);
            tbAge.Margin = new Padding(3, 4, 3, 4);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(228, 27);
            tbAge.TabIndex = 12;
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
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private DateTimePicker dtPublicationDate;
        private Label lbAge;
        private ComboBox cbBookInfo;
        private Label label4;
        private ComboBox comboBox2;
        private CheckBox chbCreateNewAuthor;
        private Button btCreateEdit;
        private TextBox tbAge;
    }
}
