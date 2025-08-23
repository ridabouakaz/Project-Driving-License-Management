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
            this.LblUserInfo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            // ctrDetailsUser1
            // 
            this.ctrDetailsUser1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsUser1.Location = new System.Drawing.Point(11, 62);
            this.ctrDetailsUser1.Name = "ctrDetailsUser1";
            this.ctrDetailsUser1.Size = new System.Drawing.Size(1191, 516);
            this.ctrDetailsUser1.TabIndex = 3;
            // 
            // FOUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 634);
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
    }
}