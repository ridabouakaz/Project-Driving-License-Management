namespace DVLD_PresentationLayer
{
    partial class FONewLocalDrivingApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FONewLocalDrivingApplication));
            this.LblAddEditApplication = new System.Windows.Forms.Label();
            this.TCAddEditApplication = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.TPPersonalInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ctrDetailsPersonWithFilter1 = new DVLD_PresentationLayer.CtrDetailsPersonWithFilter();
            this.BtnAddNext = new System.Windows.Forms.Button();
            this.TPApplicationInfo = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.CBLicenseClassBy = new System.Windows.Forms.ComboBox();
            this.LblValueCreatedby = new System.Windows.Forms.Label();
            this.LblValueApplicationFees = new System.Windows.Forms.Label();
            this.LblValueApplicationDate = new System.Windows.Forms.Label();
            this.PBCreatedby = new System.Windows.Forms.PictureBox();
            this.LblCreatedby = new System.Windows.Forms.Label();
            this.LblValueApplicationID = new System.Windows.Forms.Label();
            this.PBDLApplicationID = new System.Windows.Forms.PictureBox();
            this.PBApplicationDate = new System.Windows.Forms.PictureBox();
            this.PBLicenseClass = new System.Windows.Forms.PictureBox();
            this.PBApplicationFees = new System.Windows.Forms.PictureBox();
            this.LblApplicationFees = new System.Windows.Forms.Label();
            this.LblDLApplicationID = new System.Windows.Forms.Label();
            this.LblApplicationDate = new System.Windows.Forms.Label();
            this.LblLicenseClass = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.BtnAddSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditApplication)).BeginInit();
            this.TCAddEditApplication.SuspendLayout();
            this.TPPersonalInfo.SuspendLayout();
            this.TPApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreatedby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDLApplicationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLicenseClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddEditApplication
            // 
            this.LblAddEditApplication.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddEditApplication.AutoSize = true;
            this.LblAddEditApplication.BackColor = System.Drawing.Color.Transparent;
            this.LblAddEditApplication.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblAddEditApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblAddEditApplication.Location = new System.Drawing.Point(254, 19);
            this.LblAddEditApplication.Name = "LblAddEditApplication";
            this.LblAddEditApplication.Size = new System.Drawing.Size(553, 50);
            this.LblAddEditApplication.TabIndex = 3;
            this.LblAddEditApplication.Text = "New Local Driving Application";
            // 
            // TCAddEditApplication
            // 
            this.TCAddEditApplication.ActiveTabFont = new System.Drawing.Font("Segoe UI", 12F);
            this.TCAddEditApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(250)))));
            this.TCAddEditApplication.BeforeTouchSize = new System.Drawing.Size(1028, 685);
            this.TCAddEditApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TCAddEditApplication.Controls.Add(this.TPPersonalInfo);
            this.TCAddEditApplication.Controls.Add(this.TPApplicationInfo);
            this.TCAddEditApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.TCAddEditApplication.Location = new System.Drawing.Point(12, 85);
            this.TCAddEditApplication.Name = "TCAddEditApplication";
            this.TCAddEditApplication.Size = new System.Drawing.Size(1028, 685);
            this.TCAddEditApplication.TabIndex = 4;
            this.TCAddEditApplication.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.TCAddEditApplication.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);
            this.TCAddEditApplication.ThemeName = "TabRendererIE7";
            this.TCAddEditApplication.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
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
            this.TPPersonalInfo.Size = new System.Drawing.Size(1028, 638);
            this.TPPersonalInfo.TabIndex = 1;
            this.TPPersonalInfo.Text = "Personal Info";
            this.TPPersonalInfo.ThemesEnabled = false;
            // 
            // ctrDetailsPersonWithFilter1
            // 
            this.ctrDetailsPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsPersonWithFilter1.Location = new System.Drawing.Point(21, 20);
            this.ctrDetailsPersonWithFilter1.Name = "ctrDetailsPersonWithFilter1";
            this.ctrDetailsPersonWithFilter1.PersonData = null;
            this.ctrDetailsPersonWithFilter1.Size = new System.Drawing.Size(979, 478);
            this.ctrDetailsPersonWithFilter1.TabIndex = 6;
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
            this.BtnAddNext.Location = new System.Drawing.Point(831, 504);
            this.BtnAddNext.Name = "BtnAddNext";
            this.BtnAddNext.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddNext.Size = new System.Drawing.Size(155, 50);
            this.BtnAddNext.TabIndex = 5;
            this.BtnAddNext.Text = "Next";
            this.BtnAddNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNext.UseVisualStyleBackColor = false;
            this.BtnAddNext.Click += new System.EventHandler(this.BtnAddNext_Click);
            // 
            // TPApplicationInfo
            // 
            this.TPApplicationInfo.BackColor = System.Drawing.Color.White;
            this.TPApplicationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPApplicationInfo.Controls.Add(this.CBLicenseClassBy);
            this.TPApplicationInfo.Controls.Add(this.LblValueCreatedby);
            this.TPApplicationInfo.Controls.Add(this.LblValueApplicationFees);
            this.TPApplicationInfo.Controls.Add(this.LblValueApplicationDate);
            this.TPApplicationInfo.Controls.Add(this.PBCreatedby);
            this.TPApplicationInfo.Controls.Add(this.LblCreatedby);
            this.TPApplicationInfo.Controls.Add(this.LblValueApplicationID);
            this.TPApplicationInfo.Controls.Add(this.PBDLApplicationID);
            this.TPApplicationInfo.Controls.Add(this.PBApplicationDate);
            this.TPApplicationInfo.Controls.Add(this.PBLicenseClass);
            this.TPApplicationInfo.Controls.Add(this.PBApplicationFees);
            this.TPApplicationInfo.Controls.Add(this.LblApplicationFees);
            this.TPApplicationInfo.Controls.Add(this.LblDLApplicationID);
            this.TPApplicationInfo.Controls.Add(this.LblApplicationDate);
            this.TPApplicationInfo.Controls.Add(this.LblLicenseClass);
            this.TPApplicationInfo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPApplicationInfo.Image = null;
            this.TPApplicationInfo.ImageSize = new System.Drawing.Size(20, 20);
            this.TPApplicationInfo.Location = new System.Drawing.Point(0, 48);
            this.TPApplicationInfo.Name = "TPApplicationInfo";
            this.TPApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPApplicationInfo.ShowCloseButton = true;
            this.TPApplicationInfo.Size = new System.Drawing.Size(1028, 638);
            this.TPApplicationInfo.TabIndex = 1;
            this.TPApplicationInfo.Text = "Application Info";
            this.TPApplicationInfo.ThemesEnabled = false;
            // 
            // CBLicenseClassBy
            // 
            this.CBLicenseClassBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBLicenseClassBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBLicenseClassBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBLicenseClassBy.ForeColor = System.Drawing.Color.Black;
            this.CBLicenseClassBy.FormattingEnabled = true;
            this.CBLicenseClassBy.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.CBLicenseClassBy.Location = new System.Drawing.Point(301, 205);
            this.CBLicenseClassBy.Name = "CBLicenseClassBy";
            this.CBLicenseClassBy.Size = new System.Drawing.Size(268, 31);
            this.CBLicenseClassBy.TabIndex = 63;
            // 
            // LblValueCreatedby
            // 
            this.LblValueCreatedby.AutoSize = true;
            this.LblValueCreatedby.BackColor = System.Drawing.Color.Transparent;
            this.LblValueCreatedby.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblValueCreatedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueCreatedby.Location = new System.Drawing.Point(296, 312);
            this.LblValueCreatedby.Name = "LblValueCreatedby";
            this.LblValueCreatedby.Size = new System.Drawing.Size(39, 25);
            this.LblValueCreatedby.TabIndex = 62;
            this.LblValueCreatedby.Text = "???";
            // 
            // LblValueApplicationFees
            // 
            this.LblValueApplicationFees.AutoSize = true;
            this.LblValueApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.LblValueApplicationFees.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblValueApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueApplicationFees.Location = new System.Drawing.Point(296, 262);
            this.LblValueApplicationFees.Name = "LblValueApplicationFees";
            this.LblValueApplicationFees.Size = new System.Drawing.Size(39, 25);
            this.LblValueApplicationFees.TabIndex = 61;
            this.LblValueApplicationFees.Text = "???";
            // 
            // LblValueApplicationDate
            // 
            this.LblValueApplicationDate.AutoSize = true;
            this.LblValueApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.LblValueApplicationDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblValueApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueApplicationDate.Location = new System.Drawing.Point(296, 150);
            this.LblValueApplicationDate.Name = "LblValueApplicationDate";
            this.LblValueApplicationDate.Size = new System.Drawing.Size(39, 25);
            this.LblValueApplicationDate.TabIndex = 60;
            this.LblValueApplicationDate.Text = "???";
            // 
            // PBCreatedby
            // 
            this.PBCreatedby.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBCreatedby.ErrorImage = null;
            this.PBCreatedby.Image = ((System.Drawing.Image)(resources.GetObject("PBCreatedby.Image")));
            this.PBCreatedby.InitialImage = null;
            this.PBCreatedby.Location = new System.Drawing.Point(223, 315);
            this.PBCreatedby.Name = "PBCreatedby";
            this.PBCreatedby.Size = new System.Drawing.Size(40, 32);
            this.PBCreatedby.TabIndex = 59;
            this.PBCreatedby.TabStop = false;
            // 
            // LblCreatedby
            // 
            this.LblCreatedby.AutoSize = true;
            this.LblCreatedby.BackColor = System.Drawing.Color.Transparent;
            this.LblCreatedby.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblCreatedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblCreatedby.Location = new System.Drawing.Point(78, 309);
            this.LblCreatedby.Name = "LblCreatedby";
            this.LblCreatedby.Size = new System.Drawing.Size(119, 28);
            this.LblCreatedby.TabIndex = 58;
            this.LblCreatedby.Text = "Created by:";
            // 
            // LblValueApplicationID
            // 
            this.LblValueApplicationID.AutoSize = true;
            this.LblValueApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblValueApplicationID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LblValueApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueApplicationID.Location = new System.Drawing.Point(296, 94);
            this.LblValueApplicationID.Name = "LblValueApplicationID";
            this.LblValueApplicationID.Size = new System.Drawing.Size(39, 25);
            this.LblValueApplicationID.TabIndex = 52;
            this.LblValueApplicationID.Text = "???";
            // 
            // PBDLApplicationID
            // 
            this.PBDLApplicationID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBDLApplicationID.ErrorImage = null;
            this.PBDLApplicationID.Image = ((System.Drawing.Image)(resources.GetObject("PBDLApplicationID.Image")));
            this.PBDLApplicationID.InitialImage = null;
            this.PBDLApplicationID.Location = new System.Drawing.Point(223, 91);
            this.PBDLApplicationID.Name = "PBDLApplicationID";
            this.PBDLApplicationID.Size = new System.Drawing.Size(40, 32);
            this.PBDLApplicationID.TabIndex = 51;
            this.PBDLApplicationID.TabStop = false;
            // 
            // PBApplicationDate
            // 
            this.PBApplicationDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBApplicationDate.ErrorImage = null;
            this.PBApplicationDate.Image = ((System.Drawing.Image)(resources.GetObject("PBApplicationDate.Image")));
            this.PBApplicationDate.InitialImage = null;
            this.PBApplicationDate.Location = new System.Drawing.Point(223, 147);
            this.PBApplicationDate.Name = "PBApplicationDate";
            this.PBApplicationDate.Size = new System.Drawing.Size(40, 32);
            this.PBApplicationDate.TabIndex = 50;
            this.PBApplicationDate.TabStop = false;
            // 
            // PBLicenseClass
            // 
            this.PBLicenseClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBLicenseClass.ErrorImage = null;
            this.PBLicenseClass.Image = ((System.Drawing.Image)(resources.GetObject("PBLicenseClass.Image")));
            this.PBLicenseClass.InitialImage = null;
            this.PBLicenseClass.Location = new System.Drawing.Point(223, 203);
            this.PBLicenseClass.Name = "PBLicenseClass";
            this.PBLicenseClass.Size = new System.Drawing.Size(40, 32);
            this.PBLicenseClass.TabIndex = 49;
            this.PBLicenseClass.TabStop = false;
            // 
            // PBApplicationFees
            // 
            this.PBApplicationFees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBApplicationFees.ErrorImage = null;
            this.PBApplicationFees.Image = ((System.Drawing.Image)(resources.GetObject("PBApplicationFees.Image")));
            this.PBApplicationFees.InitialImage = null;
            this.PBApplicationFees.Location = new System.Drawing.Point(223, 259);
            this.PBApplicationFees.Name = "PBApplicationFees";
            this.PBApplicationFees.Size = new System.Drawing.Size(40, 32);
            this.PBApplicationFees.TabIndex = 48;
            this.PBApplicationFees.TabStop = false;
            // 
            // LblApplicationFees
            // 
            this.LblApplicationFees.AutoSize = true;
            this.LblApplicationFees.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicationFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicationFees.Location = new System.Drawing.Point(23, 259);
            this.LblApplicationFees.Name = "LblApplicationFees";
            this.LblApplicationFees.Size = new System.Drawing.Size(173, 28);
            this.LblApplicationFees.TabIndex = 40;
            this.LblApplicationFees.Text = "Application Fees:";
            // 
            // LblDLApplicationID
            // 
            this.LblDLApplicationID.AutoSize = true;
            this.LblDLApplicationID.BackColor = System.Drawing.Color.Transparent;
            this.LblDLApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblDLApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblDLApplicationID.Location = new System.Drawing.Point(15, 91);
            this.LblDLApplicationID.Name = "LblDLApplicationID";
            this.LblDLApplicationID.Size = new System.Drawing.Size(181, 28);
            this.LblDLApplicationID.TabIndex = 39;
            this.LblDLApplicationID.Text = "D.L.ApplicationID:";
            // 
            // LblApplicationDate
            // 
            this.LblApplicationDate.AutoSize = true;
            this.LblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.LblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblApplicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblApplicationDate.Location = new System.Drawing.Point(20, 147);
            this.LblApplicationDate.Name = "LblApplicationDate";
            this.LblApplicationDate.Size = new System.Drawing.Size(177, 28);
            this.LblApplicationDate.TabIndex = 38;
            this.LblApplicationDate.Text = "Application Date:";
            // 
            // LblLicenseClass
            // 
            this.LblLicenseClass.AutoSize = true;
            this.LblLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.LblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblLicenseClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblLicenseClass.Location = new System.Drawing.Point(57, 203);
            this.LblLicenseClass.Name = "LblLicenseClass";
            this.LblLicenseClass.Size = new System.Drawing.Size(139, 28);
            this.LblLicenseClass.TabIndex = 37;
            this.LblLicenseClass.Text = "License Class:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(291, 315);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 21);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Is Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(741, 777);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(142, 48);
            this.BtnAddClose.TabIndex = 35;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSave.Image")));
            this.BtnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSave.Location = new System.Drawing.Point(910, 777);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddSave.Size = new System.Drawing.Size(130, 48);
            this.BtnAddSave.TabIndex = 36;
            this.BtnAddSave.Text = "Save";
            this.BtnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSave.UseVisualStyleBackColor = false;
            this.BtnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // FONewLocalDrivingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1054, 910);
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.TCAddEditApplication);
            this.Controls.Add(this.LblAddEditApplication);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FONewLocalDrivingApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Local Driving Application";
            ((System.ComponentModel.ISupportInitialize)(this.TCAddEditApplication)).EndInit();
            this.TCAddEditApplication.ResumeLayout(false);
            this.TPPersonalInfo.ResumeLayout(false);
            this.TPApplicationInfo.ResumeLayout(false);
            this.TPApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreatedby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBDLApplicationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLicenseClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddEditApplication;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv TCAddEditApplication;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPPersonalInfo;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv TPApplicationInfo;
        private System.Windows.Forms.Button BtnAddNext;
        private CtrDetailsPersonWithFilter ctrDetailsPersonWithFilter1;
        private System.Windows.Forms.Label LblApplicationFees;
        private System.Windows.Forms.Label LblDLApplicationID;
        private System.Windows.Forms.Label LblApplicationDate;
        private System.Windows.Forms.Label LblLicenseClass;
        private System.Windows.Forms.PictureBox PBDLApplicationID;
        private System.Windows.Forms.PictureBox PBApplicationDate;
        private System.Windows.Forms.PictureBox PBLicenseClass;
        private System.Windows.Forms.PictureBox PBApplicationFees;
        private System.Windows.Forms.Label LblValueApplicationID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.Button BtnAddSave;
        private System.Windows.Forms.Label LblCreatedby;
        private System.Windows.Forms.PictureBox PBCreatedby;
        private System.Windows.Forms.Label LblValueCreatedby;
        private System.Windows.Forms.Label LblValueApplicationFees;
        private System.Windows.Forms.Label LblValueApplicationDate;
        private System.Windows.Forms.ComboBox CBLicenseClassBy;
    }
}