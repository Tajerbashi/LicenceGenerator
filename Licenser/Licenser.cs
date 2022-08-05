using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FoxLearn.License;
using System.Management;   //This namespace is used to work with WMI classes. For using this namespace add reference of System.Management.dll .
using Microsoft.Win32;     //This namespace is used to work with Registry editor.

namespace Licenser
{
    public partial class Licenser : Form
    {
        #region Round
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion
        public Licenser()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        int sw = 1;
        private void Licenser_Load(object sender, EventArgs e)
        {

        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SystemInfo_Click(object sender, EventArgs e)
        {
            sw++;
            ComputerLBL.Text = "Computer Name: " + Environment.MachineName;
            HASHLBL.Text = "( " + ComputerInfo.GetComputerId() + " )";
            if (sw%2==0)
            {
                HashPanel.Visible = true;
            }
            else
            {
                HashPanel.Visible = false;
            }
        }

        private void Sender_Click(object sender, EventArgs e)
        {
            (new SenderForm()).ShowDialog();
        }

        private void Control_Click(object sender, EventArgs e)
        {
            (new ControlLicenseForm()).ShowDialog();
        }
    }
}
