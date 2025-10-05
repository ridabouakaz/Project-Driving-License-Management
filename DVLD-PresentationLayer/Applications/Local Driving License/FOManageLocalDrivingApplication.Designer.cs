using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_PresentationLayer
{
    partial class FOManageLocalDrivingApplication
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManageLocalDrivingApplication));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.SMItemCRUDLocalDrivingApplications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemShowApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDLocalDrivingApplications1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDLocalDrivingApplications2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDLocalDrivingApplications3 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemScheduleVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemScheduleWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemScheduleStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDLocalDrivingApplications4 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemIssueDrivingLicenseFirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDLocalDrivingApplications5 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDLocalDrivingApplications6 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemShowPersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManageLocalDrivingApplications = new System.Windows.Forms.Label();
            this.BtnAddLocalDrivingApplication = new System.Windows.Forms.Button();
            this.PBManageLocalDrivingApplications = new System.Windows.Forms.PictureBox();
            this.LblFilterBy = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
            this.CBActiveStatusBy = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SMItemCRUDLocalDrivingApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageLocalDrivingApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dGViewShowInformation
            // 
            this.dGViewShowInformation.AllowUserToAddRows = false;
            this.dGViewShowInformation.AllowUserToDeleteRows = false;
            this.dGViewShowInformation.AllowUserToOrderColumns = true;
            this.dGViewShowInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGViewShowInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGViewShowInformation.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewShowInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.ContextMenuStrip = this.SMItemCRUDLocalDrivingApplications;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGViewShowInformation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGViewShowInformation.Location = new System.Drawing.Point(47, 279);
            this.dGViewShowInformation.Name = "dGViewShowInformation";
            this.dGViewShowInformation.ReadOnly = true;
            this.dGViewShowInformation.RowHeadersWidth = 51;
            this.dGViewShowInformation.RowTemplate.Height = 24;
            this.dGViewShowInformation.Size = new System.Drawing.Size(1439, 481);
            this.dGViewShowInformation.TabIndex = 3;
            // 
            // SMItemCRUDLocalDrivingApplications
            // 
            this.SMItemCRUDLocalDrivingApplications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMItemCRUDLocalDrivingApplications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemShowApplicationDetails,
            this.SMItemSeparatorCRUDLocalDrivingApplications1,
            this.SMItemEditApplication,
            this.SMItemDeleteApplication,
            this.SMItemSeparatorCRUDLocalDrivingApplications2,
            this.SMItemCancelApplication,
            this.SMItemSeparatorCRUDLocalDrivingApplications3,
            this.SMItemScheduleTest,
            this.SMItemSeparatorCRUDLocalDrivingApplications4,
            this.SMItemIssueDrivingLicenseFirstTime,
            this.SMItemSeparatorCRUDLocalDrivingApplications5,
            this.SMItemShowLicense,
            this.SMItemSeparatorCRUDLocalDrivingApplications6,
            this.SMItemShowPersonLicenseHistory});
            this.SMItemCRUDLocalDrivingApplications.Name = "SMItemCRUDLocalDrivingApplications";
            this.SMItemCRUDLocalDrivingApplications.Size = new System.Drawing.Size(347, 372);
            this.SMItemCRUDLocalDrivingApplications.Opening += new System.ComponentModel.CancelEventHandler(this.SMItemCRUDLocalDrivingApplications_Opening);
            // 
            // SMItemShowApplicationDetails
            // 
            this.SMItemShowApplicationDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemShowApplicationDetails.Image = ((System.Drawing.Image)(resources.GetObject("SMItemShowApplicationDetails.Image")));
            this.SMItemShowApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemShowApplicationDetails.Name = "SMItemShowApplicationDetails";
            this.SMItemShowApplicationDetails.Size = new System.Drawing.Size(346, 38);
            this.SMItemShowApplicationDetails.Text = "Show Application Details";
            this.SMItemShowApplicationDetails.Click += new System.EventHandler(this.SMItemShowApplicationDetails_Click);
            // 
            // SMItemSeparatorCRUDLocalDrivingApplications1
            // 
            this.SMItemSeparatorCRUDLocalDrivingApplications1.Name = "SMItemSeparatorCRUDLocalDrivingApplications1";
            this.SMItemSeparatorCRUDLocalDrivingApplications1.Size = new System.Drawing.Size(343, 6);
            // 
            // SMItemEditApplication
            // 
            this.SMItemEditApplication.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemEditApplication.Image = ((System.Drawing.Image)(resources.GetObject("SMItemEditApplication.Image")));
            this.SMItemEditApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemEditApplication.Name = "SMItemEditApplication";
            this.SMItemEditApplication.Size = new System.Drawing.Size(346, 38);
            this.SMItemEditApplication.Text = "Edit Application";
            // 
            // SMItemDeleteApplication
            // 
            this.SMItemDeleteApplication.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemDeleteApplication.Image = ((System.Drawing.Image)(resources.GetObject("SMItemDeleteApplication.Image")));
            this.SMItemDeleteApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemDeleteApplication.Name = "SMItemDeleteApplication";
            this.SMItemDeleteApplication.Size = new System.Drawing.Size(346, 38);
            this.SMItemDeleteApplication.Text = "Delete Application";
            this.SMItemDeleteApplication.Click += new System.EventHandler(this.SMItemDeleteApplication_Click);
            // 
            // SMItemSeparatorCRUDLocalDrivingApplications2
            // 
            this.SMItemSeparatorCRUDLocalDrivingApplications2.Name = "SMItemSeparatorCRUDLocalDrivingApplications2";
            this.SMItemSeparatorCRUDLocalDrivingApplications2.Size = new System.Drawing.Size(343, 6);
            // 
            // SMItemCancelApplication
            // 
            this.SMItemCancelApplication.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemCancelApplication.Image = ((System.Drawing.Image)(resources.GetObject("SMItemCancelApplication.Image")));
            this.SMItemCancelApplication.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemCancelApplication.Name = "SMItemCancelApplication";
            this.SMItemCancelApplication.Size = new System.Drawing.Size(346, 38);
            this.SMItemCancelApplication.Text = "Cancel Application";
            this.SMItemCancelApplication.Click += new System.EventHandler(this.SMItemCancelApplication_Click);
            // 
            // SMItemSeparatorCRUDLocalDrivingApplications3
            // 
            this.SMItemSeparatorCRUDLocalDrivingApplications3.Name = "SMItemSeparatorCRUDLocalDrivingApplications3";
            this.SMItemSeparatorCRUDLocalDrivingApplications3.Size = new System.Drawing.Size(343, 6);
            // 
            // SMItemScheduleTest
            // 
            this.SMItemScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemScheduleVisionTest,
            this.SMItemScheduleWrittenTest,
            this.SMItemScheduleStreetTest});
            this.SMItemScheduleTest.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemScheduleTest.Image = ((System.Drawing.Image)(resources.GetObject("SMItemScheduleTest.Image")));
            this.SMItemScheduleTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemScheduleTest.Name = "SMItemScheduleTest";
            this.SMItemScheduleTest.Size = new System.Drawing.Size(346, 38);
            this.SMItemScheduleTest.Text = "Schedule Test";
            // 
            // SMItemScheduleVisionTest
            // 
            this.SMItemScheduleVisionTest.Image = ((System.Drawing.Image)(resources.GetObject("SMItemScheduleVisionTest.Image")));
            this.SMItemScheduleVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemScheduleVisionTest.Name = "SMItemScheduleVisionTest";
            this.SMItemScheduleVisionTest.Size = new System.Drawing.Size(270, 38);
            this.SMItemScheduleVisionTest.Text = "Schedule Vision Test";
            this.SMItemScheduleVisionTest.Click += new System.EventHandler(this.SMItemScheduleVisionTest_Click);
            // 
            // SMItemScheduleWrittenTest
            // 
            this.SMItemScheduleWrittenTest.Image = ((System.Drawing.Image)(resources.GetObject("SMItemScheduleWrittenTest.Image")));
            this.SMItemScheduleWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemScheduleWrittenTest.Name = "SMItemScheduleWrittenTest";
            this.SMItemScheduleWrittenTest.Size = new System.Drawing.Size(270, 38);
            this.SMItemScheduleWrittenTest.Text = "Schedule Written Test";
            this.SMItemScheduleWrittenTest.Click += new System.EventHandler(this.SMItemScheduleWrittenTest_Click);
            // 
            // SMItemScheduleStreetTest
            // 
            this.SMItemScheduleStreetTest.Image = ((System.Drawing.Image)(resources.GetObject("SMItemScheduleStreetTest.Image")));
            this.SMItemScheduleStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemScheduleStreetTest.Name = "SMItemScheduleStreetTest";
            this.SMItemScheduleStreetTest.Size = new System.Drawing.Size(270, 38);
            this.SMItemScheduleStreetTest.Text = "Schedule Street Test";
            this.SMItemScheduleStreetTest.Click += new System.EventHandler(this.SMItemScheduleStreetTest_Click);
            // 
            // SMItemSeparatorCRUDLocalDrivingApplications4
            // 
            this.SMItemSeparatorCRUDLocalDrivingApplications4.Name = "SMItemSeparatorCRUDLocalDrivingApplications4";
            this.SMItemSeparatorCRUDLocalDrivingApplications4.Size = new System.Drawing.Size(343, 6);
            // 
            // SMItemIssueDrivingLicenseFirstTime
            // 
            this.SMItemIssueDrivingLicenseFirstTime.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemIssueDrivingLicenseFirstTime.Image = ((System.Drawing.Image)(resources.GetObject("SMItemIssueDrivingLicenseFirstTime.Image")));
            this.SMItemIssueDrivingLicenseFirstTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemIssueDrivingLicenseFirstTime.Name = "SMItemIssueDrivingLicenseFirstTime";
            this.SMItemIssueDrivingLicenseFirstTime.Size = new System.Drawing.Size(346, 38);
            this.SMItemIssueDrivingLicenseFirstTime.Text = "Issue Driving License (First Time)";
            this.SMItemIssueDrivingLicenseFirstTime.Click += new System.EventHandler(this.SMItemIssueDrivingLicenseFirstTime_Click);
            // 
            // SMItemSeparatorCRUDLocalDrivingApplications5
            // 
            this.SMItemSeparatorCRUDLocalDrivingApplications5.Name = "SMItemSeparatorCRUDLocalDrivingApplications5";
            this.SMItemSeparatorCRUDLocalDrivingApplications5.Size = new System.Drawing.Size(343, 6);
            // 
            // SMItemShowLicense
            // 
            this.SMItemShowLicense.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemShowLicense.Image = ((System.Drawing.Image)(resources.GetObject("SMItemShowLicense.Image")));
            this.SMItemShowLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SMItemShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemShowLicense.Name = "SMItemShowLicense";
            this.SMItemShowLicense.Size = new System.Drawing.Size(346, 38);
            this.SMItemShowLicense.Text = "Show License";
            // 
            // SMItemSeparatorCRUDLocalDrivingApplications6
            // 
            this.SMItemSeparatorCRUDLocalDrivingApplications6.Name = "SMItemSeparatorCRUDLocalDrivingApplications6";
            this.SMItemSeparatorCRUDLocalDrivingApplications6.Size = new System.Drawing.Size(343, 6);
            // 
            // SMItemShowPersonLicenseHistory
            // 
            this.SMItemShowPersonLicenseHistory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemShowPersonLicenseHistory.Image = ((System.Drawing.Image)(resources.GetObject("SMItemShowPersonLicenseHistory.Image")));
            this.SMItemShowPersonLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemShowPersonLicenseHistory.Name = "SMItemShowPersonLicenseHistory";
            this.SMItemShowPersonLicenseHistory.Size = new System.Drawing.Size(346, 38);
            this.SMItemShowPersonLicenseHistory.Text = "Show Person License History";
            // 
            // LblManageLocalDrivingApplications
            // 
            this.LblManageLocalDrivingApplications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageLocalDrivingApplications.AutoSize = true;
            this.LblManageLocalDrivingApplications.BackColor = System.Drawing.Color.Transparent;
            this.LblManageLocalDrivingApplications.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageLocalDrivingApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageLocalDrivingApplications.Location = new System.Drawing.Point(455, 172);
            this.LblManageLocalDrivingApplications.Name = "LblManageLocalDrivingApplications";
            this.LblManageLocalDrivingApplications.Size = new System.Drawing.Size(678, 54);
            this.LblManageLocalDrivingApplications.TabIndex = 1;
            this.LblManageLocalDrivingApplications.Text = "Manage Local Driving Applications";
            // 
            // BtnAddLocalDrivingApplication
            // 
            this.BtnAddLocalDrivingApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddLocalDrivingApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddLocalDrivingApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddLocalDrivingApplication.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddLocalDrivingApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddLocalDrivingApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddLocalDrivingApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddLocalDrivingApplication.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddLocalDrivingApplication.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddLocalDrivingApplication.Image")));
            this.BtnAddLocalDrivingApplication.Location = new System.Drawing.Point(1396, 228);
            this.BtnAddLocalDrivingApplication.Name = "BtnAddLocalDrivingApplication";
            this.BtnAddLocalDrivingApplication.Size = new System.Drawing.Size(90, 45);
            this.BtnAddLocalDrivingApplication.TabIndex = 2;
            this.BtnAddLocalDrivingApplication.UseVisualStyleBackColor = false;
            this.BtnAddLocalDrivingApplication.Click += new System.EventHandler(this.BtnAddLocalDrivingApplication_Click);
            // 
            // PBManageLocalDrivingApplications
            // 
            this.PBManageLocalDrivingApplications.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageLocalDrivingApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageLocalDrivingApplications.Image = ((System.Drawing.Image)(resources.GetObject("PBManageLocalDrivingApplications.Image")));
            this.PBManageLocalDrivingApplications.Location = new System.Drawing.Point(710, 31);
            this.PBManageLocalDrivingApplications.Name = "PBManageLocalDrivingApplications";
            this.PBManageLocalDrivingApplications.Size = new System.Drawing.Size(137, 125);
            this.PBManageLocalDrivingApplications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageLocalDrivingApplications.TabIndex = 2;
            this.PBManageLocalDrivingApplications.TabStop = false;
            // 
            // LblFilterBy
            // 
            this.LblFilterBy.AutoSize = true;
            this.LblFilterBy.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LblFilterBy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblFilterBy.Location = new System.Drawing.Point(44, 242);
            this.LblFilterBy.Name = "LblFilterBy";
            this.LblFilterBy.Size = new System.Drawing.Size(104, 30);
            this.LblFilterBy.TabIndex = 4;
            this.LblFilterBy.Text = "Filter By:";
            // 
            // LblRecoreds
            // 
            this.LblRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRecoreds.AutoSize = true;
            this.LblRecoreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblRecoreds.Location = new System.Drawing.Point(44, 775);
            this.LblRecoreds.Name = "LblRecoreds";
            this.LblRecoreds.Size = new System.Drawing.Size(121, 28);
            this.LblRecoreds.TabIndex = 5;
            this.LblRecoreds.Text = "# Recoreds:";
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
            this.BtnAddClose.Location = new System.Drawing.Point(1331, 775);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 4;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // CBFilterBy
            // 
            this.CBFilterBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBFilterBy.ForeColor = System.Drawing.Color.Black;
            this.CBFilterBy.FormattingEnabled = true;
            this.CBFilterBy.Items.AddRange(new object[] {
            "None",
            "D.L.AppID",
            "National No",
            "Full Name",
            "Status"});
            this.CBFilterBy.Location = new System.Drawing.Point(154, 245);
            this.CBFilterBy.Name = "CBFilterBy";
            this.CBFilterBy.Size = new System.Drawing.Size(208, 31);
            this.CBFilterBy.TabIndex = 0;
            this.CBFilterBy.SelectedIndexChanged += new System.EventHandler(this.CBFilterBy_SelectedIndexChanged);
            // 
            // LblTotalRecoreds
            // 
            this.LblTotalRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalRecoreds.AutoSize = true;
            this.LblTotalRecoreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblTotalRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTotalRecoreds.Location = new System.Drawing.Point(161, 775);
            this.LblTotalRecoreds.Name = "LblTotalRecoreds";
            this.LblTotalRecoreds.Size = new System.Drawing.Size(24, 28);
            this.LblTotalRecoreds.TabIndex = 8;
            this.LblTotalRecoreds.Text = "2";
            // 
            // MTBsearch
            // 
            this.MTBsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.MTBsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MTBsearch.ForeColor = System.Drawing.Color.Black;
            this.MTBsearch.Location = new System.Drawing.Point(371, 245);
            this.MTBsearch.Name = "MTBsearch";
            this.MTBsearch.Size = new System.Drawing.Size(249, 30);
            this.MTBsearch.TabIndex = 1;
            this.MTBsearch.TextChanged += new System.EventHandler(this.MTBsearch_TextChanged);
            // 
            // CBActiveStatusBy
            // 
            this.CBActiveStatusBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBActiveStatusBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBActiveStatusBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBActiveStatusBy.ForeColor = System.Drawing.Color.Black;
            this.CBActiveStatusBy.FormattingEnabled = true;
            this.CBActiveStatusBy.Items.AddRange(new object[] {
            "New",
            "Cancelled",
            "Completed"});
            this.CBActiveStatusBy.Location = new System.Drawing.Point(371, 245);
            this.CBActiveStatusBy.Name = "CBActiveStatusBy";
            this.CBActiveStatusBy.Size = new System.Drawing.Size(201, 31);
            this.CBActiveStatusBy.TabIndex = 10;
            this.CBActiveStatusBy.TextChanged += new System.EventHandler(this.CBActiveStatusBy_TextChanged);
            // 
            // FOManageLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 932);
            this.Controls.Add(this.CBActiveStatusBy);
            this.Controls.Add(this.MTBsearch);
            this.Controls.Add(this.LblTotalRecoreds);
            this.Controls.Add(this.CBFilterBy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblRecoreds);
            this.Controls.Add(this.LblFilterBy);
            this.Controls.Add(this.BtnAddLocalDrivingApplication);
            this.Controls.Add(this.PBManageLocalDrivingApplications);
            this.Controls.Add(this.LblManageLocalDrivingApplications);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManageLocalDrivingApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Local Driving Applications";
            this.Load += new System.EventHandler(this.FOManageLocalDrivingApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDLocalDrivingApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageLocalDrivingApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManageLocalDrivingApplications;
        private Button BtnAddLocalDrivingApplication;
        private PictureBox PBManageLocalDrivingApplications;
        private Label LblFilterBy;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDLocalDrivingApplications;
        private ToolStripMenuItem SMItemShowApplicationDetails;
        private ToolStripSeparator SMItemSeparatorCRUDLocalDrivingApplications1;
        private ToolStripMenuItem SMItemEditApplication;
        private ToolStripMenuItem SMItemDeleteApplication;
        private ToolStripMenuItem SMItemCancelApplication;
        private ToolStripSeparator SMItemSeparatorCRUDLocalDrivingApplications3;
        private ToolStripMenuItem SMItemScheduleTest;
        private ToolStripMenuItem SMItemIssueDrivingLicenseFirstTime;
        private ComboBox CBFilterBy;
        private Label LblTotalRecoreds;
        private MaskedTextBox MTBsearch;
        private ComboBox CBActiveStatusBy;
        private ToolStripSeparator SMItemSeparatorCRUDLocalDrivingApplications2;
        private ToolStripSeparator SMItemSeparatorCRUDLocalDrivingApplications5;
        private ToolStripSeparator SMItemSeparatorCRUDLocalDrivingApplications4;
        private ToolStripMenuItem SMItemShowLicense;
        private ToolStripSeparator SMItemSeparatorCRUDLocalDrivingApplications6;
        private ToolStripMenuItem SMItemShowPersonLicenseHistory;
        private ToolStripMenuItem SMItemScheduleVisionTest;
        private ToolStripMenuItem SMItemScheduleWrittenTest;
        private ToolStripMenuItem SMItemScheduleStreetTest;
    }
}