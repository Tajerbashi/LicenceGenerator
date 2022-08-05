namespace Licenser
{
    partial class ControlLicenseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HashCodeTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LiceTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SendBTN = new XanderUI.XUIButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(466, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "لایسنس :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "کد دستگاه :";
            // 
            // HashCodeTXT
            // 
            // 
            // 
            // 
            this.HashCodeTXT.Border.Class = "TextBoxBorder";
            this.HashCodeTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HashCodeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HashCodeTXT.Location = new System.Drawing.Point(12, 12);
            this.HashCodeTXT.Name = "HashCodeTXT";
            this.HashCodeTXT.PreventEnterBeep = true;
            this.HashCodeTXT.Size = new System.Drawing.Size(446, 26);
            this.HashCodeTXT.TabIndex = 11;
            this.HashCodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LiceTXT
            // 
            // 
            // 
            // 
            this.LiceTXT.Border.Class = "TextBoxBorder";
            this.LiceTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LiceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LiceTXT.Location = new System.Drawing.Point(12, 44);
            this.LiceTXT.Name = "LiceTXT";
            this.LiceTXT.PreventEnterBeep = true;
            this.LiceTXT.Size = new System.Drawing.Size(446, 26);
            this.LiceTXT.TabIndex = 12;
            this.LiceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendBTN
            // 
            this.SendBTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SendBTN.ButtonImage = null;
            this.SendBTN.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SendBTN.ButtonText = "تایید لایسنس";
            this.SendBTN.ClickBackColor = System.Drawing.Color.DimGray;
            this.SendBTN.ClickTextColor = System.Drawing.Color.White;
            this.SendBTN.CornerRadius = 5;
            this.SendBTN.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.SendBTN.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SendBTN.HoverBackgroundColor = System.Drawing.Color.Black;
            this.SendBTN.HoverTextColor = System.Drawing.Color.White;
            this.SendBTN.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SendBTN.Location = new System.Drawing.Point(12, 76);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(521, 32);
            this.SendBTN.TabIndex = 13;
            this.SendBTN.TextColor = System.Drawing.Color.Black;
            this.SendBTN.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SendBTN.Click += new System.EventHandler(this.SendBTN_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Mj_Mousa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 25);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "برگشت به قبل";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ControlLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(545, 140);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.LiceTXT);
            this.Controls.Add(this.HashCodeTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlLicenseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlLicenseForm";
            this.Load += new System.EventHandler(this.ControlLicenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX HashCodeTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX LiceTXT;
        private XanderUI.XUIButton SendBTN;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}