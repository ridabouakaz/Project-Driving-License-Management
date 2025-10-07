namespace DVLD_PresentationLayer.Licenses
{
    partial class FOLicenseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOLicenseInfo));
            this.ctrDetailsLicenses1 = new DVLD_PresentationLayer.CtrDetailsLicenses();
            this.LblDriverLicenseInfo = new System.Windows.Forms.Label();
            this.PBDriverLicenseInfo = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBDriverLicenseInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDetailsLicenses1
            // 
            this.ctrDetailsLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsLicenses1.Class = "[????????]";
            this.ctrDetailsLicenses1.DateOfBirth = "[????????]";
            this.ctrDetailsLicenses1.DriverID = "[????????]";
            this.ctrDetailsLicenses1.ExpirationDate = "[????????]";
            this.ctrDetailsLicenses1.FullName = "[????????]";
            this.ctrDetailsLicenses1.ImagePath = null;
            this.ctrDetailsLicenses1.IsDetained = "[????????]";
            this.ctrDetailsLicenses1.IssueDate = "[????????]";
            this.ctrDetailsLicenses1.LicenseID = "[????????]";
            this.ctrDetailsLicenses1.Location = new System.Drawing.Point(1, 193);
            this.ctrDetailsLicenses1.Name = "ctrDetailsLicenses1";
            this.ctrDetailsLicenses1.NationalNo = "[????????]";
            this.ctrDetailsLicenses1.Notes = "[????????]";
            this.ctrDetailsLicenses1.PersonData = null;
            this.ctrDetailsLicenses1.Size = new System.Drawing.Size(1159, 450);
            this.ctrDetailsLicenses1.TabIndex = 0;
            // 
            // LblDriverLicenseInfo
            // 
            this.LblDriverLicenseInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDriverLicenseInfo.AutoSize = true;
            this.LblDriverLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblDriverLicenseInfo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblDriverLicenseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblDriverLicenseInfo.Location = new System.Drawing.Point(378, 140);
            this.LblDriverLicenseInfo.Name = "LblDriverLicenseInfo";
            this.LblDriverLicenseInfo.Size = new System.Drawing.Size(395, 50);
            this.LblDriverLicenseInfo.TabIndex = 3;
            this.LblDriverLicenseInfo.Text = "Driver License Details";
            // 
            // PBDriverLicenseInfo
            // 
            this.PBDriverLicenseInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBDriverLicenseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBDriverLicenseInfo.Location = new System.Drawing.Point(500, 12);
            this.PBDriverLicenseInfo.Name = "PBDriverLicenseInfo";
            this.PBDriverLicenseInfo.Size = new System.Drawing.Size(137, 125);
            this.PBDriverLicenseInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBDriverLicenseInfo.TabIndex = 49;
            this.PBDriverLicenseInfo.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(992, 635);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnClose.Size = new System.Drawing.Size(155, 50);
            this.BtnClose.TabIndex = 52;
            this.BtnClose.Text = "Close";
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FOLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 697);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PBDriverLicenseInfo);
            this.Controls.Add(this.LblDriverLicenseInfo);
            this.Controls.Add(this.ctrDetailsLicenses1);
            this.Name = "FOLicenseInfo";
            this.Text = "License Info";
            ((System.ComponentModel.ISupportInitialize)(this.PBDriverLicenseInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrDetailsLicenses ctrDetailsLicenses1;
        private System.Windows.Forms.Label LblDriverLicenseInfo;
        private System.Windows.Forms.PictureBox PBDriverLicenseInfo;
        private System.Windows.Forms.Button BtnClose;
    }
}