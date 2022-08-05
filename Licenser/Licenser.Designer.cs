namespace Licenser
{
    partial class Licenser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licenser));
            this.HashPanel = new XanderUI.XUIGradientPanel();
            this.HASHLBL = new System.Windows.Forms.Label();
            this.ComputerLBL = new System.Windows.Forms.Label();
            this.SystemInfo = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.Control = new XanderUI.XUIButton();
            this.Sender = new XanderUI.XUIButton();
            this.HashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HashPanel
            // 
            this.HashPanel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HashPanel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HashPanel.Controls.Add(this.ComputerLBL);
            this.HashPanel.Controls.Add(this.HASHLBL);
            this.HashPanel.Location = new System.Drawing.Point(12, 142);
            this.HashPanel.Name = "HashPanel";
            this.HashPanel.PrimerColor = System.Drawing.Color.White;
            this.HashPanel.Size = new System.Drawing.Size(353, 50);
            this.HashPanel.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.HashPanel.TabIndex = 5;
            this.HashPanel.TopLeft = System.Drawing.Color.White;
            this.HashPanel.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HashPanel.Visible = false;
            // 
            // HASHLBL
            // 
            this.HASHLBL.AutoSize = true;
            this.HASHLBL.BackColor = System.Drawing.Color.Transparent;
            this.HASHLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HASHLBL.ForeColor = System.Drawing.Color.White;
            this.HASHLBL.Location = new System.Drawing.Point(8, 28);
            this.HASHLBL.Name = "HASHLBL";
            this.HASHLBL.Size = new System.Drawing.Size(198, 16);
            this.HASHLBL.TabIndex = 0;
            this.HASHLBL.Text = "00000-00000-00000-00000-00000";
            // 
            // ComputerLBL
            // 
            this.ComputerLBL.AutoSize = true;
            this.ComputerLBL.BackColor = System.Drawing.Color.Transparent;
            this.ComputerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerLBL.ForeColor = System.Drawing.Color.White;
            this.ComputerLBL.Location = new System.Drawing.Point(8, 6);
            this.ComputerLBL.Name = "ComputerLBL";
            this.ComputerLBL.Size = new System.Drawing.Size(198, 16);
            this.ComputerLBL.TabIndex = 1;
            this.ComputerLBL.Text = "00000-00000-00000-00000-00000";
            // 
            // SystemInfo
            // 
            this.SystemInfo.BackgroundColor = System.Drawing.Color.Silver;
            this.SystemInfo.ButtonImage = global::Licenser.Properties.Resources._3652960;
            this.SystemInfo.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.SystemInfo.ButtonText = "";
            this.SystemInfo.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.SystemInfo.ClickTextColor = System.Drawing.Color.Black;
            this.SystemInfo.CornerRadius = 10;
            this.SystemInfo.Font = new System.Drawing.Font("Mj_AridiNaskh Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SystemInfo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.SystemInfo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.SystemInfo.HoverTextColor = System.Drawing.Color.White;
            this.SystemInfo.ImagePosition = XanderUI.XUIButton.imgPosition.Center;
            this.SystemInfo.Location = new System.Drawing.Point(12, 12);
            this.SystemInfo.Name = "SystemInfo";
            this.SystemInfo.Size = new System.Drawing.Size(147, 124);
            this.SystemInfo.TabIndex = 4;
            this.SystemInfo.TextColor = System.Drawing.Color.DodgerBlue;
            this.SystemInfo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.SystemInfo.Click += new System.EventHandler(this.SystemInfo_Click);
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton3.ButtonImage = global::Licenser.Properties.Resources.power_on;
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.xuiButton3.ButtonText = "";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.Black;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.Black;
            this.xuiButton3.CornerRadius = 15;
            this.xuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiButton3.Font = new System.Drawing.Font("Mj_AridiNaskh Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.Black;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.Black;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(165, 156);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(30, 30);
            this.xuiButton3.TabIndex = 3;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.xuiButton3_Click);
            // 
            // Control
            // 
            this.Control.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Control.ButtonImage = global::Licenser.Properties.Resources._6313903;
            this.Control.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Control.ButtonText = "بررسی لایسنس";
            this.Control.ClickBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Control.ClickTextColor = System.Drawing.Color.White;
            this.Control.CornerRadius = 10;
            this.Control.Font = new System.Drawing.Font("Mj_AridiNaskh Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Control.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Control.HoverBackgroundColor = System.Drawing.Color.Green;
            this.Control.HoverTextColor = System.Drawing.Color.White;
            this.Control.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Control.Location = new System.Drawing.Point(165, 76);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(200, 60);
            this.Control.TabIndex = 1;
            this.Control.TextColor = System.Drawing.Color.White;
            this.Control.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // Sender
            // 
            this.Sender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Sender.ButtonImage = global::Licenser.Properties.Resources._5947553;
            this.Sender.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.Sender.ButtonText = "صدور لایسنس";
            this.Sender.ClickBackColor = System.Drawing.Color.LightSkyBlue;
            this.Sender.ClickTextColor = System.Drawing.Color.Black;
            this.Sender.CornerRadius = 10;
            this.Sender.Font = new System.Drawing.Font("Mj_AridiNaskh Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Sender.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Sender.HoverBackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Sender.HoverTextColor = System.Drawing.Color.White;
            this.Sender.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.Sender.Location = new System.Drawing.Point(165, 10);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(200, 60);
            this.Sender.TabIndex = 0;
            this.Sender.TextColor = System.Drawing.Color.White;
            this.Sender.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // Licenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(378, 198);
            this.Controls.Add(this.HashPanel);
            this.Controls.Add(this.SystemInfo);
            this.Controls.Add(this.xuiButton3);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Sender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Licenser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لایسنسر";
            this.Load += new System.EventHandler(this.Licenser_Load);
            this.HashPanel.ResumeLayout(false);
            this.HashPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton Sender;
        private XanderUI.XUIButton Control;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton SystemInfo;
        private XanderUI.XUIGradientPanel HashPanel;
        private System.Windows.Forms.Label HASHLBL;
        private System.Windows.Forms.Label ComputerLBL;
    }
}

