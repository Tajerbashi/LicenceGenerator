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

namespace Licenser
{
    public partial class ControlLicenseForm : Form
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

        public ControlLicenseForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void ControlLicenseForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(HashCodeTXT.Text);
            String productKey=LiceTXT.Text.ToString();
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey,ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey=productKey;
                    lic.FullName="Personal accounting";
                    if (kv.Type==LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }

                    km.SaveSuretyFile(String.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("با موفقیت فعال شد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("کد نا معتبر میباشد", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
