namespace WinformApp
{
    partial class LibraryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            navigationPanel = new Panel();
            contentPanel = new Panel();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.BorderStyle = BorderStyle.Fixed3D;
            navigationPanel.Location = new Point(12, 12);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(266, 508);
            navigationPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.BorderStyle = BorderStyle.FixedSingle;
            contentPanel.Location = new Point(297, 12);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(763, 508);
            contentPanel.TabIndex = 2;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 532);
            Controls.Add(contentPanel);
            Controls.Add(navigationPanel);
            Name = "LibraryForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel navigationPanel;
        private Panel contentPanel;
    }
}
