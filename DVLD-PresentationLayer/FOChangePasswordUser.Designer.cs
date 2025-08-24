namespace DVLD_PresentationLayer
{
    partial class FOChangePasswordUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOChangePasswordUser));
            this.LblChangePasswordUser = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.ctrDetailsUser1 = new DVLD_PresentationLayer.CtrDetailsUser();
            this.BtnAddSave = new System.Windows.Forms.Button();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.LblCurrentPassword = new System.Windows.Forms.Label();
            this.PBPassword = new System.Windows.Forms.PictureBox();
            this.PBPasswordConfirm = new System.Windows.Forms.PictureBox();
            this.PBCurrentPassword = new System.Windows.Forms.PictureBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBPasswordConfirm = new System.Windows.Forms.TextBox();
            this.TBCurrentPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrentPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // LblChangePasswordUser
            // 
            this.LblChangePasswordUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblChangePasswordUser.AutoSize = true;
            this.LblChangePasswordUser.BackColor = System.Drawing.Color.Transparent;
            this.LblChangePasswordUser.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblChangePasswordUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblChangePasswordUser.Location = new System.Drawing.Point(404, 9);
            this.LblChangePasswordUser.Name = "LblChangePasswordUser";
            this.LblChangePasswordUser.Size = new System.Drawing.Size(415, 50);
            this.LblChangePasswordUser.TabIndex = 2;
            this.LblChangePasswordUser.Text = "Change Password User";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.BackColor = System.Drawing.Color.White;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(831, 774);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 48);
            this.BtnAddClose.TabIndex = 37;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // ctrDetailsUser1
            // 
            this.ctrDetailsUser1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsUser1.Location = new System.Drawing.Point(12, 62);
            this.ctrDetailsUser1.Name = "ctrDetailsUser1";
            this.ctrDetailsUser1.Size = new System.Drawing.Size(1191, 525);
            this.ctrDetailsUser1.TabIndex = 3;
            this.ctrDetailsUser1.UserData = null;
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.BackColor = System.Drawing.Color.White;
            this.BtnAddSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSave.Image")));
            this.BtnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSave.Location = new System.Drawing.Point(1012, 774);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddSave.Size = new System.Drawing.Size(155, 48);
            this.BtnAddSave.TabIndex = 38;
            this.BtnAddSave.Text = "Save";
            this.BtnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSave.UseVisualStyleBackColor = false;
            this.BtnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblPassword.Location = new System.Drawing.Point(141, 664);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(106, 28);
            this.LblPassword.TabIndex = 39;
            this.LblPassword.Text = "Password:";
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblConfirmPassword.Location = new System.Drawing.Point(59, 727);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(188, 28);
            this.LblConfirmPassword.TabIndex = 40;
            this.LblConfirmPassword.Text = "Confirm Password:";
            // 
            // LblCurrentPassword
            // 
            this.LblCurrentPassword.AutoSize = true;
            this.LblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblCurrentPassword.Location = new System.Drawing.Point(59, 601);
            this.LblCurrentPassword.Name = "LblCurrentPassword";
            this.LblCurrentPassword.Size = new System.Drawing.Size(183, 28);
            this.LblCurrentPassword.TabIndex = 41;
            this.LblCurrentPassword.Text = "Current Password:";
            // 
            // PBPassword
            // 
            this.PBPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBPassword.ErrorImage = null;
            this.PBPassword.Image = ((System.Drawing.Image)(resources.GetObject("PBPassword.Image")));
            this.PBPassword.InitialImage = null;
            this.PBPassword.Location = new System.Drawing.Point(253, 664);
            this.PBPassword.Name = "PBPassword";
            this.PBPassword.Size = new System.Drawing.Size(40, 32);
            this.PBPassword.TabIndex = 50;
            this.PBPassword.TabStop = false;
            // 
            // PBPasswordConfirm
            // 
            this.PBPasswordConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBPasswordConfirm.ErrorImage = null;
            this.PBPasswordConfirm.Image = ((System.Drawing.Image)(resources.GetObject("PBPasswordConfirm.Image")));
            this.PBPasswordConfirm.InitialImage = null;
            this.PBPasswordConfirm.Location = new System.Drawing.Point(253, 727);
            this.PBPasswordConfirm.Name = "PBPasswordConfirm";
            this.PBPasswordConfirm.Size = new System.Drawing.Size(40, 32);
            this.PBPasswordConfirm.TabIndex = 51;
            this.PBPasswordConfirm.TabStop = false;
            // 
            // PBCurrentPassword
            // 
            this.PBCurrentPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBCurrentPassword.ErrorImage = null;
            this.PBCurrentPassword.Image = ((System.Drawing.Image)(resources.GetObject("PBCurrentPassword.Image")));
            this.PBCurrentPassword.InitialImage = null;
            this.PBCurrentPassword.Location = new System.Drawing.Point(253, 601);
            this.PBCurrentPassword.Name = "PBCurrentPassword";
            this.PBCurrentPassword.Size = new System.Drawing.Size(40, 32);
            this.PBCurrentPassword.TabIndex = 52;
            this.PBCurrentPassword.TabStop = false;
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBPassword.ForeColor = System.Drawing.Color.Black;
            this.TBPassword.Location = new System.Drawing.Point(321, 664);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(170, 30);
            this.TBPassword.TabIndex = 55;
            this.TBPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBPassword_Validating);
            // 
            // TBPasswordConfirm
            // 
            this.TBPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBPasswordConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBPasswordConfirm.ForeColor = System.Drawing.Color.Black;
            this.TBPasswordConfirm.Location = new System.Drawing.Point(321, 730);
            this.TBPasswordConfirm.Name = "TBPasswordConfirm";
            this.TBPasswordConfirm.Size = new System.Drawing.Size(170, 30);
            this.TBPasswordConfirm.TabIndex = 56;
            this.TBPasswordConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.TBPasswordConfirm_Validating);
            // 
            // TBCurrentPassword
            // 
            this.TBCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.TBCurrentPassword.Location = new System.Drawing.Point(321, 604);
            this.TBCurrentPassword.Name = "TBCurrentPassword";
            this.TBCurrentPassword.Size = new System.Drawing.Size(170, 30);
            this.TBCurrentPassword.TabIndex = 57;
            this.TBCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TBCurrentPassword_Validating);
            // 
            // FOChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 834);
            this.Controls.Add(this.TBCurrentPassword);
            this.Controls.Add(this.TBPasswordConfirm);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.PBCurrentPassword);
            this.Controls.Add(this.PBPasswordConfirm);
            this.Controls.Add(this.PBPassword);
            this.Controls.Add(this.LblCurrentPassword);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.ctrDetailsUser1);
            this.Controls.Add(this.LblChangePasswordUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOChangePasswordUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOChangePasswordUser";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPasswordConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCurrentPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblChangePasswordUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CtrDetailsUser ctrDetailsUser1;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.Button BtnAddSave;
        private System.Windows.Forms.Label LblCurrentPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.PictureBox PBPassword;
        private System.Windows.Forms.PictureBox PBCurrentPassword;
        private System.Windows.Forms.PictureBox PBPasswordConfirm;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBCurrentPassword;
        private System.Windows.Forms.TextBox TBPasswordConfirm;
    }
}