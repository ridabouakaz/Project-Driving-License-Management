using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    partial class FOListTestAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOListTestAppointments));
            this.SMItemCRUDUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDUsers1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemChangePasswordUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDUsers2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemCallUser = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManageTestAppointments = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.LblAppointments = new System.Windows.Forms.Label();
            this.PBManageTestAppointments = new System.Windows.Forms.PictureBox();
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.BtnAddAppointments = new System.Windows.Forms.Button();
            this.ctrDrivingLicenseApplicationInfo2 = new DVLD_PresentationLayer.CtrDrivingLicenseApplicationInfo();
            this.SMItemCRUDUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // SMItemCRUDUsers
            // 
            this.SMItemCRUDUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMItemCRUDUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemViewDetails,
            this.SMItemSeparatorCRUDUsers1,
            this.SMItemAddUser,
            this.SMItemEditUser,
            this.SMItemDeleteUser,
            this.SMItemChangePasswordUser,
            this.SMItemSeparatorCRUDUsers2,
            this.SMItemSendEmail,
            this.SMItemCallUser});
            this.SMItemCRUDUsers.Name = "SMItemCRUDUsers";
            this.SMItemCRUDUsers.Size = new System.Drawing.Size(194, 198);
            // 
            // SMItemViewDetails
            // 
            this.SMItemViewDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemViewDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemViewDetails.Name = "SMItemViewDetails";
            this.SMItemViewDetails.Size = new System.Drawing.Size(193, 26);
            this.SMItemViewDetails.Text = "View Details";
            // 
            // SMItemSeparatorCRUDUsers1
            // 
            this.SMItemSeparatorCRUDUsers1.Name = "SMItemSeparatorCRUDUsers1";
            this.SMItemSeparatorCRUDUsers1.Size = new System.Drawing.Size(190, 6);
            // 
            // SMItemAddUser
            // 
            this.SMItemAddUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemAddUser.Name = "SMItemAddUser";
            this.SMItemAddUser.Size = new System.Drawing.Size(193, 26);
            this.SMItemAddUser.Text = "Add User";
            // 
            // SMItemEditUser
            // 
            this.SMItemEditUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemEditUser.Name = "SMItemEditUser";
            this.SMItemEditUser.Size = new System.Drawing.Size(193, 26);
            this.SMItemEditUser.Text = "Edit User";
            // 
            // SMItemDeleteUser
            // 
            this.SMItemDeleteUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemDeleteUser.Name = "SMItemDeleteUser";
            this.SMItemDeleteUser.Size = new System.Drawing.Size(193, 26);
            this.SMItemDeleteUser.Text = "Delete User";
            // 
            // SMItemChangePasswordUser
            // 
            this.SMItemChangePasswordUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemChangePasswordUser.Name = "SMItemChangePasswordUser";
            this.SMItemChangePasswordUser.Size = new System.Drawing.Size(193, 26);
            this.SMItemChangePasswordUser.Text = "Change Password";
            // 
            // SMItemSeparatorCRUDUsers2
            // 
            this.SMItemSeparatorCRUDUsers2.Name = "SMItemSeparatorCRUDUsers2";
            this.SMItemSeparatorCRUDUsers2.Size = new System.Drawing.Size(190, 6);
            // 
            // SMItemSendEmail
            // 
            this.SMItemSendEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemSendEmail.Name = "SMItemSendEmail";
            this.SMItemSendEmail.Size = new System.Drawing.Size(193, 26);
            this.SMItemSendEmail.Text = "Send Email";
            // 
            // SMItemCallUser
            // 
            this.SMItemCallUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemCallUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemCallUser.Name = "SMItemCallUser";
            this.SMItemCallUser.Size = new System.Drawing.Size(193, 26);
            this.SMItemCallUser.Text = "Call User";
            // 
            // LblManageTestAppointments
            // 
            this.LblManageTestAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageTestAppointments.AutoSize = true;
            this.LblManageTestAppointments.BackColor = System.Drawing.Color.Transparent;
            this.LblManageTestAppointments.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageTestAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageTestAppointments.Location = new System.Drawing.Point(345, 140);
            this.LblManageTestAppointments.Name = "LblManageTestAppointments";
            this.LblManageTestAppointments.Size = new System.Drawing.Size(505, 54);
            this.LblManageTestAppointments.TabIndex = 1;
            this.LblManageTestAppointments.Text = "Vision Test Appointments";
            // 
            // LblRecoreds
            // 
            this.LblRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRecoreds.AutoSize = true;
            this.LblRecoreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblRecoreds.Location = new System.Drawing.Point(23, 777);
            this.LblRecoreds.Name = "LblRecoreds";
            this.LblRecoreds.Size = new System.Drawing.Size(121, 28);
            this.LblRecoreds.TabIndex = 5;
            this.LblRecoreds.Text = "# Recoreds:";
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(997, 780);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 4;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // LblTotalRecoreds
            // 
            this.LblTotalRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalRecoreds.AutoSize = true;
            this.LblTotalRecoreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblTotalRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTotalRecoreds.Location = new System.Drawing.Point(144, 777);
            this.LblTotalRecoreds.Name = "LblTotalRecoreds";
            this.LblTotalRecoreds.Size = new System.Drawing.Size(30, 28);
            this.LblTotalRecoreds.TabIndex = 8;
            this.LblTotalRecoreds.Text = "??";
            // 
            // LblAppointments
            // 
            this.LblAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblAppointments.AutoSize = true;
            this.LblAppointments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblAppointments.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblAppointments.Location = new System.Drawing.Point(23, 586);
            this.LblAppointments.Name = "LblAppointments";
            this.LblAppointments.Size = new System.Drawing.Size(151, 28);
            this.LblAppointments.TabIndex = 9;
            this.LblAppointments.Text = "Appointments:";
            // 
            // PBManageTestAppointments
            // 
            this.PBManageTestAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageTestAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageTestAppointments.Image = global::DVLD_PresentationLayer.Properties.Resources.StreetTest;
            this.PBManageTestAppointments.Location = new System.Drawing.Point(549, 12);
            this.PBManageTestAppointments.Name = "PBManageTestAppointments";
            this.PBManageTestAppointments.Size = new System.Drawing.Size(137, 125);
            this.PBManageTestAppointments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageTestAppointments.TabIndex = 2;
            this.PBManageTestAppointments.TabStop = false;
            // 
            // dGViewShowInformation
            // 
            this.dGViewShowInformation.AllowUserToAddRows = false;
            this.dGViewShowInformation.AllowUserToDeleteRows = false;
            this.dGViewShowInformation.AllowUserToOrderColumns = true;
            this.dGViewShowInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGViewShowInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGViewShowInformation.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewShowInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.ContextMenuStrip = this.SMItemCRUDUsers;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGViewShowInformation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGViewShowInformation.Location = new System.Drawing.Point(28, 628);
            this.dGViewShowInformation.Name = "dGViewShowInformation";
            this.dGViewShowInformation.ReadOnly = true;
            this.dGViewShowInformation.RowHeadersWidth = 51;
            this.dGViewShowInformation.RowTemplate.Height = 24;
            this.dGViewShowInformation.Size = new System.Drawing.Size(1124, 146);
            this.dGViewShowInformation.TabIndex = 11;
            // 
            // BtnAddAppointments
            // 
            this.BtnAddAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAppointments.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddAppointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddAppointments.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddAppointments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddAppointments.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddAppointments.Image")));
            this.BtnAddAppointments.Location = new System.Drawing.Point(1103, 582);
            this.BtnAddAppointments.Name = "BtnAddAppointments";
            this.BtnAddAppointments.Size = new System.Drawing.Size(49, 40);
            this.BtnAddAppointments.TabIndex = 12;
            this.BtnAddAppointments.UseVisualStyleBackColor = false;
            // 
            // ctrDrivingLicenseApplicationInfo2
            // 
            this.ctrDrivingLicenseApplicationInfo2.BackColor = System.Drawing.Color.White;
            this.ctrDrivingLicenseApplicationInfo2.Location = new System.Drawing.Point(0, 197);
            this.ctrDrivingLicenseApplicationInfo2.Name = "ctrDrivingLicenseApplicationInfo2";
            this.ctrDrivingLicenseApplicationInfo2.Size = new System.Drawing.Size(1168, 398);
            this.ctrDrivingLicenseApplicationInfo2.TabIndex = 10;
            // 
            // FOListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 865);
            this.Controls.Add(this.BtnAddAppointments);
            this.Controls.Add(this.dGViewShowInformation);
            this.Controls.Add(this.ctrDrivingLicenseApplicationInfo2);
            this.Controls.Add(this.LblAppointments);
            this.Controls.Add(this.LblTotalRecoreds);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblRecoreds);
            this.Controls.Add(this.PBManageTestAppointments);
            this.Controls.Add(this.LblManageTestAppointments);
            this.Name = "FOListTestAppointments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Test Appointments";
            this.SMItemCRUDUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblManageTestAppointments;
        private PictureBox PBManageTestAppointments;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDUsers;
        private ToolStripMenuItem SMItemViewDetails;
        private ToolStripSeparator SMItemSeparatorCRUDUsers1;
        private ToolStripMenuItem SMItemAddUser;
        private ToolStripMenuItem SMItemEditUser;
        private ToolStripMenuItem SMItemDeleteUser;
        private ToolStripMenuItem SMItemSendEmail;
        private ToolStripMenuItem SMItemCallUser;
        private Label LblTotalRecoreds;
        private ToolStripMenuItem SMItemChangePasswordUser;
        private ToolStripSeparator SMItemSeparatorCRUDUsers2;
        private Label LblAppointments;
        private CtrDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo1;
        private CtrDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo2;
        private DataGridView dGViewShowInformation;
        private Button BtnAddAppointments;
    }
}