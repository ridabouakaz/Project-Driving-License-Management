namespace DVLD_PresentationLayer.Applications.International_License
{
    partial class FOReplaceLostOrDamagedLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOReplaceLostOrDamagedLicenseApplication));
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.BtnIssueReplacement = new System.Windows.Forms.Button();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LLShowLicensesHistroy = new System.Windows.Forms.LinkLabel();
            this.LLShowLicensesinfo = new System.Windows.Forms.LinkLabel();
            this.RBLostLicense = new System.Windows.Forms.RadioButton();
            this.RBDamagedLicense = new System.Windows.Forms.RadioButton();
            this.GBRepalcementFor = new System.Windows.Forms.GroupBox();
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1 = new DVLD_PresentationLayer.CtrDetailsReplaceLostOrDamagedLicenseApplication();
            this.ctrDetailsLicenseWithFilter1 = new DVLD_PresentationLayer.Licenses.Control.CtrDetailsLicenseWithFilter();
            this.GBRepalcementFor.SuspendLayout();
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
            // RBLostLicense
            // 
            this.RBLostLicense.AutoSize = true;
            this.RBLostLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RBLostLicense.Location = new System.Drawing.Point(6, 57);
            this.RBLostLicense.Name = "RBLostLicense";
            this.RBLostLicense.Size = new System.Drawing.Size(113, 22);
            this.RBLostLicense.TabIndex = 30;
            this.RBLostLicense.TabStop = true;
            this.RBLostLicense.Text = "Lost License";
            this.RBLostLicense.UseVisualStyleBackColor = true;
            this.RBLostLicense.CheckedChanged += new System.EventHandler(this.RBLostLicense_CheckedChanged);
            // 
            // RBDamagedLicense
            // 
            this.RBDamagedLicense.AutoSize = true;
            this.RBDamagedLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RBDamagedLicense.Location = new System.Drawing.Point(6, 29);
            this.RBDamagedLicense.Name = "RBDamagedLicense";
            this.RBDamagedLicense.Size = new System.Drawing.Size(148, 22);
            this.RBDamagedLicense.TabIndex = 29;
            this.RBDamagedLicense.TabStop = true;
            this.RBDamagedLicense.Text = "Damaged License";
            this.RBDamagedLicense.UseVisualStyleBackColor = true;
            this.RBDamagedLicense.CheckedChanged += new System.EventHandler(this.RBDamagedLicense_CheckedChanged);
            // 
            // GBRepalcementFor
            // 
            this.GBRepalcementFor.Controls.Add(this.RBDamagedLicense);
            this.GBRepalcementFor.Controls.Add(this.RBLostLicense);
            this.GBRepalcementFor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GBRepalcementFor.Location = new System.Drawing.Point(867, 62);
            this.GBRepalcementFor.Name = "GBRepalcementFor";
            this.GBRepalcementFor.Size = new System.Drawing.Size(281, 86);
            this.GBRepalcementFor.TabIndex = 63;
            this.GBRepalcementFor.TabStop = false;
            this.GBRepalcementFor.Text = "Repalcement For:";
            // 
            // ctrDetailsReplaceLostOrDamagedLicenseApplication1
            // 
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.ApplicationDate = "[????????]";
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.ApplicationFees = "[????????]";
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.Location = new System.Drawing.Point(0, 566);
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.Name = "ctrDetailsReplaceLostOrDamagedLicenseApplication1";
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.ReplacedLicenseID = "[????????]";
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.Size = new System.Drawing.Size(1148, 215);
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1.TabIndex = 61;
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
            // FOReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 860);
            this.Controls.Add(this.GBRepalcementFor);
            this.Controls.Add(this.ctrDetailsReplaceLostOrDamagedLicenseApplication1);
            this.Controls.Add(this.LLShowLicensesinfo);
            this.Controls.Add(this.LLShowLicensesHistroy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.BtnIssueReplacement);
            this.Controls.Add(this.ctrDetailsLicenseWithFilter1);
            this.Controls.Add(this.LblHeaderTitle);
            this.Name = "FOReplaceLostOrDamagedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.FORenewLocalDrivingLicenseApplication_Load);
            this.GBRepalcementFor.ResumeLayout(false);
            this.GBRepalcementFor.PerformLayout();
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
        private CtrDetailsReplaceLostOrDamagedLicenseApplication ctrDetailsReplaceLostOrDamagedLicenseApplication1;
        private System.Windows.Forms.RadioButton RBLostLicense;
        private System.Windows.Forms.RadioButton RBDamagedLicense;
        private System.Windows.Forms.GroupBox GBRepalcementFor;
    }
}