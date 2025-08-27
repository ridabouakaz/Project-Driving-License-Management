namespace DVLD_PresentationLayer
{
    partial class FONewLocalDrivingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FONewLocalDrivingApplication));
            this.LblAddEditApplication = new System.Windows.Forms.Label();
            this.TCAddEditApplication = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TPPersonalInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ctrDetailsPersonWithFilter1 = new DVLD_PresentationLayer.CtrDetailsPersonWithFilter();
            this.BtnAddNext = new System.Windows.Forms.Button();
            this.TPLoginInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.CBIsActive = new System.Windows.Forms.CheckBox();
            this.TBPasswordConfirm = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBApplicationName = new System.Windows.Forms.TextBox();
            this.LblValueApplicationID = new System.Windows.Forms.Label();
            this.PBApplicationID = new System.Windows.Forms.PictureBox();
            this.PBApplicationName = new System.Windows.Forms.PictureBox();
            this.PBPassword = new System.Windows.Forms.PictureBox();
            this.PBPasswordConfirm = new System.Windows.Forms.PictureBox();
            this.LblPasswordConfirm = new System.Windows.Forms.Label();
            this.LblApplicationID = new System.Windows.Forms.Label();
            this.LblApplicationName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.BtnAddSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditApplication)).BeginInit();
            this.TCAddEditApplication.SuspendLayout();
            this.TPPersonalInfo.SuspendLayout();
            this.TPLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddEditApplication
            // 
            this.LblAddEditApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddEditApplication.AutoSize = true;
            this.LblAddEditApplication.BackColor = System.Drawing.Color.Transparent;
            this.LblAddEditApplication.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblAddEditApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblAddEditApplication.Location = new System.Drawing.Point(341, 9);
            this.LblAddEditApplication.Name = "LblAddEditApplication";
            this.LblAddEditApplication.Size = new System.Drawing.Size(395, 50);
            this.LblAddEditApplication.TabIndex = 3;
            this.LblAddEditApplication.Text = "Add New Application";
            // 
            // TCAddEditApplication
            // 
            this.TCAddEditApplication.ActiveTabFont = new System.Drawing.Font("Segoe UI", 12F);
            this.TCAddEditApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.TCAddEditApplication.BeforeTouchSize = new System.Drawing.Size(1028, 685);
            this.TCAddEditApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCAddEditApplication.Controls.Add(this.TPPersonalInfo);
            this.TCAddEditApplication.Controls.Add(this.TPLoginInfo);
            this.TCAddEditApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TCAddEditApplication.Location = new System.Drawing.Point(12, 85);
            this.TCAddEditApplication.Name = "TCAddEditApplication";
            this.TCAddEditApplication.Size = new System.Drawing.Size(1028, 685);
            this.TCAddEditApplication.TabIndex = 4;
            this.TCAddEditApplication.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.TCAddEditApplication.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);
            this.TCAddEditApplication.ThemeName = "TabRendererIE7";
            this.TCAddEditApplication.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            // 
            // TPPersonalInfo
            // 
            this.TPPersonalInfo.BackColor = System.Drawing.Color.White;
            this.TPPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPPersonalInfo.Controls.Add(this.ctrDetailsPersonWithFilter1);
            this.TPPersonalInfo.Controls.Add(this.BtnAddNext);
            this.TPPersonalInfo.Font = new System.Drawing.Font("Segoe UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPPersonalInfo.Image = null;
            this.TPPersonalInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.TPPersonalInfo.Location = new System.Drawing.Point(0, 48);
            this.TPPersonalInfo.Name = "TPPersonalInfo";
            this.TPPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPPersonalInfo.ShowCloseButton = true;
            this.TPPersonalInfo.Size = new System.Drawing.Size(1028, 638);
            this.TPPersonalInfo.TabIndex = 1;
            this.TPPersonalInfo.Text = "Personal Info";
            this.TPPersonalInfo.ThemesEnabled = false;
            // 
            // ctrDetailsPersonWithFilter1
            // 
            this.ctrDetailsPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsPersonWithFilter1.Location = new System.Drawing.Point(21, 20);
            this.ctrDetailsPersonWithFilter1.Name = "ctrDetailsPersonWithFilter1";
            this.ctrDetailsPersonWithFilter1.PersonData = null;
            this.ctrDetailsPersonWithFilter1.Size = new System.Drawing.Size(979, 478);
            this.ctrDetailsPersonWithFilter1.TabIndex = 6;
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
            this.BtnAddNext.Click += new System.EventHandler(this.BtnAddNext_Click);
            // 
            // TPLoginInfo
            // 
            this.TPLoginInfo.BackColor = System.Drawing.Color.White;
            this.TPLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPLoginInfo.Controls.Add(this.CBIsActive);
            this.TPLoginInfo.Controls.Add(this.TBPasswordConfirm);
            this.TPLoginInfo.Controls.Add(this.TBPassword);
            this.TPLoginInfo.Controls.Add(this.TBApplicationName);
            this.TPLoginInfo.Controls.Add(this.LblValueApplicationID);
            this.TPLoginInfo.Controls.Add(this.PBApplicationID);
            this.TPLoginInfo.Controls.Add(this.PBApplicationName);
            this.TPLoginInfo.Controls.Add(this.PBPassword);
            this.TPLoginInfo.Controls.Add(this.PBPasswordConfirm);
            this.TPLoginInfo.Controls.Add(this.LblPasswordConfirm);
            this.TPLoginInfo.Controls.Add(this.LblApplicationID);
            this.TPLoginInfo.Controls.Add(this.LblApplicationName);
            this.TPLoginInfo.Controls.Add(this.LblPassword);
            this.TPLoginInfo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPLoginInfo.Image = null;
            this.TPLoginInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.TPLoginInfo.Location = new System.Drawing.Point(0, 48);
            this.TPLoginInfo.Name = "TPLoginInfo";
            this.TPLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPLoginInfo.ShowCloseButton = true;
            this.TPLoginInfo.Size = new System.Drawing.Size(1028, 638);
            this.TPLoginInfo.TabIndex = 1;
            this.TPLoginInfo.Text = "Login Info";
            this.TPLoginInfo.ThemesEnabled = false;
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
            this.TBPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.TBPasswordConfirm_Validating);
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
            this.TBPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBPassword_Validating);
            // 
            // TBApplicationName
            // 
            this.TBApplicationName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBApplicationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBApplicationName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBApplicationName.ForeColor = System.Drawing.Color.Black;
            this.TBApplicationName.Location = new System.Drawing.Point(291, 150);
            this.TBApplicationName.Name = "TBApplicationName";
            this.TBApplicationName.Size = new System.Drawing.Size(170, 30);
            this.TBApplicationName.TabIndex = 53;
            // 
            // LblValueApplicationID
            // 
            this.LblValueApplicationID.AutoSize = true;
            this.LblValueApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblValueApplicationID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblValueApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueApplicationID.Location = new System.Drawing.Point(295, 98);
            this.LblValueApplicationID.Name = "LblValueApplicationID";
            this.LblValueApplicationID.Size = new System.Drawing.Size(39, 25);
            this.LblValueApplicationID.TabIndex = 52;
            this.LblValueApplicationID.Text = "???";
            // 
            // PBApplicationID
            // 
            this.PBApplicationID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBApplicationID.ErrorImage = null;
            this.PBApplicationID.InitialImage = null;
            this.PBApplicationID.Location = new System.Drawing.Point(223, 91);
            this.PBApplicationID.Name = "PBApplicationID";
            this.PBApplicationID.Size = new System.Drawing.Size(40, 32);
            this.PBApplicationID.TabIndex = 51;
            this.PBApplicationID.TabStop = false;
            // 
            // PBApplicationName
            // 
            this.PBApplicationName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBApplicationName.ErrorImage = null;
            this.PBApplicationName.InitialImage = null;
            this.PBApplicationName.Location = new System.Drawing.Point(223, 152);
            this.PBApplicationName.Name = "PBApplicationName";
            this.PBApplicationName.Size = new System.Drawing.Size(40, 32);
            this.PBApplicationName.TabIndex = 50;
            this.PBApplicationName.TabStop = false;
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
            // LblApplicationID
            // 
            this.LblApplicationID.AutoSize = true;
            this.LblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicationID.Location = new System.Drawing.Point(117, 95);
            this.LblApplicationID.Name = "LblApplicationID";
            this.LblApplicationID.Size = new System.Drawing.Size(147, 28);
            this.LblApplicationID.TabIndex = 39;
            this.LblApplicationID.Text = "ApplicationID:";
            // 
            // LblApplicationName
            // 
            this.LblApplicationName.AutoSize = true;
            this.LblApplicationName.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicationName.Location = new System.Drawing.Point(82, 152);
            this.LblApplicationName.Name = "LblApplicationName";
            this.LblApplicationName.Size = new System.Drawing.Size(182, 28);
            this.LblApplicationName.TabIndex = 38;
            this.LblApplicationName.Text = "ApplicationName:";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(291, 315);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Is Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(741, 777);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(142, 48);
            this.BtnAddClose.TabIndex = 35;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSave.Image")));
            this.BtnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSave.Location = new System.Drawing.Point(910, 777);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddSave.Size = new System.Drawing.Size(130, 48);
            this.BtnAddSave.TabIndex = 36;
            this.BtnAddSave.Text = "Save";
            this.BtnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSave.UseVisualStyleBackColor = false;
            this.BtnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // FONewLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1054, 910);
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.TCAddEditApplication);
            this.Controls.Add(this.LblAddEditApplication);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FONewLocalDrivingApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving Application";
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditApplication)).EndInit();
            this.TCAddEditApplication.ResumeLayout(false);
            this.TPPersonalInfo.ResumeLayout(false);
            this.TPLoginInfo.ResumeLayout(false);
            this.TPLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddEditApplication;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv TCAddEditApplication;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPPersonalInfo;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPLoginInfo;
        private System.Windows.Forms.Button BtnAddNext;
        private CtrDetailsPersonWithFilter ctrDetailsPersonWithFilter1;
        private System.Windows.Forms.Label LblPasswordConfirm;
        private System.Windows.Forms.Label LblApplicationID;
        private System.Windows.Forms.Label LblApplicationName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.PictureBox PBApplicationID;
        private System.Windows.Forms.PictureBox PBApplicationName;
        private System.Windows.Forms.PictureBox PBPassword;
        private System.Windows.Forms.PictureBox PBPasswordConfirm;
        private System.Windows.Forms.Label LblValueApplicationID;
        private System.Windows.Forms.TextBox TBPasswordConfirm;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBApplicationName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox CBIsActive;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.Button BtnAddSave;
    }
}