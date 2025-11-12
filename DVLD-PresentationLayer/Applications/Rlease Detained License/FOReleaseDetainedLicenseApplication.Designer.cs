namespace DVLD_PresentationLayer.Applications.International_License
{
    partial class FOReleaseDetainedLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOReleaseDetainedLicenseApplication));
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.BtnIssueReplacement = new System.Windows.Forms.Button();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LLShowLicensesHistroy = new System.Windows.Forms.LinkLabel();
            this.LLShowLicensesinfo = new System.Windows.Forms.LinkLabel();
            this.ctrDetailsLicenseWithFilter1 = new DVLD_PresentationLayer.Licenses.Control.CtrDetailsLicenseWithFilter();
            this.gpDetain = new System.Windows.Forms.GroupBox();
            this.PBApplicationID = new System.Windows.Forms.PictureBox();
            this.lblvalueApplicationID = new System.Windows.Forms.Label();
            this.lblvalueTotalFees = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.PBTotalFees = new System.Windows.Forms.PictureBox();
            this.lblvalueApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.PBApplicationFees = new System.Windows.Forms.PictureBox();
            this.lblvalueFineFees = new System.Windows.Forms.Label();
            this.PBLicenseID = new System.Windows.Forms.PictureBox();
            this.lblvalueLicenseID = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.PBDetainID = new System.Windows.Forms.PictureBox();
            this.PBCreatedByUser = new System.Windows.Forms.PictureBox();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblvalueCreatedByUser = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.PBFineFees = new System.Windows.Forms.PictureBox();
            this.lblvalueDetainDate = new System.Windows.Forms.Label();
            this.PBDetainDate = new System.Windows.Forms.PictureBox();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblvalueDetainID = new System.Windows.Forms.Label();
            this.LblDetainID = new System.Windows.Forms.Label();
            this.gpDetain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTotalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLicenseID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDetainID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreatedByUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFineFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDetainDate)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHeaderTitle
            // 
            this.LblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHeaderTitle.AutoSize = true;
            this.LblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblHeaderTitle.Location = new System.Drawing.Point(282, 9);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(595, 50);
            this.LblHeaderTitle.TabIndex = 4;
            this.LblHeaderTitle.Text = "Replacement License Application";
            // 
            // BtnIssueReplacement
            // 
            this.BtnIssueReplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIssueReplacement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIssueReplacement.Enabled = false;
            this.BtnIssueReplacement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIssueReplacement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnIssueReplacement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssueReplacement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIssueReplacement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIssueReplacement.Image = ((System.Drawing.Image)(resources.GetObject("BtnIssueReplacement.Image")));
            this.BtnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssueReplacement.Location = new System.Drawing.Point(851, 787);
            this.BtnIssueReplacement.Name = "BtnIssueReplacement";
            this.BtnIssueReplacement.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnIssueReplacement.Size = new System.Drawing.Size(297, 50);
            this.BtnIssueReplacement.TabIndex = 57;
            this.BtnIssueReplacement.Text = "Issue Replacement";
            this.BtnIssueReplacement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIssueReplacement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIssueReplacement.UseVisualStyleBackColor = false;
            this.BtnIssueReplacement.Click += new System.EventHandler(this.BtnIssue_Click);
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
            this.BtnAddClose.Location = new System.Drawing.Point(595, 787);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(180, 50);
            this.BtnAddClose.TabIndex = 58;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click_1);
            // 
            // LLShowLicensesHistroy
            // 
            this.LLShowLicensesHistroy.AutoSize = true;
            this.LLShowLicensesHistroy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LLShowLicensesHistroy.Location = new System.Drawing.Point(28, 801);
            this.LLShowLicensesHistroy.Name = "LLShowLicensesHistroy";
            this.LLShowLicensesHistroy.Size = new System.Drawing.Size(197, 25);
            this.LLShowLicensesHistroy.TabIndex = 59;
            this.LLShowLicensesHistroy.TabStop = true;
            this.LLShowLicensesHistroy.Text = "Show Licenses Histroy";
            this.LLShowLicensesHistroy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLShowLicensesHistroy_LinkClicked_1);
            // 
            // LLShowLicensesinfo
            // 
            this.LLShowLicensesinfo.AutoSize = true;
            this.LLShowLicensesinfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LLShowLicensesinfo.Location = new System.Drawing.Point(231, 801);
            this.LLShowLicensesinfo.Name = "LLShowLicensesinfo";
            this.LLShowLicensesinfo.Size = new System.Drawing.Size(214, 25);
            this.LLShowLicensesinfo.TabIndex = 60;
            this.LLShowLicensesinfo.TabStop = true;
            this.LLShowLicensesinfo.Text = "Show New Licenses Info";
            this.LLShowLicensesinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLShowLicensesinfo_LinkClicked_1);
            // 
            // ctrDetailsLicenseWithFilter1
            // 
            this.ctrDetailsLicenseWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsLicenseWithFilter1.FilterEnabled = true;
            this.ctrDetailsLicenseWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ctrDetailsLicenseWithFilter1.Location = new System.Drawing.Point(0, 61);
            this.ctrDetailsLicenseWithFilter1.Margin = new System.Windows.Forms.Padding(2);
            this.ctrDetailsLicenseWithFilter1.Name = "ctrDetailsLicenseWithFilter1";
            this.ctrDetailsLicenseWithFilter1.Size = new System.Drawing.Size(1155, 500);
            this.ctrDetailsLicenseWithFilter1.TabIndex = 5;
            this.ctrDetailsLicenseWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrDetailsLicenseWithFilter1_OnLicenseSelected);
            // 
            // gpDetain
            // 
            this.gpDetain.Controls.Add(this.PBApplicationID);
            this.gpDetain.Controls.Add(this.lblvalueApplicationID);
            this.gpDetain.Controls.Add(this.lblvalueTotalFees);
            this.gpDetain.Controls.Add(this.lblApplicationID);
            this.gpDetain.Controls.Add(this.lblTotalFees);
            this.gpDetain.Controls.Add(this.PBTotalFees);
            this.gpDetain.Controls.Add(this.lblvalueApplicationFees);
            this.gpDetain.Controls.Add(this.lblApplicationFees);
            this.gpDetain.Controls.Add(this.PBApplicationFees);
            this.gpDetain.Controls.Add(this.lblvalueFineFees);
            this.gpDetain.Controls.Add(this.PBLicenseID);
            this.gpDetain.Controls.Add(this.lblvalueLicenseID);
            this.gpDetain.Controls.Add(this.lblLicenseID);
            this.gpDetain.Controls.Add(this.PBDetainID);
            this.gpDetain.Controls.Add(this.PBCreatedByUser);
            this.gpDetain.Controls.Add(this.lblCreatedByUser);
            this.gpDetain.Controls.Add(this.lblvalueCreatedByUser);
            this.gpDetain.Controls.Add(this.lblFineFees);
            this.gpDetain.Controls.Add(this.PBFineFees);
            this.gpDetain.Controls.Add(this.lblvalueDetainDate);
            this.gpDetain.Controls.Add(this.PBDetainDate);
            this.gpDetain.Controls.Add(this.lblDetainDate);
            this.gpDetain.Controls.Add(this.lblvalueDetainID);
            this.gpDetain.Controls.Add(this.LblDetainID);
            this.gpDetain.Location = new System.Drawing.Point(12, 566);
            this.gpDetain.Name = "gpDetain";
            this.gpDetain.Size = new System.Drawing.Size(1136, 184);
            this.gpDetain.TabIndex = 188;
            this.gpDetain.TabStop = false;
            this.gpDetain.Text = "Detain Info";
            // 
            // PBApplicationID
            // 
            this.PBApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("PBApplicationID.Image")));
            this.PBApplicationID.Location = new System.Drawing.Point(581, 129);
            this.PBApplicationID.Name = "PBApplicationID";
            this.PBApplicationID.Size = new System.Drawing.Size(31, 26);
            this.PBApplicationID.TabIndex = 203;
            this.PBApplicationID.TabStop = false;
            // 
            // lblvalueApplicationID
            // 
            this.lblvalueApplicationID.AutoSize = true;
            this.lblvalueApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueApplicationID.Location = new System.Drawing.Point(619, 129);
            this.lblvalueApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueApplicationID.Name = "lblvalueApplicationID";
            this.lblvalueApplicationID.Size = new System.Drawing.Size(74, 25);
            this.lblvalueApplicationID.TabIndex = 202;
            this.lblvalueApplicationID.Text = "[????]";
            // 
            // lblvalueTotalFees
            // 
            this.lblvalueTotalFees.AutoSize = true;
            this.lblvalueTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueTotalFees.Location = new System.Drawing.Point(225, 129);
            this.lblvalueTotalFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueTotalFees.Name = "lblvalueTotalFees";
            this.lblvalueTotalFees.Size = new System.Drawing.Size(74, 25);
            this.lblvalueTotalFees.TabIndex = 202;
            this.lblvalueTotalFees.Text = "[$$$$]";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(410, 129);
            this.lblApplicationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(153, 25);
            this.lblApplicationID.TabIndex = 200;
            this.lblApplicationID.Text = "Application ID:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(16, 129);
            this.lblTotalFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(122, 25);
            this.lblTotalFees.TabIndex = 200;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // PBTotalFees
            // 
            this.PBTotalFees.Image = ((System.Drawing.Image)(resources.GetObject("PBTotalFees.Image")));
            this.PBTotalFees.Location = new System.Drawing.Point(187, 129);
            this.PBTotalFees.Name = "PBTotalFees";
            this.PBTotalFees.Size = new System.Drawing.Size(31, 26);
            this.PBTotalFees.TabIndex = 201;
            this.PBTotalFees.TabStop = false;
            // 
            // lblvalueApplicationFees
            // 
            this.lblvalueApplicationFees.AutoSize = true;
            this.lblvalueApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueApplicationFees.Location = new System.Drawing.Point(225, 94);
            this.lblvalueApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueApplicationFees.Name = "lblvalueApplicationFees";
            this.lblvalueApplicationFees.Size = new System.Drawing.Size(74, 25);
            this.lblvalueApplicationFees.TabIndex = 199;
            this.lblvalueApplicationFees.Text = "[$$$$]";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(16, 94);
            this.lblApplicationFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(180, 25);
            this.lblApplicationFees.TabIndex = 197;
            this.lblApplicationFees.Text = "Application Fees:";
            // 
            // PBApplicationFees
            // 
            this.PBApplicationFees.Image = ((System.Drawing.Image)(resources.GetObject("PBApplicationFees.Image")));
            this.PBApplicationFees.Location = new System.Drawing.Point(187, 94);
            this.PBApplicationFees.Name = "PBApplicationFees";
            this.PBApplicationFees.Size = new System.Drawing.Size(31, 26);
            this.PBApplicationFees.TabIndex = 198;
            this.PBApplicationFees.TabStop = false;
            // 
            // lblvalueFineFees
            // 
            this.lblvalueFineFees.AutoSize = true;
            this.lblvalueFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueFineFees.Location = new System.Drawing.Point(619, 94);
            this.lblvalueFineFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueFineFees.Name = "lblvalueFineFees";
            this.lblvalueFineFees.Size = new System.Drawing.Size(74, 25);
            this.lblvalueFineFees.TabIndex = 196;
            this.lblvalueFineFees.Text = "[$$$$]";
            // 
            // PBLicenseID
            // 
            this.PBLicenseID.Image = ((System.Drawing.Image)(resources.GetObject("PBLicenseID.Image")));
            this.PBLicenseID.Location = new System.Drawing.Point(581, 24);
            this.PBLicenseID.Name = "PBLicenseID";
            this.PBLicenseID.Size = new System.Drawing.Size(31, 26);
            this.PBLicenseID.TabIndex = 195;
            this.PBLicenseID.TabStop = false;
            // 
            // lblvalueLicenseID
            // 
            this.lblvalueLicenseID.AutoSize = true;
            this.lblvalueLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueLicenseID.Location = new System.Drawing.Point(619, 24);
            this.lblvalueLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueLicenseID.Name = "lblvalueLicenseID";
            this.lblvalueLicenseID.Size = new System.Drawing.Size(62, 25);
            this.lblvalueLicenseID.TabIndex = 191;
            this.lblvalueLicenseID.Text = "[???]";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(410, 24);
            this.lblLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(121, 25);
            this.lblLicenseID.TabIndex = 190;
            this.lblLicenseID.Text = "License ID:";
            // 
            // PBDetainID
            // 
            this.PBDetainID.Image = ((System.Drawing.Image)(resources.GetObject("PBDetainID.Image")));
            this.PBDetainID.Location = new System.Drawing.Point(187, 24);
            this.PBDetainID.Name = "PBDetainID";
            this.PBDetainID.Size = new System.Drawing.Size(31, 26);
            this.PBDetainID.TabIndex = 183;
            this.PBDetainID.TabStop = false;
            // 
            // PBCreatedByUser
            // 
            this.PBCreatedByUser.Image = ((System.Drawing.Image)(resources.GetObject("PBCreatedByUser.Image")));
            this.PBCreatedByUser.Location = new System.Drawing.Point(581, 56);
            this.PBCreatedByUser.Name = "PBCreatedByUser";
            this.PBCreatedByUser.Size = new System.Drawing.Size(31, 26);
            this.PBCreatedByUser.TabIndex = 182;
            this.PBCreatedByUser.TabStop = false;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(410, 56);
            this.lblCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(127, 25);
            this.lblCreatedByUser.TabIndex = 181;
            this.lblCreatedByUser.Text = "Created By:";
            // 
            // lblvalueCreatedByUser
            // 
            this.lblvalueCreatedByUser.AutoSize = true;
            this.lblvalueCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueCreatedByUser.Location = new System.Drawing.Point(619, 56);
            this.lblvalueCreatedByUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueCreatedByUser.Name = "lblvalueCreatedByUser";
            this.lblvalueCreatedByUser.Size = new System.Drawing.Size(74, 25);
            this.lblvalueCreatedByUser.TabIndex = 180;
            this.lblvalueCreatedByUser.Text = "[????]";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(410, 94);
            this.lblFineFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(115, 25);
            this.lblFineFees.TabIndex = 177;
            this.lblFineFees.Text = "Fine Fees:";
            // 
            // PBFineFees
            // 
            this.PBFineFees.Image = ((System.Drawing.Image)(resources.GetObject("PBFineFees.Image")));
            this.PBFineFees.Location = new System.Drawing.Point(581, 94);
            this.PBFineFees.Name = "PBFineFees";
            this.PBFineFees.Size = new System.Drawing.Size(31, 26);
            this.PBFineFees.TabIndex = 178;
            this.PBFineFees.TabStop = false;
            // 
            // lblvalueDetainDate
            // 
            this.lblvalueDetainDate.AutoSize = true;
            this.lblvalueDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueDetainDate.Location = new System.Drawing.Point(225, 56);
            this.lblvalueDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueDetainDate.Name = "lblvalueDetainDate";
            this.lblvalueDetainDate.Size = new System.Drawing.Size(136, 25);
            this.lblvalueDetainDate.TabIndex = 176;
            this.lblvalueDetainDate.Text = "[??/??/????]";
            // 
            // PBDetainDate
            // 
            this.PBDetainDate.Image = ((System.Drawing.Image)(resources.GetObject("PBDetainDate.Image")));
            this.PBDetainDate.Location = new System.Drawing.Point(187, 56);
            this.PBDetainDate.Name = "PBDetainDate";
            this.PBDetainDate.Size = new System.Drawing.Size(31, 26);
            this.PBDetainDate.TabIndex = 175;
            this.PBDetainDate.TabStop = false;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.Location = new System.Drawing.Point(16, 56);
            this.lblDetainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(132, 25);
            this.lblDetainDate.TabIndex = 174;
            this.lblDetainDate.Text = "Detain Date:";
            // 
            // lblvalueDetainID
            // 
            this.lblvalueDetainID.AutoSize = true;
            this.lblvalueDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalueDetainID.Location = new System.Drawing.Point(225, 24);
            this.lblvalueDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalueDetainID.Name = "lblvalueDetainID";
            this.lblvalueDetainID.Size = new System.Drawing.Size(62, 25);
            this.lblvalueDetainID.TabIndex = 173;
            this.lblvalueDetainID.Text = "[???]";
            // 
            // LblDetainID
            // 
            this.LblDetainID.AutoSize = true;
            this.LblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetainID.Location = new System.Drawing.Point(16, 24);
            this.LblDetainID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDetainID.Name = "LblDetainID";
            this.LblDetainID.Size = new System.Drawing.Size(108, 25);
            this.LblDetainID.TabIndex = 172;
            this.LblDetainID.Text = "Detain ID:";
            // 
            // FOReleaseDetainedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 860);
            this.Controls.Add(this.gpDetain);
            this.Controls.Add(this.LLShowLicensesinfo);
            this.Controls.Add(this.LLShowLicensesHistroy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.BtnIssueReplacement);
            this.Controls.Add(this.ctrDetailsLicenseWithFilter1);
            this.Controls.Add(this.LblHeaderTitle);
            this.Name = "FOReleaseDetainedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.FORenewLocalDrivingLicenseApplication_Load);
            this.gpDetain.ResumeLayout(false);
            this.gpDetain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTotalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLicenseID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDetainID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreatedByUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBFineFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDetainDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeaderTitle;
        private Licenses.Control.CtrDetailsLicenseWithFilter ctrDetailsLicenseWithFilter1;
        private System.Windows.Forms.Button BtnIssueReplacement;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.LinkLabel LLShowLicensesHistroy;
        private System.Windows.Forms.LinkLabel LLShowLicensesinfo;
        private System.Windows.Forms.GroupBox gpDetain;
        private System.Windows.Forms.PictureBox PBApplicationID;
        private System.Windows.Forms.Label lblvalueApplicationID;
        private System.Windows.Forms.Label lblvalueTotalFees;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.PictureBox PBTotalFees;
        private System.Windows.Forms.Label lblvalueApplicationFees;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.PictureBox PBApplicationFees;
        private System.Windows.Forms.Label lblvalueFineFees;
        private System.Windows.Forms.PictureBox PBLicenseID;
        private System.Windows.Forms.Label lblvalueLicenseID;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.PictureBox PBDetainID;
        private System.Windows.Forms.PictureBox PBCreatedByUser;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblvalueCreatedByUser;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.PictureBox PBFineFees;
        private System.Windows.Forms.Label lblvalueDetainDate;
        private System.Windows.Forms.PictureBox PBDetainDate;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblvalueDetainID;
        private System.Windows.Forms.Label LblDetainID;
    }
}