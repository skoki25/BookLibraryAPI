namespace LibraryWindowsApp
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            tbLgin = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            btLogin = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(tbLgin, 1, 0);
            tableLayoutPanel1.Controls.Add(tbPassword, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(497, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(182, 50);
            label3.Name = "label3";
            label3.Size = new Size(63, 50);
            label3.TabIndex = 4;
            label3.Text = "Password: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(176, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 50);
            label2.TabIndex = 3;
            label2.Text = "User name: ";
            // 
            // tbLgin
            // 
            tbLgin.Location = new Point(251, 3);
            tbLgin.Name = "tbLgin";
            tbLgin.Size = new Size(243, 23);
            tbLgin.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Dock = DockStyle.Fill;
            tbPassword.Location = new Point(251, 53);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(243, 23);
            tbPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "LIbrary";
            // 
            // btLogin
            // 
            btLogin.Location = new Point(164, 194);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(93, 23);
            btLogin.TabIndex = 2;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 248);
            Controls.Add(btLogin);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbLgin;
        private TextBox tbPassword;
        private Label label1;
        private Button btLogin;
        private Label label2;
        private Label label3;
    }
}