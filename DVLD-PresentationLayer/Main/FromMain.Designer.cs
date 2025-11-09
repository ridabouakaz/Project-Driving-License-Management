using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOmain));
            this.MSMain = new System.Windows.Forms.MenuStrip();
            this.SMItemApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemNewDrivingLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemNewDrivingLocalLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemRenewDrivingLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemReplacementForLostOrDamagedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemlocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemInternationalLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemReleaseDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItempeople = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemdrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemusers = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemchangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemSingOut = new System.Windows.Forms.ToolStripMenuItem();
            this.PBProject = new System.Windows.Forms.PictureBox();
            this.MSMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProject)).BeginInit();
            this.SuspendLayout();
            // 
            // MSMain
            // 
            this.MSMain.BackColor = System.Drawing.SystemColors.Control;
            this.MSMain.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.MSMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MSMain.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.MSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemApplications,
            this.SMItempeople,
            this.SMItemdrivers,
            this.SMItemusers,
            this.SMItemAccountSettings});
            this.MSMain.Location = new System.Drawing.Point(0, 0);
            this.MSMain.Name = "MSMain";
            this.MSMain.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.MSMain.Size = new System.Drawing.Size(1700, 108);
            this.MSMain.TabIndex = 0;
            this.MSMain.Text = "MSMain";
            // 
            // SMItemApplications
            // 
            this.SMItemApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemDrivingLicensesServices,
            this.SMItemSeparator2,
            this.SMItemManageApplications,
            this.SMItemDetainLicenses,
            this.SMItemManageApplicationTypes,
            this.SMItemManageTestTypes});
            this.SMItemApplications.Image = ((System.Drawing.Image)(resources.GetObject("SMItemApplications.Image")));
            this.SMItemApplications.Name = "SMItemApplications";
            this.SMItemApplications.Size = new System.Drawing.Size(256, 68);
            this.SMItemApplications.Text = "Applications";
            // 
            // SMItemDrivingLicensesServices
            // 
            this.SMItemDrivingLicensesServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemNewDrivingLicenses,
            this.SMItemSeparator1,
            this.SMItemRenewDrivingLicenses,
            this.SMItemReplacementForLostOrDamagedLicenses,
            this.SMItemReleaseDetainedDrivingLicense,
            this.SMItemRetakeTest});
            this.SMItemDrivingLicensesServices.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemDrivingLicensesServices.Image = ((System.Drawing.Image)(resources.GetObject("SMItemDrivingLicensesServices.Image")));
            this.SMItemDrivingLicensesServices.Name = "SMItemDrivingLicensesServices";
            this.SMItemDrivingLicensesServices.Size = new System.Drawing.Size(436, 70);
            this.SMItemDrivingLicensesServices.Text = "Driving Licenses Services";
            // 
            // SMItemNewDrivingLicenses
            // 
            this.SMItemNewDrivingLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemNewDrivingLocalLicenses});
            this.SMItemNewDrivingLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemNewDrivingLicenses.Image = ((System.Drawing.Image)(resources.GetObject("SMItemNewDrivingLicenses.Image")));
            this.SMItemNewDrivingLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemNewDrivingLicenses.Name = "SMItemNewDrivingLicenses";
            this.SMItemNewDrivingLicenses.Size = new System.Drawing.Size(552, 38);
            this.SMItemNewDrivingLicenses.Text = "New Driving Licenses";
            // 
            // SMItemNewDrivingLocalLicenses
            // 
            this.SMItemNewDrivingLocalLicenses.Image = ((System.Drawing.Image)(resources.GetObject("SMItemNewDrivingLocalLicenses.Image")));
            this.SMItemNewDrivingLocalLicenses.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemNewDrivingLocalLicenses.Name = "SMItemNewDrivingLocalLicenses";
            this.SMItemNewDrivingLocalLicenses.Size = new System.Drawing.Size(243, 30);
            this.SMItemNewDrivingLocalLicenses.Text = "Local Licenses";
            this.SMItemNewDrivingLocalLicenses.Click += new System.EventHandler(this.SMItemNewDrivingLocalLicenses_Click);
            // 
            // SMItemSeparator1
            // 
            this.SMItemSeparator1.Name = "SMItemSeparator1";
            this.SMItemSeparator1.Size = new System.Drawing.Size(549, 6);
            // 
            // SMItemRenewDrivingLicenses
            // 
            this.SMItemRenewDrivingLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemRenewDrivingLicenses.Name = "SMItemRenewDrivingLicenses";
            this.SMItemRenewDrivingLicenses.Size = new System.Drawing.Size(552, 38);
            this.SMItemRenewDrivingLicenses.Text = "Renew Driving Licenses";
            this.SMItemRenewDrivingLicenses.Click += new System.EventHandler(this.SMItemRenewDrivingLicenses_Click);
            // 
            // SMItemReplacementForLostOrDamagedLicenses
            // 
            this.SMItemReplacementForLostOrDamagedLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemReplacementForLostOrDamagedLicenses.Name = "SMItemReplacementForLostOrDamagedLicenses";
            this.SMItemReplacementForLostOrDamagedLicenses.Size = new System.Drawing.Size(552, 38);
            this.SMItemReplacementForLostOrDamagedLicenses.Text = "Replacement For Lost Or Damaged Licenses";
            this.SMItemReplacementForLostOrDamagedLicenses.Click += new System.EventHandler(this.SMItemReplacementForLostOrDamagedLicenses_Click);
            // 
            // SMItemReleaseDetainedDrivingLicense
            // 
            this.SMItemReleaseDetainedDrivingLicense.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemReleaseDetainedDrivingLicense.Name = "SMItemReleaseDetainedDrivingLicense";
            this.SMItemReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(552, 38);
            this.SMItemReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            // 
            // SMItemRetakeTest
            // 
            this.SMItemRetakeTest.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemRetakeTest.Name = "SMItemRetakeTest";
            this.SMItemRetakeTest.Size = new System.Drawing.Size(552, 38);
            this.SMItemRetakeTest.Text = "Retake Test";
            this.SMItemRetakeTest.Click += new System.EventHandler(this.SMItemRetakeTest_Click);
            // 
            // SMItemSeparator2
            // 
            this.SMItemSeparator2.Name = "SMItemSeparator2";
            this.SMItemSeparator2.Size = new System.Drawing.Size(433, 6);
            // 
            // SMItemManageApplications
            // 
            this.SMItemManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemlocalDrivingLicenseApplications,
            this.SMItemInternationalLicenseApplications});
            this.SMItemManageApplications.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemManageApplications.Image = ((System.Drawing.Image)(resources.GetObject("SMItemManageApplications.Image")));
            this.SMItemManageApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemManageApplications.Name = "SMItemManageApplications";
            this.SMItemManageApplications.Size = new System.Drawing.Size(436, 70);
            this.SMItemManageApplications.Text = "Manage Applications";
            // 
            // SMItemlocalDrivingLicenseApplications
            // 
            this.SMItemlocalDrivingLicenseApplications.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.SMItemlocalDrivingLicenseApplications.Image = ((System.Drawing.Image)(resources.GetObject("SMItemlocalDrivingLicenseApplications.Image")));
            this.SMItemlocalDrivingLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemlocalDrivingLicenseApplications.Name = "SMItemlocalDrivingLicenseApplications";
            this.SMItemlocalDrivingLicenseApplications.Size = new System.Drawing.Size(455, 38);
            this.SMItemlocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.SMItemlocalDrivingLicenseApplications.Click += new System.EventHandler(this.SMItemlocalDrivingLicenseApplications_Click);
            // 
            // SMItemInternationalLicenseApplications
            // 
            this.SMItemInternationalLicenseApplications.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.SMItemInternationalLicenseApplications.Image = ((System.Drawing.Image)(resources.GetObject("SMItemInternationalLicenseApplications.Image")));
            this.SMItemInternationalLicenseApplications.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemInternationalLicenseApplications.Name = "SMItemInternationalLicenseApplications";
            this.SMItemInternationalLicenseApplications.Size = new System.Drawing.Size(455, 38);
            this.SMItemInternationalLicenseApplications.Text = "International License Applications";
            this.SMItemInternationalLicenseApplications.Click += new System.EventHandler(this.SMItemInternationalLicenseApplications_Click);
            // 
            // SMItemDetainLicenses
            // 
            this.SMItemDetainLicenses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemManageDetainedLicenses,
            this.SMItemDetainedLicense,
            this.SMItemReleaseDetainedLicenses});
            this.SMItemDetainLicenses.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemDetainLicenses.Name = "SMItemDetainLicenses";
            this.SMItemDetainLicenses.Size = new System.Drawing.Size(436, 70);
            this.SMItemDetainLicenses.Text = "Detain Licenses";
            // 
            // SMItemManageDetainedLicenses
            // 
            this.SMItemManageDetainedLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.SMItemManageDetainedLicenses.Name = "SMItemManageDetainedLicenses";
            this.SMItemManageDetainedLicenses.Size = new System.Drawing.Size(365, 26);
            this.SMItemManageDetainedLicenses.Text = "Manage Detained Licenses";
            // 
            // SMItemDetainedLicense
            // 
            this.SMItemDetainedLicense.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.SMItemDetainedLicense.Name = "SMItemDetainedLicense";
            this.SMItemDetainedLicense.Size = new System.Drawing.Size(365, 26);
            this.SMItemDetainedLicense.Text = "Detained License";
            // 
            // SMItemReleaseDetainedLicenses
            // 
            this.SMItemReleaseDetainedLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold);
            this.SMItemReleaseDetainedLicenses.Name = "SMItemReleaseDetainedLicenses";
            this.SMItemReleaseDetainedLicenses.Size = new System.Drawing.Size(365, 26);
            this.SMItemReleaseDetainedLicenses.Text = "Release Detained Licenses";
            // 
            // SMItemManageApplicationTypes
            // 
            this.SMItemManageApplicationTypes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemManageApplicationTypes.Image = ((System.Drawing.Image)(resources.GetObject("SMItemManageApplicationTypes.Image")));
            this.SMItemManageApplicationTypes.Name = "SMItemManageApplicationTypes";
            this.SMItemManageApplicationTypes.Size = new System.Drawing.Size(436, 70);
            this.SMItemManageApplicationTypes.Text = "Manage Application Types";
            this.SMItemManageApplicationTypes.Click += new System.EventHandler(this.SMItemManageApplicationTypes_Click);
            // 
            // SMItemManageTestTypes
            // 
            this.SMItemManageTestTypes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemManageTestTypes.Image = ((System.Drawing.Image)(resources.GetObject("SMItemManageTestTypes.Image")));
            this.SMItemManageTestTypes.Name = "SMItemManageTestTypes";
            this.SMItemManageTestTypes.Size = new System.Drawing.Size(436, 70);
            this.SMItemManageTestTypes.Text = "Manage Test Types";
            this.SMItemManageTestTypes.Click += new System.EventHandler(this.SMItemManageTestTypes_Click);
            // 
            // SMItempeople
            // 
            this.SMItempeople.Image = ((System.Drawing.Image)(resources.GetObject("SMItempeople.Image")));
            this.SMItempeople.Name = "SMItempeople";
            this.SMItempeople.Size = new System.Drawing.Size(181, 68);
            this.SMItempeople.Text = "people";
            this.SMItempeople.Click += new System.EventHandler(this.SMItempeople_Click);
            // 
            // SMItemdrivers
            // 
            this.SMItemdrivers.Image = ((System.Drawing.Image)(resources.GetObject("SMItemdrivers.Image")));
            this.SMItemdrivers.Name = "SMItemdrivers";
            this.SMItemdrivers.Size = new System.Drawing.Size(189, 68);
            this.SMItemdrivers.Text = "Drivers";
            this.SMItemdrivers.Click += new System.EventHandler(this.SMItemdrivers_Click);
            // 
            // SMItemusers
            // 
            this.SMItemusers.Image = ((System.Drawing.Image)(resources.GetObject("SMItemusers.Image")));
            this.SMItemusers.Name = "SMItemusers";
            this.SMItemusers.Size = new System.Drawing.Size(166, 68);
            this.SMItemusers.Text = "Users";
            this.SMItemusers.Click += new System.EventHandler(this.SMItemusers_Click);
            // 
            // SMItemAccountSettings
            // 
            this.SMItemAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemCurrentUserInfo,
            this.SMItemchangePassword,
            this.SMItemSeparator3,
            this.SMItemSingOut});
            this.SMItemAccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("SMItemAccountSettings.Image")));
            this.SMItemAccountSettings.Name = "SMItemAccountSettings";
            this.SMItemAccountSettings.Size = new System.Drawing.Size(318, 68);
            this.SMItemAccountSettings.Text = "Account Settings";
            // 
            // SMItemCurrentUserInfo
            // 
            this.SMItemCurrentUserInfo.AutoSize = false;
            this.SMItemCurrentUserInfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemCurrentUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("SMItemCurrentUserInfo.Image")));
            this.SMItemCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemCurrentUserInfo.Name = "SMItemCurrentUserInfo";
            this.SMItemCurrentUserInfo.Size = new System.Drawing.Size(298, 30);
            this.SMItemCurrentUserInfo.Text = "Current User Info";
            this.SMItemCurrentUserInfo.Click += new System.EventHandler(this.SMItemCurrentUserInfo_Click);
            // 
            // SMItemchangePassword
            // 
            this.SMItemchangePassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemchangePassword.Image = ((System.Drawing.Image)(resources.GetObject("SMItemchangePassword.Image")));
            this.SMItemchangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemchangePassword.Name = "SMItemchangePassword";
            this.SMItemchangePassword.Size = new System.Drawing.Size(310, 38);
            this.SMItemchangePassword.Text = "Change Password";
            this.SMItemchangePassword.Click += new System.EventHandler(this.SMItemchangePassword_Click);
            // 
            // SMItemSeparator3
            // 
            this.SMItemSeparator3.Name = "SMItemSeparator3";
            this.SMItemSeparator3.Size = new System.Drawing.Size(307, 6);
            // 
            // SMItemSingOut
            // 
            this.SMItemSingOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemSingOut.Image = ((System.Drawing.Image)(resources.GetObject("SMItemSingOut.Image")));
            this.SMItemSingOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemSingOut.Name = "SMItemSingOut";
            this.SMItemSingOut.Size = new System.Drawing.Size(310, 38);
            this.SMItemSingOut.Text = "Sign Out";
            this.SMItemSingOut.Click += new System.EventHandler(this.SMItemSingOut_Click);
            // 
            // PBProject
            // 
            this.PBProject.Location = new System.Drawing.Point(299, 302);
            this.PBProject.Name = "PBProject";
            this.PBProject.Size = new System.Drawing.Size(1095, 278);
            this.PBProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBProject.TabIndex = 1;
            this.PBProject.TabStop = false;
            // 
            // FOmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 700);
            this.Controls.Add(this.PBProject);
            this.Controls.Add(this.MSMain);
            this.Name = "FOmain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FOmain_Load);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip MSMain;
        private System.Windows.Forms.ToolStripMenuItem SMItemApplications;
        private System.Windows.Forms.ToolStripMenuItem SMItempeople;
        private System.Windows.Forms.ToolStripMenuItem SMItemDrivingLicensesServices;
        private ToolStripMenuItem SMItemdrivers;
        private ToolStripMenuItem SMItemusers;
        private ToolStripMenuItem SMItemAccountSettings;
        private ToolStripMenuItem SMItemManageApplications;
        private ToolStripMenuItem SMItemDetainLicenses;
        private ToolStripMenuItem SMItemManageApplicationTypes;
        private ToolStripMenuItem SMItemManageTestTypes;
        private ToolStripMenuItem SMItemCurrentUserInfo;
        private ToolStripMenuItem SMItemchangePassword;
        private ToolStripMenuItem SMItemSingOut;
        private ToolStripMenuItem SMItemNewDrivingLicenses;
        private ToolStripMenuItem SMItemRenewDrivingLicenses;
        private ToolStripMenuItem SMItemReplacementForLostOrDamagedLicenses;
        private ToolStripMenuItem SMItemReleaseDetainedDrivingLicense;
        private ToolStripMenuItem SMItemRetakeTest;
        private ToolStripSeparator SMItemSeparator1;
        private ToolStripSeparator SMItemSeparator2;
        private ToolStripMenuItem SMItemManageDetainedLicenses;
        private ToolStripMenuItem SMItemDetainedLicense;
        private ToolStripMenuItem SMItemReleaseDetainedLicenses;
        private ToolStripSeparator SMItemSeparator3;
        private PictureBox PBProject;
        private ToolStripMenuItem SMItemNewDrivingLocalLicenses;
        private ToolStripMenuItem SMItemlocalDrivingLicenseApplications;
        private ToolStripMenuItem SMItemInternationalLicenseApplications;
    }
}

