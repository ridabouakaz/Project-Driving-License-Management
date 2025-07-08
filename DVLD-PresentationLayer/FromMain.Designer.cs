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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SMItemApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDrivingLicensesServices = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageApplictions = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDetainLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemManageApplicationTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItempeople = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemdrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemusers = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTypeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemApplication,
            this.SMItempeople,
            this.SMItemdrivers,
            this.SMItemusers,
            this.SMItemAccountSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.menuStrip1.Size = new System.Drawing.Size(1448, 108);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SMItemApplication
            // 
            this.SMItemApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemDrivingLicensesServices,
            this.SMItemManageApplictions,
            this.SMItemDetainLicenses,
            this.SMItemManageApplicationTypes,
            this.manageTypeTestToolStripMenuItem});
            this.SMItemApplication.Image = ((System.Drawing.Image)(resources.GetObject("SMItemApplication.Image")));
            this.SMItemApplication.Name = "SMItemApplication";
            this.SMItemApplication.Size = new System.Drawing.Size(217, 68);
            this.SMItemApplication.Text = "Application";
            // 
            // SMItemDrivingLicensesServices
            // 
            this.SMItemDrivingLicensesServices.Name = "SMItemDrivingLicensesServices";
            this.SMItemDrivingLicensesServices.Size = new System.Drawing.Size(391, 30);
            this.SMItemDrivingLicensesServices.Text = "Driving Licenses Services";
            // 
            // SMItemManageApplictions
            // 
            this.SMItemManageApplictions.Name = "SMItemManageApplictions";
            this.SMItemManageApplictions.Size = new System.Drawing.Size(391, 30);
            this.SMItemManageApplictions.Text = "Manage Applictions";
            // 
            // SMItemDetainLicenses
            // 
            this.SMItemDetainLicenses.Name = "SMItemDetainLicenses";
            this.SMItemDetainLicenses.Size = new System.Drawing.Size(391, 30);
            this.SMItemDetainLicenses.Text = "Detain Licenses";
            // 
            // SMItemManageApplicationTypes
            // 
            this.SMItemManageApplicationTypes.Name = "SMItemManageApplicationTypes";
            this.SMItemManageApplicationTypes.Size = new System.Drawing.Size(391, 30);
            this.SMItemManageApplicationTypes.Text = "Manage Application Types";
            // 
            // manageTypeTestToolStripMenuItem
            // 
            this.manageTypeTestToolStripMenuItem.Name = "SMItemManageTestTypes";
            this.manageTypeTestToolStripMenuItem.Size = new System.Drawing.Size(391, 30);
            this.manageTypeTestToolStripMenuItem.Text = "Manage Test Types";
            // 
            // SMItempeople
            // 
            this.SMItempeople.Image = ((System.Drawing.Image)(resources.GetObject("SMItempeople.Image")));
            this.SMItempeople.Name = "SMItempeople";
            this.SMItempeople.Size = new System.Drawing.Size(165, 68);
            this.SMItempeople.Text = "people";
            // 
            // SMItemdrivers
            // 
            this.SMItemdrivers.Image = ((System.Drawing.Image)(resources.GetObject("SMItemdrivers.Image")));
            this.SMItemdrivers.Name = "SMItemdrivers";
            this.SMItemdrivers.Size = new System.Drawing.Size(172, 68);
            this.SMItemdrivers.Text = "Drivers";
            // 
            // SMItemusers
            // 
            this.SMItemusers.Image = ((System.Drawing.Image)(resources.GetObject("SMItemusers.Image")));
            this.SMItemusers.Name = "SMItemusers";
            this.SMItemusers.Size = new System.Drawing.Size(153, 68);
            this.SMItemusers.Text = "Users";
            // 
            // SMItemAccountSettings
            // 
            this.SMItemAccountSettings.Image = ((System.Drawing.Image)(resources.GetObject("SMItemAccountSettings.Image")));
            this.SMItemAccountSettings.Name = "SMItemAccountSettings";
            this.SMItemAccountSettings.Size = new System.Drawing.Size(280, 68);
            this.SMItemAccountSettings.Text = "Account Settings";
  
            // 
            // FOmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 499);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FOmain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FOmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SMItemApplication;
        private System.Windows.Forms.ToolStripMenuItem SMItempeople;
        private System.Windows.Forms.ToolStripMenuItem SMItemDrivingLicensesServices;
        private ToolStripMenuItem SMItemdrivers;
        private ToolStripMenuItem SMItemusers;
        private ToolStripMenuItem SMItemAccountSettings;
        private ToolStripMenuItem SMItemManageApplictions;
        private ToolStripMenuItem SMItemDetainLicenses;
        private ToolStripMenuItem SMItemManageApplicationTypes;
        private ToolStripMenuItem manageTypeTestToolStripMenuItem;
    }
}

