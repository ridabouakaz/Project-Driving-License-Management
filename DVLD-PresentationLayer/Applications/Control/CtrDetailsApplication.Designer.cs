using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class CtrDetailsApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrDetailsApplication));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OFDialogPictureImage = new System.Windows.Forms.OpenFileDialog();
            this.GBUserControlDetailesApplication = new System.Windows.Forms.GroupBox();
            this.PBApplicationID = new System.Windows.Forms.PictureBox();
            this.LblValueApplicationID = new System.Windows.Forms.Label();
            this.LblvalueCreatedBy = new System.Windows.Forms.Label();
            this.LblvalueStatusDate = new System.Windows.Forms.Label();
            this.LblvalueDate = new System.Windows.Forms.Label();
            this.LblvalueApplicant = new System.Windows.Forms.Label();
            this.LblValueFees = new System.Windows.Forms.Label();
            this.LblValueStatus = new System.Windows.Forms.Label();
            this.LblValueType = new System.Windows.Forms.Label();
            this.PBGender = new System.Windows.Forms.PictureBox();
            this.LblApplicationID = new System.Windows.Forms.Label();
            this.LLViewPersonInfo = new System.Windows.Forms.LinkLabel();
            this.PBCountry = new System.Windows.Forms.PictureBox();
            this.PBPhone = new System.Windows.Forms.PictureBox();
            this.PBDateOfBrith = new System.Windows.Forms.PictureBox();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.LblStatusDate = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.PBEmail = new System.Windows.Forms.PictureBox();
            this.PBNationalNo = new System.Windows.Forms.PictureBox();
            this.PBName = new System.Windows.Forms.PictureBox();
            this.LblApplicant = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblFees = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
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
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueApplicationID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueCreatedBy);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueStatusDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblvalueApplicant);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueFees);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueStatus);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblValueType);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBGender);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblApplicationID);
            this.GBUserControlDetailesApplication.Controls.Add(this.LLViewPersonInfo);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBCountry);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBPhone);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBDateOfBrith);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblCreatedBy);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblStatusDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblDate);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBEmail);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBNationalNo);
            this.GBUserControlDetailesApplication.Controls.Add(this.PBName);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblApplicant);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblType);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblFees);
            this.GBUserControlDetailesApplication.Controls.Add(this.LblStatus);
            this.GBUserControlDetailesApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GBUserControlDetailesApplication.Location = new System.Drawing.Point(18, 3);
            this.GBUserControlDetailesApplication.Name = "GBUserControlDetailesApplication";
            this.GBUserControlDetailesApplication.Size = new System.Drawing.Size(1130, 361);
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
            this.PBApplicationID.Location = new System.Drawing.Point(162, 47);
            this.PBApplicationID.Name = "PBApplicationID";
            this.PBApplicationID.Size = new System.Drawing.Size(40, 32);
            this.PBApplicationID.TabIndex = 47;
            this.PBApplicationID.TabStop = false;
            // 
            // LblValueApplicationID
            // 
            this.LblValueApplicationID.AutoSize = true;
            this.LblValueApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblValueApplicationID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueApplicationID.Location = new System.Drawing.Point(244, 51);
            this.LblValueApplicationID.Name = "LblValueApplicationID";
            this.LblValueApplicationID.Size = new System.Drawing.Size(90, 25);
            this.LblValueApplicationID.TabIndex = 46;
            this.LblValueApplicationID.Text = "[????????]";
            // 
            // LblvalueCreatedBy
            // 
            this.LblvalueCreatedBy.AutoSize = true;
            this.LblvalueCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueCreatedBy.Location = new System.Drawing.Point(984, 180);
            this.LblvalueCreatedBy.Name = "LblvalueCreatedBy";
            this.LblvalueCreatedBy.Size = new System.Drawing.Size(90, 25);
            this.LblvalueCreatedBy.TabIndex = 45;
            this.LblvalueCreatedBy.Text = "[????????]";
            // 
            // LblvalueStatusDate
            // 
            this.LblvalueStatusDate.AutoSize = true;
            this.LblvalueStatusDate.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueStatusDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueStatusDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueStatusDate.Location = new System.Drawing.Point(984, 114);
            this.LblvalueStatusDate.Name = "LblvalueStatusDate";
            this.LblvalueStatusDate.Size = new System.Drawing.Size(90, 25);
            this.LblvalueStatusDate.TabIndex = 44;
            this.LblvalueStatusDate.Text = "[????????]";
            // 
            // LblvalueDate
            // 
            this.LblvalueDate.AutoSize = true;
            this.LblvalueDate.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueDate.Location = new System.Drawing.Point(984, 55);
            this.LblvalueDate.Name = "LblvalueDate";
            this.LblvalueDate.Size = new System.Drawing.Size(90, 25);
            this.LblvalueDate.TabIndex = 43;
            this.LblvalueDate.Text = "[????????]";
            // 
            // LblvalueApplicant
            // 
            this.LblvalueApplicant.AutoSize = true;
            this.LblvalueApplicant.BackColor = System.Drawing.Color.Transparent;
            this.LblvalueApplicant.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblvalueApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblvalueApplicant.Location = new System.Drawing.Point(244, 291);
            this.LblvalueApplicant.Name = "LblvalueApplicant";
            this.LblvalueApplicant.Size = new System.Drawing.Size(90, 25);
            this.LblvalueApplicant.TabIndex = 41;
            this.LblvalueApplicant.Text = "[????????]";
            // 
            // LblValueFees
            // 
            this.LblValueFees.AutoSize = true;
            this.LblValueFees.BackColor = System.Drawing.Color.Transparent;
            this.LblValueFees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueFees.Location = new System.Drawing.Point(244, 171);
            this.LblValueFees.Name = "LblValueFees";
            this.LblValueFees.Size = new System.Drawing.Size(90, 25);
            this.LblValueFees.TabIndex = 40;
            this.LblValueFees.Text = "[????????]";
            // 
            // LblValueStatus
            // 
            this.LblValueStatus.AutoSize = true;
            this.LblValueStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblValueStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueStatus.ForeColor = System.Drawing.Color.Black;
            this.LblValueStatus.Location = new System.Drawing.Point(244, 111);
            this.LblValueStatus.Name = "LblValueStatus";
            this.LblValueStatus.Size = new System.Drawing.Size(90, 25);
            this.LblValueStatus.TabIndex = 39;
            this.LblValueStatus.Text = "[????????]";
            // 
            // LblValueType
            // 
            this.LblValueType.AutoSize = true;
            this.LblValueType.BackColor = System.Drawing.Color.Transparent;
            this.LblValueType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.LblValueType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueType.Location = new System.Drawing.Point(244, 231);
            this.LblValueType.Name = "LblValueType";
            this.LblValueType.Size = new System.Drawing.Size(90, 25);
            this.LblValueType.TabIndex = 38;
            this.LblValueType.Text = "[????????]";
            // 
            // PBGender
            // 
            this.PBGender.Image = ((System.Drawing.Image)(resources.GetObject("PBGender.Image")));
            this.PBGender.Location = new System.Drawing.Point(162, 231);
            this.PBGender.Name = "PBGender";
            this.PBGender.Size = new System.Drawing.Size(40, 32);
            this.PBGender.TabIndex = 37;
            this.PBGender.TabStop = false;
            // 
            // LblApplicationID
            // 
            this.LblApplicationID.AutoSize = true;
            this.LblApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicationID.Location = new System.Drawing.Point(86, 51);
            this.LblApplicationID.Name = "LblApplicationID";
            this.LblApplicationID.Size = new System.Drawing.Size(38, 28);
            this.LblApplicationID.TabIndex = 36;
            this.LblApplicationID.Text = "ID:";
            // 
            // LLViewPersonInfo
            // 
            this.LLViewPersonInfo.AutoSize = true;
            this.LLViewPersonInfo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LLViewPersonInfo.Location = new System.Drawing.Point(921, 291);
            this.LLViewPersonInfo.Name = "LLViewPersonInfo";
            this.LLViewPersonInfo.Size = new System.Drawing.Size(153, 25);
            this.LLViewPersonInfo.TabIndex = 33;
            this.LLViewPersonInfo.TabStop = true;
            this.LLViewPersonInfo.Text = "View Person Info";
            this.LLViewPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLEditApplicationInfo_LinkClicked);
            // 
            // PBCountry
            // 
            this.PBCountry.Image = ((System.Drawing.Image)(resources.GetObject("PBCountry.Image")));
            this.PBCountry.Location = new System.Drawing.Point(912, 177);
            this.PBCountry.Name = "PBCountry";
            this.PBCountry.Size = new System.Drawing.Size(40, 32);
            this.PBCountry.TabIndex = 27;
            this.PBCountry.TabStop = false;
            // 
            // PBPhone
            // 
            this.PBPhone.Image = ((System.Drawing.Image)(resources.GetObject("PBPhone.Image")));
            this.PBPhone.Location = new System.Drawing.Point(912, 115);
            this.PBPhone.Name = "PBPhone";
            this.PBPhone.Size = new System.Drawing.Size(40, 32);
            this.PBPhone.TabIndex = 26;
            this.PBPhone.TabStop = false;
            // 
            // PBDateOfBrith
            // 
            this.PBDateOfBrith.Image = ((System.Drawing.Image)(resources.GetObject("PBDateOfBrith.Image")));
            this.PBDateOfBrith.Location = new System.Drawing.Point(912, 54);
            this.PBDateOfBrith.Name = "PBDateOfBrith";
            this.PBDateOfBrith.Size = new System.Drawing.Size(40, 32);
            this.PBDateOfBrith.TabIndex = 25;
            this.PBDateOfBrith.TabStop = false;
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.LblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblCreatedBy.Location = new System.Drawing.Point(769, 177);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(120, 28);
            this.LblCreatedBy.TabIndex = 24;
            this.LblCreatedBy.Text = "Created By:";
            // 
            // LblStatusDate
            // 
            this.LblStatusDate.AutoSize = true;
            this.LblStatusDate.BackColor = System.Drawing.Color.Transparent;
            this.LblStatusDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblStatusDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblStatusDate.Location = new System.Drawing.Point(762, 115);
            this.LblStatusDate.Name = "LblStatusDate";
            this.LblStatusDate.Size = new System.Drawing.Size(127, 28);
            this.LblStatusDate.TabIndex = 23;
            this.LblStatusDate.Text = "Status Date:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblDate.Location = new System.Drawing.Point(827, 58);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(62, 28);
            this.LblDate.TabIndex = 22;
            this.LblDate.Text = "Date:";
            // 
            // PBEmail
            // 
            this.PBEmail.Image = ((System.Drawing.Image)(resources.GetObject("PBEmail.Image")));
            this.PBEmail.Location = new System.Drawing.Point(162, 287);
            this.PBEmail.Name = "PBEmail";
            this.PBEmail.Size = new System.Drawing.Size(40, 32);
            this.PBEmail.TabIndex = 11;
            this.PBEmail.TabStop = false;
            // 
            // PBNationalNo
            // 
            this.PBNationalNo.Image = ((System.Drawing.Image)(resources.GetObject("PBNationalNo.Image")));
            this.PBNationalNo.Location = new System.Drawing.Point(162, 169);
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
            this.PBName.Location = new System.Drawing.Point(162, 111);
            this.PBName.Name = "PBName";
            this.PBName.Size = new System.Drawing.Size(40, 32);
            this.PBName.TabIndex = 9;
            this.PBName.TabStop = false;
            // 
            // LblApplicant
            // 
            this.LblApplicant.AutoSize = true;
            this.LblApplicant.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicant.Location = new System.Drawing.Point(16, 291);
            this.LblApplicant.Name = "LblApplicant";
            this.LblApplicant.Size = new System.Drawing.Size(108, 28);
            this.LblApplicant.TabIndex = 3;
            this.LblApplicant.Text = "Applicant:";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.BackColor = System.Drawing.Color.Transparent;
            this.LblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblType.Location = new System.Drawing.Point(62, 231);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(62, 28);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type:";
            // 
            // LblFees
            // 
            this.LblFees.AutoSize = true;
            this.LblFees.BackColor = System.Drawing.Color.Transparent;
            this.LblFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblFees.Location = new System.Drawing.Point(66, 171);
            this.LblFees.Name = "LblFees";
            this.LblFees.Size = new System.Drawing.Size(58, 28);
            this.LblFees.TabIndex = 1;
            this.LblFees.Text = "Fees:";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblStatus.Location = new System.Drawing.Point(48, 111);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(76, 28);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = "Status:";
            // 
            // CtrDetailsApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GBUserControlDetailesApplication);
            this.Name = "CtrDetailsApplication";
            this.Size = new System.Drawing.Size(1169, 383);
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
        private Label LblValueApplicationID;
        private Label LblvalueCreatedBy;
        private Label LblvalueStatusDate;
        private Label LblvalueDate;
        private Label LblvalueApplicant;
        private Label LblValueFees;
        private Label LblValueStatus;
        private Label LblValueType;
        private PictureBox PBGender;
        private Label LblApplicationID;
        private LinkLabel LLViewPersonInfo;
        private PictureBox PBCountry;
        private PictureBox PBPhone;
        private PictureBox PBDateOfBrith;
        private Label LblCreatedBy;
        private Label LblStatusDate;
        private Label LblDate;
        private PictureBox PBEmail;
        private PictureBox PBNationalNo;
        private PictureBox PBName;
        private Label LblApplicant;
        private Label LblType;
        private Label LblFees;
        private Label LblStatus;
    }
}