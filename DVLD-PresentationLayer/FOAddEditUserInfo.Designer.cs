namespace DVLD_PresentationLayer
{
    partial class FOAddEditUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOAddEditUserInfo));
            this.LblAddEditUser = new System.Windows.Forms.Label();
            this.TCAddEditUser = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TPPersonalInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ctrDetailsPersonWithFilter1 = new DVLD_PresentationLayer.CtrDetailsPersonWithFilter();
            this.BtnAddNext = new System.Windows.Forms.Button();
            this.TPLoginInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.BtnAddSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditUser)).BeginInit();
            this.TCAddEditUser.SuspendLayout();
            this.TPPersonalInfo.SuspendLayout();
            this.TPLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddEditUser
            // 
            this.LblAddEditUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddEditUser.AutoSize = true;
            this.LblAddEditUser.BackColor = System.Drawing.Color.Transparent;
            this.LblAddEditUser.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblAddEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblAddEditUser.Location = new System.Drawing.Point(403, 9);
            this.LblAddEditUser.Name = "LblAddEditUser";
            this.LblAddEditUser.Size = new System.Drawing.Size(271, 50);
            this.LblAddEditUser.TabIndex = 3;
            this.LblAddEditUser.Text = "Add New User";
            // 
            // TCAddEditUser
            // 
            this.TCAddEditUser.ActiveTabFont = new System.Drawing.Font("Segoe UI", 12F);
            this.TCAddEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.TCAddEditUser.BeforeTouchSize = new System.Drawing.Size(1028, 685);
            this.TCAddEditUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCAddEditUser.Controls.Add(this.TPPersonalInfo);
            this.TCAddEditUser.Controls.Add(this.TPLoginInfo);
            this.TCAddEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TCAddEditUser.Location = new System.Drawing.Point(12, 85);
            this.TCAddEditUser.Name = "TCAddEditUser";
            this.TCAddEditUser.Size = new System.Drawing.Size(1028, 685);
            this.TCAddEditUser.TabIndex = 4;
            this.TCAddEditUser.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.TCAddEditUser.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);
            this.TCAddEditUser.ThemeName = "TabRendererIE7";
            this.TCAddEditUser.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
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
            this.TPLoginInfo.Controls.Add(this.TBUserName);
            this.TPLoginInfo.Controls.Add(this.LblValueUserID);
            this.TPLoginInfo.Controls.Add(this.PBUserID);
            this.TPLoginInfo.Controls.Add(this.PBUserName);
            this.TPLoginInfo.Controls.Add(this.PBPassword);
            this.TPLoginInfo.Controls.Add(this.PBPasswordConfirm);
            this.TPLoginInfo.Controls.Add(this.LblPasswordConfirm);
            this.TPLoginInfo.Controls.Add(this.LblUserID);
            this.TPLoginInfo.Controls.Add(this.LblUserName);
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
            this.TBUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TBUserName_Validating);
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
            // FOAddEditUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1054, 910);
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.TCAddEditUser);
            this.Controls.Add(this.LblAddEditUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOAddEditUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOAddEditUserInfo";
            this.Load += new System.EventHandler(this.FOAddEditUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditUser)).EndInit();
            this.TCAddEditUser.ResumeLayout(false);
            this.TPPersonalInfo.ResumeLayout(false);
            this.TPLoginInfo.ResumeLayout(false);
            this.TPLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddEditUser;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv TCAddEditUser;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPPersonalInfo;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPLoginInfo;
        private System.Windows.Forms.Button BtnAddNext;
        private CtrDetailsPersonWithFilter ctrDetailsPersonWithFilter1;
        private System.Windows.Forms.Label LblPasswordConfirm;
        private System.Windows.Forms.Label LblUserID;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.PictureBox PBUserID;
        private System.Windows.Forms.PictureBox PBUserName;
        private System.Windows.Forms.PictureBox PBPassword;
        private System.Windows.Forms.PictureBox PBPasswordConfirm;
        private System.Windows.Forms.Label LblValueUserID;
        private System.Windows.Forms.TextBox TBPasswordConfirm;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUserName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox CBIsActive;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.Button BtnAddSave;
    }
}