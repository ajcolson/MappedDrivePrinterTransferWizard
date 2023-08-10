using MappedDrivePrinterTransferWizard.Properties;
using System.Diagnostics;
using System.Security.Principal;

namespace MappedDrivePrinterTransferWizard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static bool IsUserRunningAppAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!IsUserRunningAppAdministrator())
            {
                MessageBox.Show("This application needs to be run by a user with administrator rights. This app will close when you dismiss this message.", "Mapped Drive and Printer Transfer Wizard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }

            try {
                File.Delete(@"C:\Temp\backup-mapped-drives-printers.ps1");
                File.WriteAllBytes(@"C:\Temp\backup-mapped-drives-printers.ps1", Resources.backup_mapped_drives_printers);

                File.Delete(@"C:\Temp\restore-mapped-drives-printers.ps1");
                File.WriteAllBytes(@"C:\Temp\restore-mapped-drives-printers.ps1", Resources.restore_mapped_drives_printers);
            } catch {
                MessageBox.Show("Unable to write needed backup scripts. This program will close after dismissing this message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            try {
                Process p = new Process();
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.FileName = "powershell.exe";
                p.StartInfo.Arguments = @"–ExecutionPolicy Bypass C:\Temp\backup-mapped-drives-printers.ps1";
                p.Start();
                MessageBox.Show("Backup Completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch {
                MessageBox.Show("Something went wrong trying to run the backup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            try {
                Process p = new Process();
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.FileName = "powershell.exe";
                p.StartInfo.Arguments = @"–ExecutionPolicy Bypass C:\Temp\restore-mapped-drives-printers.ps1";
                p.Start();
                MessageBox.Show("Restore Completed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch {
                MessageBox.Show("Something went wrong trying to run the restore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application allows the quick backup and restoring of mapped drives and printers from a user profile. The application will create two files on the desktop during backup. To restore, place the files with the same name on the desktop.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}