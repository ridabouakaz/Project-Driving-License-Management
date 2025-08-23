namespace DVLD_PresentationLayer
{
    partial class FOUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOUserInfo));
            this.LblUserInfo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.ctrDetailsUser1 = new DVLD_PresentationLayer.CtrDetailsUser();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUserInfo
            // 
            this.LblUserInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblUserInfo.AutoSize = true;
            this.LblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblUserInfo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblUserInfo.Location = new System.Drawing.Point(483, 9);
            this.LblUserInfo.Name = "LblUserInfo";
            this.LblUserInfo.Size = new System.Drawing.Size(229, 50);
            this.LblUserInfo.TabIndex = 2;
            this.LblUserInfo.Text = "User Details";
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
            this.BtnAddClose.Location = new System.Drawing.Point(1015, 593);
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
            // FOUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 660);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.ctrDetailsUser1);
            this.Controls.Add(this.LblUserInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOUserInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOUserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label LblUserInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CtrDetailsUser ctrDetailsUser1;
        private System.Windows.Forms.Button BtnAddClose;
    }
}