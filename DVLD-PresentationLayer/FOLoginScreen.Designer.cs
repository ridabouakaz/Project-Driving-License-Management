namespace DVLD_PresentationLayer
{
    partial class FOLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOLoginScreen));
            this.RBRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblLoginaccount = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.PnlBackGround = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblDrivingLicenseManagement = new System.Windows.Forms.Label();
            this.PnlBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RBRememberMe
            // 
            this.RBRememberMe.AutoSize = true;
            this.RBRememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBRememberMe.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBRememberMe.Location = new System.Drawing.Point(567, 276);
            this.RBRememberMe.Name = "RBRememberMe";
            this.RBRememberMe.Size = new System.Drawing.Size(117, 20);
            this.RBRememberMe.TabIndex = 20;
            this.RBRememberMe.Text = "Remember Me.";
            this.RBRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(167)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(209)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(209)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(365, 317);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(116, 48);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Log in ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // signup_password
            // 
            this.signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(365, 235);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(322, 35);
            this.signup_password.TabIndex = 18;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(361, 210);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(87, 21);
            this.LblPassword.TabIndex = 17;
            this.LblPassword.Text = "Password:";
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(365, 153);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(322, 35);
            this.signup_username.TabIndex = 16;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(361, 128);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(91, 21);
            this.LblUsername.TabIndex = 15;
            this.LblUsername.Text = "Username:";
            // 
            // LblLoginaccount
            // 
            this.LblLoginaccount.AutoSize = true;
            this.LblLoginaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginaccount.Location = new System.Drawing.Point(360, 57);
            this.LblLoginaccount.Name = "LblLoginaccount";
            this.LblLoginaccount.Size = new System.Drawing.Size(256, 29);
            this.LblLoginaccount.TabIndex = 14;
            this.LblLoginaccount.Text = "Login To your account ";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(691, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 22);
            this.exit.TabIndex = 13;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // PnlBackGround
            // 
            this.PnlBackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(167)))), ((int)(((byte)(209)))));
            this.PnlBackGround.Controls.Add(this.pictureBox1);
            this.PnlBackGround.Controls.Add(this.LblDrivingLicenseManagement);
            this.PnlBackGround.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.PnlBackGround.Name = "PnlBackGround";
            this.PnlBackGround.Size = new System.Drawing.Size(344, 452);
            this.PnlBackGround.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblDrivingLicenseManagement
            // 
            this.LblDrivingLicenseManagement.AutoSize = true;
            this.LblDrivingLicenseManagement.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrivingLicenseManagement.ForeColor = System.Drawing.Color.White;
            this.LblDrivingLicenseManagement.Location = new System.Drawing.Point(30, 209);
            this.LblDrivingLicenseManagement.Name = "LblDrivingLicenseManagement";
            this.LblDrivingLicenseManagement.Size = new System.Drawing.Size(272, 22);
            this.LblDrivingLicenseManagement.TabIndex = 2;
            this.LblDrivingLicenseManagement.Text = "Driving License Management";
            // 
            // FOLoginScreen
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(725, 452);
            this.Controls.Add(this.RBRememberMe);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.LblLoginaccount);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.PnlBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.FOLoginScreen_Load);
            this.PnlBackGround.ResumeLayout(false);
            this.PnlBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RBRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblLoginaccount;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel PnlBackGround;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblDrivingLicenseManagement;
    }
}