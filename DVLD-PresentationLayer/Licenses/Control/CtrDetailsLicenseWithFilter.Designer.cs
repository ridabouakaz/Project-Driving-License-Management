namespace DVLD_PresentationLayer.Licenses.Control
{
    partial class CtrDetailsLicenseWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrDetailsLicenseWithFilter));
            this.LblLicenseID = new System.Windows.Forms.Label();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
            this.BtnSearchPerson = new System.Windows.Forms.Button();
            this.GBUserControlDetailesPersonWithFilter = new System.Windows.Forms.GroupBox();
            this.ctrDetailsLicenses1 = new DVLD_PresentationLayer.CtrDetailsLicenses();
            this.GBUserControlDetailesPersonWithFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLicenseID
            // 
            this.LblLicenseID.AutoSize = true;
            this.LblLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.LblLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblLicenseID.Location = new System.Drawing.Point(33, 40);
            this.LblLicenseID.Name = "LblLicenseID";
            this.LblLicenseID.Size = new System.Drawing.Size(113, 28);
            this.LblLicenseID.TabIndex = 37;
            this.LblLicenseID.Text = "License ID:";
            // 
            // MTBsearch
            // 
            this.MTBsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.MTBsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MTBsearch.ForeColor = System.Drawing.Color.Black;
            this.MTBsearch.Location = new System.Drawing.Point(152, 40);
            this.MTBsearch.Name = "MTBsearch";
            this.MTBsearch.Size = new System.Drawing.Size(366, 30);
            this.MTBsearch.TabIndex = 2;
            this.MTBsearch.Mask = "000000";
            this.MTBsearch.PromptChar = ' ';
            this.MTBsearch.Visible = true;
            // 
            // BtnSearchPerson
            // 
            this.BtnSearchPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearchPerson.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSearchPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSearchPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSearchPerson.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchPerson.Image")));
            this.BtnSearchPerson.Location = new System.Drawing.Point(641, 40);
            this.BtnSearchPerson.Name = "BtnSearchPerson";
            this.BtnSearchPerson.Size = new System.Drawing.Size(101, 32);
            this.BtnSearchPerson.TabIndex = 3;
            this.BtnSearchPerson.UseVisualStyleBackColor = false;
            // 
            // GBUserControlDetailesPersonWithFilter
            // 
            this.GBUserControlDetailesPersonWithFilter.BackColor = System.Drawing.SystemColors.Window;
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.BtnSearchPerson);
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.MTBsearch);
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.LblLicenseID);
            this.GBUserControlDetailesPersonWithFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GBUserControlDetailesPersonWithFilter.Location = new System.Drawing.Point(17, 3);
            this.GBUserControlDetailesPersonWithFilter.Name = "GBUserControlDetailesPersonWithFilter";
            this.GBUserControlDetailesPersonWithFilter.Size = new System.Drawing.Size(802, 89);
            this.GBUserControlDetailesPersonWithFilter.TabIndex = 2;
            this.GBUserControlDetailesPersonWithFilter.TabStop = false;
            this.GBUserControlDetailesPersonWithFilter.Text = "Filter";
            // 
            // ctrDetailsLicenses1
            // 
            this.ctrDetailsLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsLicenses1.Class = "[????????]";
            this.ctrDetailsLicenses1.DateOfBirth = "[????????]";
            this.ctrDetailsLicenses1.DriverID = "[????????]";
            this.ctrDetailsLicenses1.ExpirationDate = "[????????]";
            this.ctrDetailsLicenses1.FullName = "[????????]";
            this.ctrDetailsLicenses1.ImagePath = null;
            this.ctrDetailsLicenses1.IsDetained = "[????????]";
            this.ctrDetailsLicenses1.IssueDate = "[????????]";
            this.ctrDetailsLicenses1.LicenseData = null;
            this.ctrDetailsLicenses1.LicenseID = "[????????]";
            this.ctrDetailsLicenses1.Location = new System.Drawing.Point(3, 92);
            this.ctrDetailsLicenses1.Name = "ctrDetailsLicenses1";
            this.ctrDetailsLicenses1.NationalNo = "[????????]";
            this.ctrDetailsLicenses1.Notes = "[????????]";
            this.ctrDetailsLicenses1.Size = new System.Drawing.Size(1165, 487);
            this.ctrDetailsLicenses1.TabIndex = 3;
            // 
            // CtrDetailsLicenseWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrDetailsLicenses1);
            this.Controls.Add(this.GBUserControlDetailesPersonWithFilter);
            this.Name = "CtrDetailsLicenseWithFilter";
            this.Size = new System.Drawing.Size(1175, 582);
            this.GBUserControlDetailesPersonWithFilter.ResumeLayout(false);
            this.GBUserControlDetailesPersonWithFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblLicenseID;
        private System.Windows.Forms.MaskedTextBox MTBsearch;
        private System.Windows.Forms.Button BtnSearchPerson;
        private System.Windows.Forms.GroupBox GBUserControlDetailesPersonWithFilter;
        private CtrDetailsLicenses ctrDetailsLicenses1;
    }
}
