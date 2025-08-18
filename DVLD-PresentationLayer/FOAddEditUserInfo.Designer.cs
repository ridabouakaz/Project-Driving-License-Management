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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOAddEditUserInfo));
            this.LblAddEditUser = new System.Windows.Forms.Label();
            this.TCAddEditUser = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TPPersonalInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.BtnAddNext = new System.Windows.Forms.Button();
            this.TPLoginInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ctrDetailsPersonWithFilter1 = new DVLD_PresentationLayer.CtrDetailsPersonWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditUser)).BeginInit();
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
            this.LblAddEditUser.Location = new System.Drawing.Point(381, 9);
            this.LblAddEditUser.Name = "LblAddEditUser";
            this.LblAddEditUser.Size = new System.Drawing.Size(271, 50);
            this.LblAddEditUser.TabIndex = 3;
            this.LblAddEditUser.Text = "Add New User";
            // 
            // TCAddEditUser
            // 
            this.TCAddEditUser.ActiveTabFont = new System.Drawing.Font("Segoe UI", 12F);
            this.TCAddEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.TCAddEditUser.BeforeTouchSize = new System.Drawing.Size(986, 685);
            this.TCAddEditUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCAddEditUser.Controls.Add(this.TPPersonalInfo);
            this.TCAddEditUser.Controls.Add(this.TPLoginInfo);
            this.TCAddEditUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TCAddEditUser.Location = new System.Drawing.Point(12, 85);
            this.TCAddEditUser.Name = "TCAddEditUser";
            this.TCAddEditUser.Size = new System.Drawing.Size(986, 685);
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
            this.TPPersonalInfo.Size = new System.Drawing.Size(986, 638);
            this.TPPersonalInfo.TabIndex = 1;
            this.TPPersonalInfo.Text = "Personal Info";
            this.TPPersonalInfo.ThemesEnabled = false;
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
            this.BtnAddNext.Location = new System.Drawing.Point(777, 504);
            this.BtnAddNext.Name = "BtnAddNext";
            this.BtnAddNext.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddNext.Size = new System.Drawing.Size(155, 50);
            this.BtnAddNext.TabIndex = 5;
            this.BtnAddNext.Text = "Next";
            this.BtnAddNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNext.UseVisualStyleBackColor = false;
            // 
            // TPLoginInfo
            // 
            this.TPLoginInfo.BackColor = System.Drawing.Color.White;
            this.TPLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPLoginInfo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPLoginInfo.Image = null;
            this.TPLoginInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.TPLoginInfo.Location = new System.Drawing.Point(0, 48);
            this.TPLoginInfo.Name = "TPLoginInfo";
            this.TPLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPLoginInfo.ShowCloseButton = true;
            this.TPLoginInfo.Size = new System.Drawing.Size(986, 638);
            this.TPLoginInfo.TabIndex = 1;
            this.TPLoginInfo.Text = "Login Info";
            this.TPLoginInfo.ThemesEnabled = false;
            // 
            // ctrDetailsPersonWithFilter1
            // 
            this.ctrDetailsPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsPersonWithFilter1.Location = new System.Drawing.Point(21, 20);
            this.ctrDetailsPersonWithFilter1.Name = "ctrDetailsPersonWithFilter1";
            this.ctrDetailsPersonWithFilter1.Size = new System.Drawing.Size(944, 478);
            this.ctrDetailsPersonWithFilter1.TabIndex = 6;
            // 
            // FOAddEditUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1010, 910);
            this.Controls.Add(this.TCAddEditUser);
            this.Controls.Add(this.LblAddEditUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOAddEditUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOAddEditUserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditUser)).EndInit();
            this.TCAddEditUser.ResumeLayout(false);
            this.TPPersonalInfo.ResumeLayout(false);
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
    }
}