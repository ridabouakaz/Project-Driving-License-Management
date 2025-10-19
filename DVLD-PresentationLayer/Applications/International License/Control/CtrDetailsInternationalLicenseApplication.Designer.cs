using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class CtrDetailsInternationalLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrDetailsInternationalLicenseApplication));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OFDialogPictureImage = new System.Windows.Forms.OpenFileDialog();
            this.GBUserControlDetailesApplication = new System.Windows.Forms.GroupBox();
            this.PBApplicationID = new System.Windows.Forms.PictureBox();
            this.LblValueILApplicationID = new System.Windows.Forms.Label();
            this.LblvalueExpirationDate = new System.Windows.Forms.Label();
            this.LblvalueLocalLicenseID = new System.Windows.Forms.Label();
            this.LblvalueLLicenseID = new System.Windows.Forms.Label();
            this.LblvalueCreatedBy = new System.Windows.Forms.Label();
            this.LblValueIssueDate = new System.Windows.Forms.Label();
            this.LblValueApplicationDate = new System.Windows.Forms.Label();
            this.LblValueFees = new System.Windows.Forms.Label();
            this.PBGender = new System.Windows.Forms.PictureBox();
            this.LblILApplicationID = new System.Windows.Forms.Label();
            this.PBCountry = new System.Windows.Forms.PictureBox();
            this.PBPhone = new System.Windows.Forms.PictureBox();
            this.PBDateOfBrith = new System.Windows.Forms.PictureBox();
            this.LblExpirationDate = new System.Windows.Forms.Label();
            this.LblLocalLicenseID = new System.Windows.Forms.Label();
            this.LblILLicenseID = new System.Windows.Forms.Label();
            this.PBEmail = new System.Windows.Forms.PictureBox();
            this.PBNationalNo = new System.Windows.Forms.PictureBox();
            this.PBName = new System.Windows.Forms.PictureBox();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.LblFees = new System.Windows.Forms.Label();
            this.LblIssueDate = new System.Windows.Forms.Label();
            this.LblApplicationDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.GBUserControlDetailesApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDateOfBrith)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNationalNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OFDialogPictureImage
            // 
            this.OFDialogPictureImage.FileName = "OFDialogPictureImage";
            // 
            // GBUserControlDetailesApplication
            // 
            this.GBUserControlDetailesApplication.BackColor = System.Drawing.Color.White;
            this.GBUserControlDetailesApplication.Controls.Add(this.PBApplicationID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueILApplicationID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueExpirationDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueLocalLicenseID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueLLicenseID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueCreatedBy);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueIssueDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueApplicationDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueFees);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBGender);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblILApplicationID);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBCountry);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBPhone);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBDateOfBrith);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblExpirationDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblLocalLicenseID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblILLicenseID);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBEmail);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBNationalNo);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBName);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblCreatedBy);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblFees);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblIssueDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblApplicationDate);
            this.GBUserControlDetailesApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GBUserControlDetailesApplication.Location = new System.Drawing.Point(18, 3);
            this.GBUserControlDetailesApplication.Name = "GBUserControlDetailesApplication";
            this.GBUserControlDetailesApplication.Size = new System.Drawing.Size(1130, 217);
            this.GBUserControlDetailesApplication.TabIndex = 48;
            this.GBUserControlDetailesApplication.TabStop = false;
            this.GBUserControlDetailesApplication.Text = "Application Basic Info";
            // 
            // PBApplicationID
            // 
            this.PBApplicationID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBApplicationID.ErrorImage = null;
            this.PBApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("PBApplicationID.Image")));
            this.PBApplicationID.InitialImage = null;
            this.PBApplicationID.Location = new System.Drawing.Point(201, 37);
            this.PBApplicationID.Name = "PBApplicationID";
            this.PBApplicationID.Size = new System.Drawing.Size(40, 32);
            this.PBApplicationID.TabIndex = 47;
            this.PBApplicationID.TabStop = false;
            // 
            // LblValueILApplicationID
            // 
            this.LblValueILApplicationID.AutoSize = true;
            this.LblValueILApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblValueILApplicationID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueILApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueILApplicationID.Location = new System.Drawing.Point(282, 37);
            this.LblValueILApplicationID.Name = "LblValueILApplicationID";
            this.LblValueILApplicationID.Size = new System.Drawing.Size(90, 25);
            this.LblValueILApplicationID.TabIndex = 46;
            this.LblValueILApplicationID.Text = "[????????]";
            // 
            // LblvalueExpirationDate
            // 
            this.LblvalueExpirationDate.AutoSize = true;
            this.LblvalueExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueExpirationDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueExpirationDate.Location = new System.Drawing.Point(984, 117);
            this.LblvalueExpirationDate.Name = "LblvalueExpirationDate";
            this.LblvalueExpirationDate.Size = new System.Drawing.Size(90, 25);
            this.LblvalueExpirationDate.TabIndex = 45;
            this.LblvalueExpirationDate.Text = "[????????]";
            // 
            // LblvalueLocalLicenseID
            // 
            this.LblvalueLocalLicenseID.AutoSize = true;
            this.LblvalueLocalLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueLocalLicenseID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueLocalLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueLocalLicenseID.Location = new System.Drawing.Point(984, 79);
            this.LblvalueLocalLicenseID.Name = "LblvalueLocalLicenseID";
            this.LblvalueLocalLicenseID.Size = new System.Drawing.Size(90, 25);
            this.LblvalueLocalLicenseID.TabIndex = 44;
            this.LblvalueLocalLicenseID.Text = "[????????]";
            // 
            // LblvalueLLicenseID
            // 
            this.LblvalueLLicenseID.AutoSize = true;
            this.LblvalueLLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueLLicenseID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueLLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueLLicenseID.Location = new System.Drawing.Point(984, 41);
            this.LblvalueLLicenseID.Name = "LblvalueLLicenseID";
            this.LblvalueLLicenseID.Size = new System.Drawing.Size(90, 25);
            this.LblvalueLLicenseID.TabIndex = 43;
            this.LblvalueLLicenseID.Text = "[????????]";
            // 
            // LblvalueCreatedBy
            // 
            this.LblvalueCreatedBy.AutoSize = true;
            this.LblvalueCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueCreatedBy.Location = new System.Drawing.Point(984, 158);
            this.LblvalueCreatedBy.Name = "LblvalueCreatedBy";
            this.LblvalueCreatedBy.Size = new System.Drawing.Size(90, 25);
            this.LblvalueCreatedBy.TabIndex = 41;
            this.LblvalueCreatedBy.Text = "[????????]";
            // 
            // LblValueIssueDate
            // 
            this.LblValueIssueDate.AutoSize = true;
            this.LblValueIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.LblValueIssueDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueIssueDate.Location = new System.Drawing.Point(282, 117);
            this.LblValueIssueDate.Name = "LblValueIssueDate";
            this.LblValueIssueDate.Size = new System.Drawing.Size(90, 25);
            this.LblValueIssueDate.TabIndex = 40;
            this.LblValueIssueDate.Text = "[????????]";
            // 
            // LblValueApplicationDate
            // 
            this.LblValueApplicationDate.AutoSize = true;
            this.LblValueApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.LblValueApplicationDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.LblValueApplicationDate.Location = new System.Drawing.Point(282, 79);
            this.LblValueApplicationDate.Name = "LblValueApplicationDate";
            this.LblValueApplicationDate.Size = new System.Drawing.Size(90, 25);
            this.LblValueApplicationDate.TabIndex = 39;
            this.LblValueApplicationDate.Text = "[????????]";
            // 
            // LblValueFees
            // 
            this.LblValueFees.AutoSize = true;
            this.LblValueFees.BackColor = System.Drawing.Color.Transparent;
            this.LblValueFees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueFees.Location = new System.Drawing.Point(282, 155);
            this.LblValueFees.Name = "LblValueFees";
            this.LblValueFees.Size = new System.Drawing.Size(90, 25);
            this.LblValueFees.TabIndex = 38;
            this.LblValueFees.Text = "[????????]";
            // 
            // PBGender
            // 
            this.PBGender.Image = ((System.Drawing.Image)(resources.GetObject("PBGender.Image")));
            this.PBGender.Location = new System.Drawing.Point(201, 155);
            this.PBGender.Name = "PBGender";
            this.PBGender.Size = new System.Drawing.Size(40, 32);
            this.PBGender.TabIndex = 37;
            this.PBGender.TabStop = false;
            // 
            // LblILApplicationID
            // 
            this.LblILApplicationID.AutoSize = true;
            this.LblILApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblILApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblILApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblILApplicationID.Location = new System.Drawing.Point(16, 37);
            this.LblILApplicationID.Name = "LblILApplicationID";
            this.LblILApplicationID.Size = new System.Drawing.Size(179, 28);
            this.LblILApplicationID.TabIndex = 36;
            this.LblILApplicationID.Text = "I.L.Application ID:";
            // 
            // PBCountry
            // 
            this.PBCountry.Image = ((System.Drawing.Image)(resources.GetObject("PBCountry.Image")));
            this.PBCountry.Location = new System.Drawing.Point(912, 113);
            this.PBCountry.Name = "PBCountry";
            this.PBCountry.Size = new System.Drawing.Size(40, 32);
            this.PBCountry.TabIndex = 27;
            this.PBCountry.TabStop = false;
            // 
            // PBPhone
            // 
            this.PBPhone.Image = ((System.Drawing.Image)(resources.GetObject("PBPhone.Image")));
            this.PBPhone.Location = new System.Drawing.Point(912, 75);
            this.PBPhone.Name = "PBPhone";
            this.PBPhone.Size = new System.Drawing.Size(40, 32);
            this.PBPhone.TabIndex = 26;
            this.PBPhone.TabStop = false;
            // 
            // PBDateOfBrith
            // 
            this.PBDateOfBrith.Image = ((System.Drawing.Image)(resources.GetObject("PBDateOfBrith.Image")));
            this.PBDateOfBrith.Location = new System.Drawing.Point(912, 37);
            this.PBDateOfBrith.Name = "PBDateOfBrith";
            this.PBDateOfBrith.Size = new System.Drawing.Size(40, 32);
            this.PBDateOfBrith.TabIndex = 25;
            this.PBDateOfBrith.TabStop = false;
            // 
            // LblExpirationDate
            // 
            this.LblExpirationDate.AutoSize = true;
            this.LblExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.LblExpirationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblExpirationDate.Location = new System.Drawing.Point(726, 117);
            this.LblExpirationDate.Name = "LblExpirationDate";
            this.LblExpirationDate.Size = new System.Drawing.Size(165, 28);
            this.LblExpirationDate.TabIndex = 24;
            this.LblExpirationDate.Text = "Expiration Date:";
            // 
            // LblLocalLicenseID
            // 
            this.LblLocalLicenseID.AutoSize = true;
            this.LblLocalLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.LblLocalLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblLocalLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblLocalLicenseID.Location = new System.Drawing.Point(726, 79);
            this.LblLocalLicenseID.Name = "LblLocalLicenseID";
            this.LblLocalLicenseID.Size = new System.Drawing.Size(168, 28);
            this.LblLocalLicenseID.TabIndex = 23;
            this.LblLocalLicenseID.Text = "Local License ID:";
            // 
            // LblILLicenseID
            // 
            this.LblILLicenseID.AutoSize = true;
            this.LblILLicenseID.BackColor = System.Drawing.Color.Transparent;
            this.LblILLicenseID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblILLicenseID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblILLicenseID.Location = new System.Drawing.Point(729, 41);
            this.LblILLicenseID.Name = "LblILLicenseID";
            this.LblILLicenseID.Size = new System.Drawing.Size(139, 28);
            this.LblILLicenseID.TabIndex = 22;
            this.LblILLicenseID.Text = "I.L.License ID:";
            // 
            // PBEmail
            // 
            this.PBEmail.Image = ((System.Drawing.Image)(resources.GetObject("PBEmail.Image")));
            this.PBEmail.Location = new System.Drawing.Point(912, 155);
            this.PBEmail.Name = "PBEmail";
            this.PBEmail.Size = new System.Drawing.Size(40, 32);
            this.PBEmail.TabIndex = 11;
            this.PBEmail.TabStop = false;
            // 
            // PBNationalNo
            // 
            this.PBNationalNo.Image = ((System.Drawing.Image)(resources.GetObject("PBNationalNo.Image")));
            this.PBNationalNo.Location = new System.Drawing.Point(201, 117);
            this.PBNationalNo.Name = "PBNationalNo";
            this.PBNationalNo.Size = new System.Drawing.Size(40, 32);
            this.PBNationalNo.TabIndex = 10;
            this.PBNationalNo.TabStop = false;
            // 
            // PBName
            // 
            this.PBName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBName.ErrorImage = null;
            this.PBName.Image = ((System.Drawing.Image)(resources.GetObject("PBName.Image")));
            this.PBName.InitialImage = null;
            this.PBName.Location = new System.Drawing.Point(201, 78);
            this.PBName.Name = "PBName";
            this.PBName.Size = new System.Drawing.Size(40, 32);
            this.PBName.TabIndex = 9;
            this.PBName.TabStop = false;
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.LblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblCreatedBy.Location = new System.Drawing.Point(729, 155);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(120, 28);
            this.LblCreatedBy.TabIndex = 3;
            this.LblCreatedBy.Text = "Created By:";
            // 
            // LblFees
            // 
            this.LblFees.AutoSize = true;
            this.LblFees.BackColor = System.Drawing.Color.Transparent;
            this.LblFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblFees.Location = new System.Drawing.Point(16, 155);
            this.LblFees.Name = "LblFees";
            this.LblFees.Size = new System.Drawing.Size(58, 28);
            this.LblFees.TabIndex = 2;
            this.LblFees.Text = "Fees:";
            // 
            // LblIssueDate
            // 
            this.LblIssueDate.AutoSize = true;
            this.LblIssueDate.BackColor = System.Drawing.Color.Transparent;
            this.LblIssueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblIssueDate.Location = new System.Drawing.Point(16, 115);
            this.LblIssueDate.Name = "LblIssueDate";
            this.LblIssueDate.Size = new System.Drawing.Size(115, 28);
            this.LblIssueDate.TabIndex = 1;
            this.LblIssueDate.Text = "Issue Date:";
            // 
            // LblApplicationDate
            // 
            this.LblApplicationDate.AutoSize = true;
            this.LblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicationDate.Location = new System.Drawing.Point(16, 79);
            this.LblApplicationDate.Name = "LblApplicationDate";
            this.LblApplicationDate.Size = new System.Drawing.Size(177, 28);
            this.LblApplicationDate.TabIndex = 0;
            this.LblApplicationDate.Text = "Application Date:";
            // 
            // CtrDetailsInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GBUserControlDetailesApplication);
            this.Name = "CtrDetailsInternationalLicenseApplication";
            this.Size = new System.Drawing.Size(1169, 229);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.GBUserControlDetailesApplication.ResumeLayout(false);
            this.GBUserControlDetailesApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDateOfBrith)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBNationalNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ErrorProvider errorProvider1;
        private OpenFileDialog OFDialogPictureImage;
        private GroupBox GBUserControlDetailesApplication;
        private PictureBox PBApplicationID;
        private Label LblValueILApplicationID;
        private Label LblvalueExpirationDate;
        private Label LblvalueLocalLicenseID;
        private Label LblvalueLLicenseID;
        private Label LblvalueCreatedBy;
        private Label LblValueIssueDate;
        private Label LblValueApplicationDate;
        private Label LblValueFees;
        private PictureBox PBGender;
        private Label LblILApplicationID;
        private PictureBox PBCountry;
        private PictureBox PBPhone;
        private PictureBox PBDateOfBrith;
        private Label LblExpirationDate;
        private Label LblLocalLicenseID;
        private Label LblILLicenseID;
        private PictureBox PBEmail;
        private PictureBox PBNationalNo;
        private PictureBox PBName;
        private Label LblCreatedBy;
        private Label LblFees;
        private Label LblIssueDate;
        private Label LblApplicationDate;
    }
}