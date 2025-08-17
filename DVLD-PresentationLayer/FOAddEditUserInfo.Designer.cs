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
            this.LblAddEditUser = new System.Windows.Forms.Label();
            this.TCAddEditUser = new System.Windows.Forms.TabControl();
            this.TPPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrDetailsPersonWithFilter1 = new DVLD_PresentationLayer.CtrDetailsPersonWithFilter();
            this.TPLoginInfo = new System.Windows.Forms.TabPage();
            this.TCAddEditUser.SuspendLayout();
            this.TPPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAddEditUser
            // 
            this.LblAddEditUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddEditUser.AutoSize = true;
            this.LblAddEditUser.BackColor = System.Drawing.Color.Transparent;
            this.LblAddEditUser.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblAddEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblAddEditUser.Location = new System.Drawing.Point(565, 9);
            this.LblAddEditUser.Name = "LblAddEditUser";
            this.LblAddEditUser.Size = new System.Drawing.Size(271, 50);
            this.LblAddEditUser.TabIndex = 3;
            this.LblAddEditUser.Text = "Add New User";
            // 
            // TCAddEditUser
            // 
            this.TCAddEditUser.Controls.Add(this.TPPersonalInfo);
            this.TCAddEditUser.Controls.Add(this.TPLoginInfo);
            this.TCAddEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCAddEditUser.Location = new System.Drawing.Point(12, 85);
            this.TCAddEditUser.Name = "TCAddEditUser";
            this.TCAddEditUser.SelectedIndex = 0;
            this.TCAddEditUser.Size = new System.Drawing.Size(1354, 788);
            this.TCAddEditUser.TabIndex = 4;
            // 
            // TPPersonalInfo
            // 
            this.TPPersonalInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPPersonalInfo.Controls.Add(this.ctrDetailsPersonWithFilter1);
            this.TPPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TPPersonalInfo.Location = new System.Drawing.Point(4, 31);
            this.TPPersonalInfo.Name = "TPPersonalInfo";
            this.TPPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPPersonalInfo.Size = new System.Drawing.Size(1346, 753);
            this.TPPersonalInfo.TabIndex = 0;
            this.TPPersonalInfo.Text = "Personal Info";
            this.TPPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrDetailsPersonWithFilter1
            // 
            this.ctrDetailsPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsPersonWithFilter1.Location = new System.Drawing.Point(0, 0);
            this.ctrDetailsPersonWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrDetailsPersonWithFilter1.Name = "ctrDetailsPersonWithFilter1";
            this.ctrDetailsPersonWithFilter1.Size = this.ctrDetailsPersonWithFilter1.PreferredSize;
            this.ctrDetailsPersonWithFilter1.TabIndex = 0;
            // 
            // TPLoginInfo
            // 
            this.TPLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPLoginInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TPLoginInfo.Location = new System.Drawing.Point(4, 31);
            this.TPLoginInfo.Name = "TPLoginInfo";
            this.TPLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPLoginInfo.Size = new System.Drawing.Size(1346, 753);
            this.TPLoginInfo.TabIndex = 1;
            this.TPLoginInfo.Text = "Login Info";
            this.TPLoginInfo.UseVisualStyleBackColor = true;
            // 
            // FOAddEditUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1378, 910);
            this.Controls.Add(this.TCAddEditUser);
            this.Controls.Add(this.LblAddEditUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOAddEditUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOAddEditUserInfo";
            this.TCAddEditUser.ResumeLayout(false);
            this.TPPersonalInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddEditUser;
        private System.Windows.Forms.TabControl TCAddEditUser;
        private System.Windows.Forms.TabPage TPPersonalInfo;
        private System.Windows.Forms.TabPage TPLoginInfo;
        private CtrDetailsPersonWithFilter ctrDetailsPersonWithFilter1;
    }
}