using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    partial class FOShowPersonLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOShowPersonLicenseHistory));
            this.LblLicenseHistroy = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.PBLicenseHistroy = new System.Windows.Forms.PictureBox();
            this.GBUserControlDriverLicenses = new System.Windows.Forms.GroupBox();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.TCDriverLicenses = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TPLocal = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dGViewShowInformationLocalLicenses = new System.Windows.Forms.DataGridView();
            this.TPInternational = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dGViewShowInformationInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.BtnAddNext = new System.Windows.Forms.Button();
            this.CBIsActive = new System.Windows.Forms.CheckBox();
            this.TBPasswordConfirm = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUserName = new System.Windows.Forms.TextBox();
            this.LblValueUserID = new System.Windows.Forms.Label();
            this.PBUserID = new System.Windows.Forms.PictureBox();
            this.PBUserName = new System.Windows.Forms.PictureBox();
            this.PBPassword = new System.Windows.Forms.PictureBox();
            this.PBPasswordConfirm = new System.Windows.Forms.PictureBox();
            this.LblPasswordConfirm = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.ctrDetailsPersonWithFilter1 = new DVLD_PresentationLayer.CtrDetailsPersonWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.PBLicenseHistroy)).BeginInit();
            this.GBUserControlDriverLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCDriverLicenses)).BeginInit();
            this.TCDriverLicenses.SuspendLayout();
            this.TPLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformationLocalLicenses)).BeginInit();
            this.TPInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformationInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLicenseHistroy
            // 
            this.LblLicenseHistroy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblLicenseHistroy.AutoSize = true;
            this.LblLicenseHistroy.BackColor = System.Drawing.Color.Transparent;
            this.LblLicenseHistroy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblLicenseHistroy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblLicenseHistroy.Location = new System.Drawing.Point(507, 21);
            this.LblLicenseHistroy.Name = "LblLicenseHistroy";
            this.LblLicenseHistroy.Size = new System.Drawing.Size(308, 54);
            this.LblLicenseHistroy.TabIndex = 1;
            this.LblLicenseHistroy.Text = "License Histroy";
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
            this.BtnAddClose.Location = new System.Drawing.Point(1089, 779);
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
            // PBLicenseHistroy
            // 
            this.PBLicenseHistroy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBLicenseHistroy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBLicenseHistroy.Image = ((System.Drawing.Image)(resources.GetObject("PBLicenseHistroy.Image")));
            this.PBLicenseHistroy.Location = new System.Drawing.Point(12, 173);
            this.PBLicenseHistroy.Name = "PBLicenseHistroy";
            this.PBLicenseHistroy.Size = new System.Drawing.Size(251, 218);
            this.PBLicenseHistroy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLicenseHistroy.TabIndex = 2;
            this.PBLicenseHistroy.TabStop = false;
            // 
            // GBUserControlDriverLicenses
            // 
            this.GBUserControlDriverLicenses.Controls.Add(this.LblTotalRecoreds);
            this.GBUserControlDriverLicenses.Controls.Add(this.LblRecoreds);
            this.GBUserControlDriverLicenses.Controls.Add(this.TCDriverLicenses);
            this.GBUserControlDriverLicenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GBUserControlDriverLicenses.Location = new System.Drawing.Point(25, 504);
            this.GBUserControlDriverLicenses.Name = "GBUserControlDriverLicenses";
            this.GBUserControlDriverLicenses.Size = new System.Drawing.Size(1219, 269);
            this.GBUserControlDriverLicenses.TabIndex = 14;
            this.GBUserControlDriverLicenses.TabStop = false;
            this.GBUserControlDriverLicenses.Text = "Driver Licenses";
            // 
            // LblTotalRecoreds
            // 
            this.LblTotalRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalRecoreds.AutoSize = true;
            this.LblTotalRecoreds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LblTotalRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTotalRecoreds.Location = new System.Drawing.Point(96, 247);
            this.LblTotalRecoreds.Name = "LblTotalRecoreds";
            this.LblTotalRecoreds.Size = new System.Drawing.Size(18, 20);
            this.LblTotalRecoreds.TabIndex = 16;
            this.LblTotalRecoreds.Text = "2";
            // 
            // LblRecoreds
            // 
            this.LblRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRecoreds.AutoSize = true;
            this.LblRecoreds.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LblRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblRecoreds.Location = new System.Drawing.Point(9, 247);
            this.LblRecoreds.Name = "LblRecoreds";
            this.LblRecoreds.Size = new System.Drawing.Size(90, 20);
            this.LblRecoreds.TabIndex = 16;
            this.LblRecoreds.Text = "# Recoreds:";
            // 
            // TCDriverLicenses
            // 
            this.TCDriverLicenses.BeforeTouchSize = new System.Drawing.Size(1207, 214);
            this.TCDriverLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCDriverLicenses.Controls.Add(this.TPLocal);
            this.TCDriverLicenses.Controls.Add(this.TPInternational);
            this.TCDriverLicenses.Location = new System.Drawing.Point(6, 33);
            this.TCDriverLicenses.Name = "TCDriverLicenses";
            this.TCDriverLicenses.Size = new System.Drawing.Size(1207, 214);
            this.TCDriverLicenses.TabIndex = 0;
            this.TCDriverLicenses.TabPanelBackColor = System.Drawing.Color.White;
            this.TCDriverLicenses.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);
            this.TCDriverLicenses.ThemeName = "TabRendererIE7";
            this.TCDriverLicenses.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // TPLocal
            // 
            this.TPLocal.Controls.Add(this.dGViewShowInformationLocalLicenses);
            this.TPLocal.Image = null;
            this.TPLocal.ImageSize = new System.Drawing.Size(20, 20);
            this.TPLocal.Location = new System.Drawing.Point(0, 48);
            this.TPLocal.Name = "TPLocal";
            this.TPLocal.ShowCloseButton = true;
            this.TPLocal.Size = new System.Drawing.Size(1207, 166);
            this.TPLocal.TabIndex = 1;
            this.TPLocal.Text = "Local";
            this.TPLocal.ThemesEnabled = false;
            // 
            // dGViewShowInformationLocalLicenses
            // 
            this.dGViewShowInformationLocalLicenses.AllowUserToAddRows = false;
            this.dGViewShowInformationLocalLicenses.AllowUserToDeleteRows = false;
            this.dGViewShowInformationLocalLicenses.AllowUserToOrderColumns = true;
            this.dGViewShowInformationLocalLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGViewShowInformationLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGViewShowInformationLocalLicenses.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGViewShowInformationLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformationLocalLicenses.Location = new System.Drawing.Point(0, 3);
            this.dGViewShowInformationLocalLicenses.Name = "dGViewShowInformationLocalLicenses";
            this.dGViewShowInformationLocalLicenses.ReadOnly = true;
            this.dGViewShowInformationLocalLicenses.RowHeadersWidth = 51;
            this.dGViewShowInformationLocalLicenses.RowTemplate.Height = 24;
            this.dGViewShowInformationLocalLicenses.Size = new System.Drawing.Size(1204, 160);
            this.dGViewShowInformationLocalLicenses.TabIndex = 12;
            // 
            // TPInternational
            // 
            this.TPInternational.Controls.Add(this.dGViewShowInformationInternationalLicenses);
            this.TPInternational.Image = null;
            this.TPInternational.ImageSize = new System.Drawing.Size(20, 20);
            this.TPInternational.Location = new System.Drawing.Point(0, 48);
            this.TPInternational.Name = "TPInternational";
            this.TPInternational.ShowCloseButton = true;
            this.TPInternational.Size = new System.Drawing.Size(1207, 166);
            this.TPInternational.TabIndex = 2;
            this.TPInternational.Text = "International";
            this.TPInternational.ThemesEnabled = false;
            // 
            // dGViewShowInformationInternationalLicenses
            // 
            this.dGViewShowInformationInternationalLicenses.AllowUserToAddRows = false;
            this.dGViewShowInformationInternationalLicenses.AllowUserToDeleteRows = false;
            this.dGViewShowInformationInternationalLicenses.AllowUserToOrderColumns = true;
            this.dGViewShowInformationInternationalLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGViewShowInformationInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGViewShowInformationInternationalLicenses.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGViewShowInformationInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformationInternationalLicenses.Location = new System.Drawing.Point(1, 3);
            this.dGViewShowInformationInternationalLicenses.Name = "dGViewShowInformationInternationalLicenses";
            this.dGViewShowInformationInternationalLicenses.ReadOnly = true;
            this.dGViewShowInformationInternationalLicenses.RowHeadersWidth = 51;
            this.dGViewShowInformationInternationalLicenses.RowTemplate.Height = 24;
            this.dGViewShowInformationInternationalLicenses.Size = new System.Drawing.Size(1204, 160);
            this.dGViewShowInformationInternationalLicenses.TabIndex = 3;
            // 
            // BtnAddNext
            // 
            this.BtnAddNext.BackColor = System.Drawing.Color.White;
            this.BtnAddNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddNext.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddNext.Image")));
            this.BtnAddNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddNext.Location = new System.Drawing.Point(831, 504);
            this.BtnAddNext.Name = "BtnAddNext";
            this.BtnAddNext.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddNext.Size = new System.Drawing.Size(155, 50);
            this.BtnAddNext.TabIndex = 5;
            this.BtnAddNext.Text = "Next";
            this.BtnAddNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNext.UseVisualStyleBackColor = false;
            // 
            // CBIsActive
            // 
            this.CBIsActive.AutoSize = true;
            this.CBIsActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBIsActive.Location = new System.Drawing.Point(291, 315);
            this.CBIsActive.Name = "CBIsActive";
            this.CBIsActive.Size = new System.Drawing.Size(91, 24);
            this.CBIsActive.TabIndex = 57;
            this.CBIsActive.Text = "Is Active";
            this.CBIsActive.UseVisualStyleBackColor = true;
            // 
            // TBPasswordConfirm
            // 
            this.TBPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBPasswordConfirm.ForeColor = System.Drawing.Color.Black;
            this.TBPasswordConfirm.Location = new System.Drawing.Point(291, 264);
            this.TBPasswordConfirm.Name = "TBPasswordConfirm";
            this.TBPasswordConfirm.Size = new System.Drawing.Size(170, 30);
            this.TBPasswordConfirm.TabIndex = 55;
            this.TBPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBPassword.ForeColor = System.Drawing.Color.Black;
            this.TBPassword.Location = new System.Drawing.Point(291, 207);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(170, 30);
            this.TBPassword.TabIndex = 54;
            this.TBPassword.UseSystemPasswordChar = true;
            // 
            // TBUserName
            // 
            this.TBUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBUserName.ForeColor = System.Drawing.Color.Black;
            this.TBUserName.Location = new System.Drawing.Point(291, 150);
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(170, 30);
            this.TBUserName.TabIndex = 53;
            // 
            // LblValueUserID
            // 
            this.LblValueUserID.AutoSize = true;
            this.LblValueUserID.BackColor = System.Drawing.Color.Transparent;
            this.LblValueUserID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblValueUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueUserID.Location = new System.Drawing.Point(295, 98);
            this.LblValueUserID.Name = "LblValueUserID";
            this.LblValueUserID.Size = new System.Drawing.Size(39, 25);
            this.LblValueUserID.TabIndex = 52;
            this.LblValueUserID.Text = "???";
            // 
            // PBUserID
            // 
            this.PBUserID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBUserID.ErrorImage = null;
            this.PBUserID.Image = ((System.Drawing.Image)(resources.GetObject("PBUserID.Image")));
            this.PBUserID.InitialImage = null;
            this.PBUserID.Location = new System.Drawing.Point(223, 91);
            this.PBUserID.Name = "PBUserID";
            this.PBUserID.Size = new System.Drawing.Size(40, 32);
            this.PBUserID.TabIndex = 51;
            this.PBUserID.TabStop = false;
            // 
            // PBUserName
            // 
            this.PBUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBUserName.ErrorImage = null;
            this.PBUserName.Image = ((System.Drawing.Image)(resources.GetObject("PBUserName.Image")));
            this.PBUserName.InitialImage = null;
            this.PBUserName.Location = new System.Drawing.Point(223, 152);
            this.PBUserName.Name = "PBUserName";
            this.PBUserName.Size = new System.Drawing.Size(40, 32);
            this.PBUserName.TabIndex = 50;
            this.PBUserName.TabStop = false;
            // 
            // PBPassword
            // 
            this.PBPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBPassword.ErrorImage = null;
            this.PBPassword.Image = ((System.Drawing.Image)(resources.GetObject("PBPassword.Image")));
            this.PBPassword.InitialImage = null;
            this.PBPassword.Location = new System.Drawing.Point(223, 205);
            this.PBPassword.Name = "PBPassword";
            this.PBPassword.Size = new System.Drawing.Size(40, 32);
            this.PBPassword.TabIndex = 49;
            this.PBPassword.TabStop = false;
            // 
            // PBPasswordConfirm
            // 
            this.PBPasswordConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBPasswordConfirm.ErrorImage = null;
            this.PBPasswordConfirm.Image = ((System.Drawing.Image)(resources.GetObject("PBPasswordConfirm.Image")));
            this.PBPasswordConfirm.InitialImage = null;
            this.PBPasswordConfirm.Location = new System.Drawing.Point(223, 266);
            this.PBPasswordConfirm.Name = "PBPasswordConfirm";
            this.PBPasswordConfirm.Size = new System.Drawing.Size(40, 32);
            this.PBPasswordConfirm.TabIndex = 48;
            this.PBPasswordConfirm.TabStop = false;
            // 
            // LblPasswordConfirm
            // 
            this.LblPasswordConfirm.AutoSize = true;
            this.LblPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.LblPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblPasswordConfirm.Location = new System.Drawing.Point(9, 266);
            this.LblPasswordConfirm.Name = "LblPasswordConfirm";
            this.LblPasswordConfirm.Size = new System.Drawing.Size(188, 28);
            this.LblPasswordConfirm.TabIndex = 40;
            this.LblPasswordConfirm.Text = "Confirm Password:";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.BackColor = System.Drawing.Color.Transparent;
            this.LblUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblUserID.Location = new System.Drawing.Point(117, 95);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(80, 28);
            this.LblUserID.TabIndex = 39;
            this.LblUserID.Text = "UserID:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.BackColor = System.Drawing.Color.Transparent;
            this.LblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblUserName.Location = new System.Drawing.Point(82, 152);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(115, 28);
            this.LblUserName.TabIndex = 38;
            this.LblUserName.Text = "UserName:";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblPassword.Location = new System.Drawing.Point(91, 209);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(106, 28);
            this.LblPassword.TabIndex = 37;
            this.LblPassword.Text = "Password:";
            // 
            // ctrDetailsPersonWithFilter1
            // 
            this.ctrDetailsPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsPersonWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.ctrDetailsPersonWithFilter1.Location = new System.Drawing.Point(272, 86);
            this.ctrDetailsPersonWithFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrDetailsPersonWithFilter1.Name = "ctrDetailsPersonWithFilter1";
            this.ctrDetailsPersonWithFilter1.PersonData = null;
            this.ctrDetailsPersonWithFilter1.Size = new System.Drawing.Size(982, 426);
            this.ctrDetailsPersonWithFilter1.TabIndex = 15;
            // 
            // FOShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 853);
            this.Controls.Add(this.ctrDetailsPersonWithFilter1);
            this.Controls.Add(this.GBUserControlDriverLicenses);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.PBLicenseHistroy);
            this.Controls.Add(this.LblLicenseHistroy);
            this.Name = "FOShowPersonLicenseHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Test Appointments";
            this.Load += new System.EventHandler(this.FOShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBLicenseHistroy)).EndInit();
            this.GBUserControlDriverLicenses.ResumeLayout(false);
            this.GBUserControlDriverLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TCDriverLicenses)).EndInit();
            this.TCDriverLicenses.ResumeLayout(false);
            this.TPLocal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformationLocalLicenses)).EndInit();
            this.TPInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformationInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblLicenseHistroy;
        private PictureBox PBLicenseHistroy;
        private Button BtnAddClose;
        private GroupBox GBUserControlDriverLicenses;

        private Button BtnAddNext;
        private CheckBox CBIsActive;
        private TextBox TBPasswordConfirm;
        private TextBox TBPassword;
        private TextBox TBUserName;
        private Label LblValueUserID;
        private PictureBox PBUserID;
        private PictureBox PBUserName;
        private PictureBox PBPassword;
        private PictureBox PBPasswordConfirm;
        private Label LblPasswordConfirm;
        private Label LblUserID;
        private Label LblUserName;
        private Label LblPassword;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv TCDriverLicenses;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPLocal;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPInternational;
        private DataGridView dGViewShowInformationLocalLicenses;
        private DataGridView dGViewShowInformationInternationalLicenses;
        private CtrDetailsPersonWithFilter ctrDetailsPersonWithFilter1;
        private Label LblRecoreds;
        private Label LblTotalRecoreds;
    }
}