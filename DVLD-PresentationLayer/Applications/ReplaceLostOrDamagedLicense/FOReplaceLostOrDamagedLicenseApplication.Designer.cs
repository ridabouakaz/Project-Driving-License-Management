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
            this.BtnRenew = new System.Windows.Forms.Button();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LLShowLicensesHistroy = new System.Windows.Forms.LinkLabel();
            this.LLShowLicensesinfo = new System.Windows.Forms.LinkLabel();
            this.ctrDetailsLicenseWithFilter1 = new DVLD_PresentationLayer.Licenses.Control.CtrDetailsLicenseWithFilter();
            this.ctrDetailsReplaceLostOrDamagedLicenseApplication1 = new DVLD_PresentationLayer.CtrDetailsReplaceLostOrDamagedLicenseApplication();
            this.plGender = new System.Windows.Forms.Panel();
            this.PBFemale = new System.Windows.Forms.PictureBox();
            this.RBFemale = new System.Windows.Forms.RadioButton();
            this.RBMale = new System.Windows.Forms.RadioButton();
            this.PBMan = new System.Windows.Forms.PictureBox();
            this.GBRepalcementFor = new System.Windows.Forms.GroupBox();
            this.plGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMan)).BeginInit();
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
            this.LblHeaderTitle.Location = new System.Drawing.Point(353, 9);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(485, 50);
            this.LblHeaderTitle.TabIndex = 4;
            this.LblHeaderTitle.Text = "Renew License Application";
            // 
            // BtnRenew
            // 
            this.BtnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRenew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRenew.Enabled = false;
            this.BtnRenew.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRenew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnRenew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRenew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRenew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRenew.Image = ((System.Drawing.Image)(resources.GetObject("BtnRenew.Image")));
            this.BtnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRenew.Location = new System.Drawing.Point(967, 787);
            this.BtnRenew.Name = "BtnRenew";
            this.BtnRenew.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnRenew.Size = new System.Drawing.Size(181, 50);
            this.BtnRenew.TabIndex = 57;
            this.BtnRenew.Text = "Renew";
            this.BtnRenew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRenew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRenew.UseVisualStyleBackColor = false;
            this.BtnRenew.Click += new System.EventHandler(this.BtnIssue_Click);
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
            this.BtnAddClose.Location = new System.Drawing.Point(781, 787);
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
            // plGender
            // 
            this.plGender.Controls.Add(this.PBFemale);
            this.plGender.Controls.Add(this.PBMan);
            this.plGender.Location = new System.Drawing.Point(93, 22);
            this.plGender.Name = "plGender";
            this.plGender.Size = new System.Drawing.Size(235, 34);
            this.plGender.TabIndex = 62;
            // 
            // PBFemale
            // 
            this.PBFemale.Image = ((System.Drawing.Image)(resources.GetObject("PBFemale.Image")));
            this.PBFemale.Location = new System.Drawing.Point(111, 1);
            this.PBFemale.Name = "PBFemale";
            this.PBFemale.Size = new System.Drawing.Size(32, 32);
            this.PBFemale.TabIndex = 28;
            this.PBFemale.TabStop = false;
            // 
            // RBFemale
            // 
            this.RBFemale.AutoSize = true;
            this.RBFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RBFemale.Location = new System.Drawing.Point(6, 46);
            this.RBFemale.Name = "RBFemale";
            this.RBFemale.Size = new System.Drawing.Size(78, 22);
            this.RBFemale.TabIndex = 30;
            this.RBFemale.TabStop = true;
            this.RBFemale.Text = "Female";
            this.RBFemale.UseVisualStyleBackColor = true;
            // 
            // RBMale
            // 
            this.RBMale.AutoSize = true;
            this.RBMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.RBMale.Location = new System.Drawing.Point(6, 29);
            this.RBMale.Name = "RBMale";
            this.RBMale.Size = new System.Drawing.Size(61, 22);
            this.RBMale.TabIndex = 29;
            this.RBMale.TabStop = true;
            this.RBMale.Text = "Male";
            this.RBMale.UseVisualStyleBackColor = true;
            // 
            // PBMan
            // 
            this.PBMan.Image = ((System.Drawing.Image)(resources.GetObject("PBMan.Image")));
            this.PBMan.Location = new System.Drawing.Point(0, 0);
            this.PBMan.Name = "PBMan";
            this.PBMan.Size = new System.Drawing.Size(32, 32);
            this.PBMan.TabIndex = 13;
            this.PBMan.TabStop = false;
            // 
            // GBRepalcementFor
            // 
            this.GBRepalcementFor.Controls.Add(this.RBMale);
            this.GBRepalcementFor.Controls.Add(this.RBFemale);
            this.GBRepalcementFor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GBRepalcementFor.Location = new System.Drawing.Point(722, 72);
            this.GBRepalcementFor.Name = "GBRepalcementFor";
            this.GBRepalcementFor.Size = new System.Drawing.Size(273, 74);
            this.GBRepalcementFor.TabIndex = 63;
            this.GBRepalcementFor.TabStop = false;
            this.GBRepalcementFor.Text = "Repalcement For";
            // 
            // FOReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 860);
            this.Controls.Add(this.GBRepalcementFor);
            this.Controls.Add(this.plGender);
            this.Controls.Add(this.ctrDetailsReplaceLostOrDamagedLicenseApplication1);
            this.Controls.Add(this.LLShowLicensesinfo);
            this.Controls.Add(this.LLShowLicensesHistroy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.BtnRenew);
            this.Controls.Add(this.ctrDetailsLicenseWithFilter1);
            this.Controls.Add(this.LblHeaderTitle);
            this.Name = "FOReplaceLostOrDamagedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New International License Application";
            this.Load += new System.EventHandler(this.FORenewLocalDrivingLicenseApplication_Load);
            this.plGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBMan)).EndInit();
            this.GBRepalcementFor.ResumeLayout(false);
            this.GBRepalcementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeaderTitle;
        private Licenses.Control.CtrDetailsLicenseWithFilter ctrDetailsLicenseWithFilter1;
        private System.Windows.Forms.Button BtnRenew;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.LinkLabel LLShowLicensesHistroy;
        private System.Windows.Forms.LinkLabel LLShowLicensesinfo;
        private CtrDetailsReplaceLostOrDamagedLicenseApplication ctrDetailsReplaceLostOrDamagedLicenseApplication1;
        private System.Windows.Forms.Panel plGender;
        private System.Windows.Forms.PictureBox PBFemale;
        private System.Windows.Forms.RadioButton RBFemale;
        private System.Windows.Forms.RadioButton RBMale;
        private System.Windows.Forms.PictureBox PBMan;
        private System.Windows.Forms.GroupBox GBRepalcementFor;
    }
}