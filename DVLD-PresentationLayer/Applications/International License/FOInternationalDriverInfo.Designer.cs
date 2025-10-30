namespace DVLD_PresentationLayer.Applications.International_License
{
    partial class FOInternationalDriverInfo
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
            this.ctrDetailsApplication1 = new DVLD_PresentationLayer.CtrDetailsApplication();
            this.ctrDetailsDriverInternationalLicenseApplication1 = new DVLD_PresentationLayer.CtrDetailsDriverInternationalLicenseApplication();
            this.SuspendLayout();
            // 
            // ctrDetailsApplication1
            // 
            this.ctrDetailsApplication1.ApplicationData = null;
            this.ctrDetailsApplication1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsApplication1.Location = new System.Drawing.Point(702, 335);
            this.ctrDetailsApplication1.Name = "ctrDetailsApplication1";
            this.ctrDetailsApplication1.Size = new System.Drawing.Size(8, 8);
            this.ctrDetailsApplication1.TabIndex = 1;
            // 
            // ctrDetailsDriverInternationalLicenseApplication1
            // 
            this.ctrDetailsDriverInternationalLicenseApplication1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsDriverInternationalLicenseApplication1.Location = new System.Drawing.Point(12, 0);
            this.ctrDetailsDriverInternationalLicenseApplication1.Name = "ctrDetailsDriverInternationalLicenseApplication1";
            this.ctrDetailsDriverInternationalLicenseApplication1.Size = new System.Drawing.Size(1359, 306);
            this.ctrDetailsDriverInternationalLicenseApplication1.TabIndex = 2;
            // 
            // FOInternationalDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 450);
            this.Controls.Add(this.ctrDetailsDriverInternationalLicenseApplication1);
            this.Controls.Add(this.ctrDetailsApplication1);
            this.Name = "FOInternationalDriverInfo";
            this.Text = "International Driver Info";
            this.ResumeLayout(false);

        }

        #endregion
        private CtrDetailsApplication ctrDetailsApplication1;
        private CtrDetailsDriverInternationalLicenseApplication ctrDetailsDriverInternationalLicenseApplication1;
    }
}