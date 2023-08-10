namespace MappedDrivePrinterTransferWizard
{
    partial class MainForm
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
            BackupBtn = new Button();
            RestoreBtn = new Button();
            AppVersionLabel = new Label();
            MainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // BackupBtn
            // 
            BackupBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BackupBtn.Location = new Point(18, 80);
            BackupBtn.Name = "BackupBtn";
            BackupBtn.Size = new Size(228, 86);
            BackupBtn.TabIndex = 0;
            BackupBtn.Text = "Backup";
            BackupBtn.UseVisualStyleBackColor = true;
            BackupBtn.Click += BackupBtn_Click;
            // 
            // RestoreBtn
            // 
            RestoreBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            RestoreBtn.Location = new Point(280, 80);
            RestoreBtn.Name = "RestoreBtn";
            RestoreBtn.Size = new Size(228, 86);
            RestoreBtn.TabIndex = 1;
            RestoreBtn.Text = "Restore";
            RestoreBtn.UseVisualStyleBackColor = true;
            RestoreBtn.Click += RestoreBtn_Click;
            // 
            // AppVersionLabel
            // 
            AppVersionLabel.AutoSize = true;
            AppVersionLabel.Location = new Point(12, 223);
            AppVersionLabel.Name = "AppVersionLabel";
            AppVersionLabel.Size = new Size(63, 15);
            AppVersionLabel.TabIndex = 2;
            AppVersionLabel.Text = "Version 1.0";
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(526, 24);
            MainMenuStrip.TabIndex = 3;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 247);
            Controls.Add(AppVersionLabel);
            Controls.Add(RestoreBtn);
            Controls.Add(BackupBtn);
            Controls.Add(MainMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mapped Drives and Printers Transfer Wizard";
            Load += MainForm_Load;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackupBtn;
        private Button RestoreBtn;
        private Label AppVersionLabel;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}