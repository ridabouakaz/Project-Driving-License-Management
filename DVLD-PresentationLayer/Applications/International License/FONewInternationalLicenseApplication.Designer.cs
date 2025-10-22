namespace DVLD_PresentationLayer.Applications.International_License
{
    partial class FONewInternationalLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FONewInternationalLicenseApplication));
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.ctrDetailsLicenseWithFilter1 = new DVLD_PresentationLayer.Licenses.Control.CtrDetailsLicenseWithFilter();
            this.ctrDetailsInternationalLicenseApplication1 = new DVLD_PresentationLayer.CtrDetailsInternationalLicenseApplication();
            this.BtnIssue = new System.Windows.Forms.Button();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LLShowLicensesHistroy = new System.Windows.Forms.LinkLabel();
            this.LLShowLicensesinfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LblHeaderTitle
            // 
            this.LblHeaderTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHeaderTitle.AutoSize = true;
            this.LblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblHeaderTitle.Location = new System.Drawing.Point(274, 20);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(596, 50);
            this.LblHeaderTitle.TabIndex = 4;
            this.LblHeaderTitle.Text = "International License Application";
            // 
            // ctrDetailsLicenseWithFilter1
            // 
            this.ctrDetailsLicenseWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsLicenseWithFilter1.FilterEnabled = true;
            this.ctrDetailsLicenseWithFilter1.Location = new System.Drawing.Point(0, 129);
            this.ctrDetailsLicenseWithFilter1.Name = "ctrDetailsLicenseWithFilter1";
            this.ctrDetailsLicenseWithFilter1.Size = new System.Drawing.Size(1166, 528);
            this.ctrDetailsLicenseWithFilter1.TabIndex = 5;
            this.ctrDetailsLicenseWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrDetailsLicenseWithFilter1_OnLicenseSelected);
            // 
            // ctrDetailsInternationalLicenseApplication1
            // 
            this.ctrDetailsInternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsInternationalLicenseApplication1.Location = new System.Drawing.Point(0, 674);
            this.ctrDetailsInternationalLicenseApplication1.Name = "ctrDetailsInternationalLicenseApplication1";
            this.ctrDetailsInternationalLicenseApplication1.Size = new System.Drawing.Size(1155, 229);
            this.ctrDetailsInternationalLicenseApplication1.TabIndex = 6;
            // 
            // BtnIssue
            // 
            this.BtnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIssue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIssue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIssue.Image = ((System.Drawing.Image)(resources.GetObject("BtnIssue.Image")));
            this.BtnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssue.Location = new System.Drawing.Point(993, 899);
            this.BtnIssue.Name = "BtnIssue";
            this.BtnIssue.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnIssue.Size = new System.Drawing.Size(155, 50);
            this.BtnIssue.TabIndex = 57;
            this.BtnIssue.Text = "Issue";
            this.BtnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIssue.UseVisualStyleBackColor = false;
            this.BtnIssue.Click += new System.EventHandler(this.BtnIssue_Click);
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
            this.BtnAddClose.Location = new System.Drawing.Point(817, 899);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 58;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // LLShowLicensesHistroy
            // 
            this.LLShowLicensesHistroy.AutoSize = true;
            this.LLShowLicensesHistroy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LLShowLicensesHistroy.Location = new System.Drawing.Point(26, 913);
            this.LLShowLicensesHistroy.Name = "LLShowLicensesHistroy";
            this.LLShowLicensesHistroy.Size = new System.Drawing.Size(197, 25);
            this.LLShowLicensesHistroy.TabIndex = 59;
            this.LLShowLicensesHistroy.TabStop = true;
            this.LLShowLicensesHistroy.Text = "Show Licenses Histroy";
            // 
            // LLShowLicensesinfo
            // 
            this.LLShowLicensesinfo.AutoSize = true;
            this.LLShowLicensesinfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LLShowLicensesinfo.Location = new System.Drawing.Point(252, 913);
            this.LLShowLicensesinfo.Name = "LLShowLicensesinfo";
            this.LLShowLicensesinfo.Size = new System.Drawing.Size(171, 25);
            this.LLShowLicensesinfo.TabIndex = 60;
            this.LLShowLicensesinfo.TabStop = true;
            this.LLShowLicensesinfo.Text = "Show Licenses Info";
            this.LLShowLicensesinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLShowLicensesinfo_LinkClicked);
            // 
            // FONewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 960);
            this.Controls.Add(this.LLShowLicensesinfo);
            this.Controls.Add(this.LLShowLicensesHistroy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.BtnIssue);
            this.Controls.Add(this.ctrDetailsInternationalLicenseApplication1);
            this.Controls.Add(this.ctrDetailsLicenseWithFilter1);
            this.Controls.Add(this.LblHeaderTitle);
            this.Name = "FONewInternationalLicenseApplication";
            this.Text = "New International License Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeaderTitle;
        private Licenses.Control.CtrDetailsLicenseWithFilter ctrDetailsLicenseWithFilter1;
        private CtrDetailsInternationalLicenseApplication ctrDetailsInternationalLicenseApplication1;
        private System.Windows.Forms.Button BtnIssue;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.LinkLabel LLShowLicensesHistroy;
        private System.Windows.Forms.LinkLabel LLShowLicensesinfo;
    }
}