using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsbDetail
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives().Where(d => d.IsReady & d.DriveType == DriveType.Removable);
            if (drives.FirstOrDefault() != null)
            {
                lblName.Text = drives.FirstOrDefault().Name.ToString();
                lblDriveFormat.Text = drives.FirstOrDefault().DriveFormat.ToString();
                lblDriveType.Text = drives.FirstOrDefault().DriveType.ToString();
                lblIsReady.Text = drives.FirstOrDefault().IsReady.ToString();
                lblTotalSpace.Text = drives.FirstOrDefault().TotalSize.ToString();
                lblFreeSpace.Text = drives.FirstOrDefault().TotalFreeSpace.ToString();
            }
            else
            {
                MessageBox.Show("No pendriver connected ...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
