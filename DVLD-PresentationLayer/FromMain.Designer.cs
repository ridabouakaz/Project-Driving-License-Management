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
            this.SMItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemRenewDrivingLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemReplacementForLostOrDamagedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemRetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageTestTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItempeople = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemdrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemusers = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemchangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSingOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MSMain.SuspendLayout();
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
            this.MSMain.Size = new System.Drawing.Size(1448, 108);
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
            this.SMItemDrivingLicensesServices.Name = "SMItemDrivingLicensesServices";
            this.SMItemDrivingLicensesServices.Size = new System.Drawing.Size(392, 30);
            this.SMItemDrivingLicensesServices.Text = "Driving Licenses Services";
            // 
            // SMItemNewDrivingLicenses
            // 
            this.SMItemNewDrivingLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemNewDrivingLicenses.Name = "SMItemNewDrivingLicenses";
            this.SMItemNewDrivingLicenses.Size = new System.Drawing.Size(540, 48);
            this.SMItemNewDrivingLicenses.Text = "New Driving Licenses";
            // 
            // SMItemSeparator1
            // 
            this.SMItemSeparator1.Name = "SMItemSeparator1";
            this.SMItemSeparator1.Size = new System.Drawing.Size(537, 6);
            // 
            // SMItemRenewDrivingLicenses
            // 
            this.SMItemRenewDrivingLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemRenewDrivingLicenses.Name = "SMItemRenewDrivingLicenses";
            this.SMItemRenewDrivingLicenses.Size = new System.Drawing.Size(540, 48);
            this.SMItemRenewDrivingLicenses.Text = "Renew Driving Licenses";
            // 
            // SMItemReplacementForLostOrDamagedLicenses
            // 
            this.SMItemReplacementForLostOrDamagedLicenses.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemReplacementForLostOrDamagedLicenses.Name = "SMItemReplacementForLostOrDamagedLicenses";
            this.SMItemReplacementForLostOrDamagedLicenses.Size = new System.Drawing.Size(540, 48);
            this.SMItemReplacementForLostOrDamagedLicenses.Text = "Replacement For Lost Or Damaged Licenses";
            // 
            // SMItemReleaseDetainedDrivingLicense
            // 
            this.SMItemReleaseDetainedDrivingLicense.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemReleaseDetainedDrivingLicense.Name = "SMItemReleaseDetainedDrivingLicense";
            this.SMItemReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(540, 48);
            this.SMItemReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            // 
            // SMItemRetakeTest
            // 
            this.SMItemRetakeTest.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemRetakeTest.Name = "SMItemRetakeTest";
            this.SMItemRetakeTest.Size = new System.Drawing.Size(540, 30);
            this.SMItemRetakeTest.Text = "Retake Test\n";
            // 
            // SMItemSeparator2
            // 
            this.SMItemSeparator2.Name = "SMItemSeparator2";
            this.SMItemSeparator2.Size = new System.Drawing.Size(389, 6);
            // 
            // SMItemManageApplications
            // 
            this.SMItemManageApplications.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemManageApplications.Name = "SMItemManageApplications";
            this.SMItemManageApplications.Size = new System.Drawing.Size(392, 30);
            this.SMItemManageApplications.Text = "Manage Applications";
            // 
            // SMItemDetainLicenses
            // 
            this.SMItemDetainLicenses.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemDetainLicenses.Name = "SMItemDetainLicenses";
            this.SMItemDetainLicenses.Size = new System.Drawing.Size(392, 30);
            this.SMItemDetainLicenses.Text = "Detain Licenses";
            // 
            // SMItemManageApplicationTypes
            // 
            this.SMItemManageApplicationTypes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemManageApplicationTypes.Name = "SMItemManageApplicationTypes";
            this.SMItemManageApplicationTypes.Size = new System.Drawing.Size(392, 30);
            this.SMItemManageApplicationTypes.Text = "Manage Application Types";
            // 
            // SMItemManageTestTypes
            // 
            this.SMItemManageTestTypes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMItemManageTestTypes.Name = "SMItemManageTestTypes";
            this.SMItemManageTestTypes.Size = new System.Drawing.Size(392, 30);
            this.SMItemManageTestTypes.Text = "Manage Test Types";
            // 
            // SMItempeople
            // 
            this.SMItempeople.Image = ((System.Drawing.Image)(resources.GetObject("SMItempeople.Image")));
            this.SMItempeople.Name = "SMItempeople";
            this.SMItempeople.Size = new System.Drawing.Size(181, 68);
            this.SMItempeople.Text = "people";
            // 
            // SMItemdrivers
            // 
            this.SMItemdrivers.Image = ((System.Drawing.Image)(resources.GetObject("SMItemdrivers.Image")));
            this.SMItemdrivers.Name = "SMItemdrivers";
            this.SMItemdrivers.Size = new System.Drawing.Size(189, 68);
            this.SMItemdrivers.Text = "Drivers";
            // 
            // SMItemusers
            // 
            this.SMItemusers.Image = ((System.Drawing.Image)(resources.GetObject("SMItemusers.Image")));
            this.SMItemusers.Name = "SMItemusers";
            this.SMItemusers.Size = new System.Drawing.Size(166, 68);
            this.SMItemusers.Text = "Users";
            // 
            // SMItemAccountSettings
            // 
            this.SMItemAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemCurrentUserInfo,
            this.SMItemchangePassword,
            this.SMItemSingOut});
            this.SMItemAccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("SMItemAccountSettings.Image")));
            this.SMItemAccountSettings.Name = "SMItemAccountSettings";
            this.SMItemAccountSettings.Size = new System.Drawing.Size(318, 68);
            this.SMItemAccountSettings.Text = "Account Settings";
            // 
            // SMItemCurrentUserInfo
            // 
            this.SMItemCurrentUserInfo.Name = "SMItemCurrentUserInfo";
            this.SMItemCurrentUserInfo.Size = new System.Drawing.Size(339, 34);
            this.SMItemCurrentUserInfo.Text = "Current User Info";
            // 
            // SMItemchangePassword
            // 
            this.SMItemchangePassword.Name = "SMItemchangePassword";
            this.SMItemchangePassword.Size = new System.Drawing.Size(339, 34);
            this.SMItemchangePassword.Text = "Change Password";
            // 
            // SMItemSingOut
            // 
            this.SMItemSingOut.Name = "SMItemSingOut";
            this.SMItemSingOut.Size = new System.Drawing.Size(339, 34);
            this.SMItemSingOut.Text = "Sign Out";
            // 
            // FOmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 499);
            this.Controls.Add(this.MSMain);
            this.Name = "FOmain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FOmain_Load);
            this.MSMain.ResumeLayout(false);
            this.MSMain.PerformLayout();
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
    }
}

