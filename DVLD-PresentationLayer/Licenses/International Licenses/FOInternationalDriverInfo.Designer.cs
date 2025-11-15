namespace DVLD_PresentationLayer.Applications.International_License
{
    partial class FOInternationalDriverInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOInternationalDriverInfo));
            this.ctrDetailsDriverInternationalLicenseApplication1 = new DVLD_PresentationLayer.CtrDetailsDriverInternationalLicenseApplication();
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.PBManageLocalDrivingApplications = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageLocalDrivingApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrDetailsDriverInternationalLicenseApplication1
            // 
            this.ctrDetailsDriverInternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsDriverInternationalLicenseApplication1.ImagePath = null;
            this.ctrDetailsDriverInternationalLicenseApplication1.InternationalLicenseData = null;
            this.ctrDetailsDriverInternationalLicenseApplication1.Location = new System.Drawing.Point(3, 195);
            this.ctrDetailsDriverInternationalLicenseApplication1.Name = "ctrDetailsDriverInternationalLicenseApplication1";
            this.ctrDetailsDriverInternationalLicenseApplication1.Size = new System.Drawing.Size(1373, 299);
            this.ctrDetailsDriverInternationalLicenseApplication1.TabIndex = 0;
            // 
            // LblHeaderTitle
            // 
            this.LblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHeaderTitle.AutoSize = true;
            this.LblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblHeaderTitle.Location = new System.Drawing.Point(387, 142);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(583, 50);
            this.LblHeaderTitle.TabIndex = 5;
            this.LblHeaderTitle.Text = "Driver International License Info";
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(1202, 500);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 59;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // PBManageLocalDrivingApplications
            // 
            this.PBManageLocalDrivingApplications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageLocalDrivingApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageLocalDrivingApplications.Image = ((System.Drawing.Image)(resources.GetObject("PBManageLocalDrivingApplications.Image")));
            this.PBManageLocalDrivingApplications.Location = new System.Drawing.Point(626, 14);
            this.PBManageLocalDrivingApplications.Name = "PBManageLocalDrivingApplications";
            this.PBManageLocalDrivingApplications.Size = new System.Drawing.Size(137, 125);
            this.PBManageLocalDrivingApplications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageLocalDrivingApplications.TabIndex = 60;
            this.PBManageLocalDrivingApplications.TabStop = false;
            // 
            // FOInternationalDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 562);
            this.Controls.Add(this.PBManageLocalDrivingApplications);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblHeaderTitle);
            this.Controls.Add(this.ctrDetailsDriverInternationalLicenseApplication1);
            this.Name = "FOInternationalDriverInfo";
            this.Text = "International Driver Info";
            this.Load += new System.EventHandler(this.FOInternationalDriverInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageLocalDrivingApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrDetailsDriverInternationalLicenseApplication ctrDetailsDriverInternationalLicenseApplication1;
        private System.Windows.Forms.Label LblHeaderTitle;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.PictureBox PBManageLocalDrivingApplications;
    }
}