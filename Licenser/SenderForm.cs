using FoxLearn.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Licenser
{
    public partial class SenderForm : Form
    {
        public byte ProductCode { get; private set; }
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

        public SenderForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SenderForm_Load(object sender, EventArgs e)
        {
            TimeTXT.Enabled = false;
            TypeBox.SelectedIndex = 0;
            HashCodeTXT.Text = ComputerInfo.GetComputerId();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void TimeTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            if (LicTXT.Text != String.Empty)
            {
                Clipboard.SetText(LicTXT.Text);
            }
        }

        private void TypeBox_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeBox.SelectedIndex == 0)
            {
                TimeTXT.Enabled = false;
            }
            else
            {
                TimeTXT.Enabled = true;
            }
        }

        private void SendBTN_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(HashCodeTXT.Text);
            KeyValuesClass kv;
            String productKey=String.Empty;
            
            if (TypeBox.SelectedIndex==0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                };

                if (!km.GenerateKey(kv,ref productKey))
                {
                    LicTXT.Text = "ERROR";
                }
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(TimeTXT.Text))
                };

                if (!km.GenerateKey(kv,ref productKey))
                {
                    LicTXT.Text = "ERROR";
                }
            }
            LicTXT.Text = productKey;

        }
    }
}
