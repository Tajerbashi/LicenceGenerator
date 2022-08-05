namespace Licenser
{
    partial class SenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderForm));
            this.HashCodeTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TimeTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LicTXT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TypeBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Full = new DevComponents.Editors.ComboItem();
            this.Trial = new DevComponents.Editors.ComboItem();
            this.SendBTN = new XanderUI.XUIButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CopyBTN = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // HashCodeTXT
            // 
            // 
            // 
            // 
            this.HashCodeTXT.Border.Class = "TextBoxBorder";
            this.HashCodeTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HashCodeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HashCodeTXT.Location = new System.Drawing.Point(21, 24);
            this.HashCodeTXT.Name = "HashCodeTXT";
            this.HashCodeTXT.PreventEnterBeep = true;
            this.HashCodeTXT.Size = new System.Drawing.Size(446, 26);
            this.HashCodeTXT.TabIndex = 0;
            this.HashCodeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeTXT
            // 
            // 
            // 
            // 
            this.TimeTXT.Border.Class = "TextBoxBorder";
            this.TimeTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TimeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TimeTXT.Location = new System.Drawing.Point(21, 57);
            this.TimeTXT.MaxLength = 5;
            this.TimeTXT.Name = "TimeTXT";
            this.TimeTXT.PreventEnterBeep = true;
            this.TimeTXT.Size = new System.Drawing.Size(157, 26);
            this.TimeTXT.TabIndex = 1;
            this.TimeTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeTXT_KeyPress);
            // 
            // LicTXT
            // 
            // 
            // 
            // 
            this.LicTXT.Border.Class = "TextBoxBorder";
            this.LicTXT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LicTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LicTXT.Location = new System.Drawing.Point(67, 89);
            this.LicTXT.Name = "LicTXT";
            this.LicTXT.PreventEnterBeep = true;
            this.LicTXT.Size = new System.Drawing.Size(400, 26);
            this.LicTXT.TabIndex = 2;
            this.LicTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TypeBox
            // 
            this.TypeBox.DisplayMember = "Text";
            this.TypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.ItemHeight = 21;
            this.TypeBox.Items.AddRange(new object[] {
            this.Full,
            this.Trial});
            this.TypeBox.Location = new System.Drawing.Point(311, 56);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(157, 27);
            this.TypeBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.TypeBox.TabIndex = 3;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            this.TypeBox.TabIndexChanged += new System.EventHandler(this.TypeBox_TabIndexChanged);
            // 
            // Full
            // 
            this.Full.FontStyle = System.Drawing.FontStyle.Bold;
            this.Full.Image = global::Licenser.Properties.Resources.Icojam_Blue_Bits_Symbol_check;
            this.Full.Text = "Full";
            this.Full.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Full.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Trial
            // 
            this.Trial.FontStyle = System.Drawing.FontStyle.Bold;
            this.Trial.Image = global::Licenser.Properties.Resources.Icons_Land_Vista_Elements_Wait;
            this.Trial.Text = "Trial";
            this.Trial.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Trial.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // SendBTN
            // 
            this.SendBTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SendBTN.ButtonImage = null;
            this.SendBTN.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SendBTN.ButtonText = "صدور مجوز";
            this.SendBTN.ClickBackColor = System.Drawing.Color.DimGray;
            this.SendBTN.ClickTextColor = System.Drawing.Color.White;
            this.SendBTN.CornerRadius = 5;
            this.SendBTN.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.SendBTN.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SendBTN.HoverBackgroundColor = System.Drawing.Color.Black;
            this.SendBTN.HoverTextColor = System.Drawing.Color.White;
            this.SendBTN.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.SendBTN.Location = new System.Drawing.Point(21, 120);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(531, 32);
            this.SendBTN.TabIndex = 4;
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
            this.linkLabel1.Location = new System.Drawing.Point(21, 155);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "برگشت به قبل";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(474, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "کد دستگاه :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "نوع مجوز :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "مهلت استفاده :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mj_Newspaper", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(474, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "کد لایسنس :";
            // 
            // CopyBTN
            // 
            this.CopyBTN.BackgroundColor = System.Drawing.Color.Transparent;
            this.CopyBTN.ButtonImage = global::Licenser.Properties.Resources.Double_J_Design_Ravenna_3d_File_Copy;
            this.CopyBTN.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.CopyBTN.ButtonText = "";
            this.CopyBTN.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.CopyBTN.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.CopyBTN.CornerRadius = 5;
            this.CopyBTN.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.CopyBTN.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CopyBTN.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.CopyBTN.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.CopyBTN.Location = new System.Drawing.Point(26, 85);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(35, 32);
            this.CopyBTN.TabIndex = 5;
            this.CopyBTN.TextColor = System.Drawing.Color.DodgerBlue;
            this.CopyBTN.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // SenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 190);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.SendBTN);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.LicTXT);
            this.Controls.Add(this.TimeTXT);
            this.Controls.Add(this.HashCodeTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SenderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenderForm";
            this.Load += new System.EventHandler(this.SenderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX HashCodeTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX TimeTXT;
        private DevComponents.DotNetBar.Controls.TextBoxX LicTXT;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TypeBox;
        private XanderUI.XUIButton SendBTN;
        private XanderUI.XUIButton CopyBTN;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.ComboItem Trial;
        private DevComponents.Editors.ComboItem Full;
    }
}