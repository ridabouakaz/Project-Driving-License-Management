using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOManageApplicationTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
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
            this.LblManageApplicationTypes = new System.Windows.Forms.Label();
            this.PBManageUsers = new System.Windows.Forms.PictureBox();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SMItemCRUDUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageUsers)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewShowInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.ContextMenuStrip = this.SMItemCRUDUsers;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGViewShowInformation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGViewShowInformation.Location = new System.Drawing.Point(47, 279);
            this.dGViewShowInformation.Name = "dGViewShowInformation";
            this.dGViewShowInformation.ReadOnly = true;
            this.dGViewShowInformation.RowHeadersWidth = 51;
            this.dGViewShowInformation.RowTemplate.Height = 24;
            this.dGViewShowInformation.Size = new System.Drawing.Size(982, 481);
            this.dGViewShowInformation.TabIndex = 3;
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
            // LblManageApplicationTypes
            // 
            this.LblManageApplicationTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageApplicationTypes.AutoSize = true;
            this.LblManageApplicationTypes.BackColor = System.Drawing.Color.Transparent;
            this.LblManageApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageApplicationTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageApplicationTypes.Location = new System.Drawing.Point(405, 159);
            this.LblManageApplicationTypes.Name = "LblManageApplicationTypes";
            this.LblManageApplicationTypes.Size = new System.Drawing.Size(522, 54);
            this.LblManageApplicationTypes.TabIndex = 1;
            this.LblManageApplicationTypes.Text = "Manage Application Types";
            // 
            // PBManageUsers
            // 
            this.PBManageUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageUsers.Location = new System.Drawing.Point(480, 31);
            this.PBManageUsers.Name = "PBManageUsers";
            this.PBManageUsers.Size = new System.Drawing.Size(137, 125);
            this.PBManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageUsers.TabIndex = 2;
            this.PBManageUsers.TabStop = false;
            // 
            // LblRecoreds
            // 
            this.LblRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblRecoreds.AutoSize = true;
            this.LblRecoreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblRecoreds.Location = new System.Drawing.Point(44, 775);
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
            this.BtnAddClose.Location = new System.Drawing.Point(874, 766);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 4;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            // 
            // LblTotalRecoreds
            // 
            this.LblTotalRecoreds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalRecoreds.AutoSize = true;
            this.LblTotalRecoreds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblTotalRecoreds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblTotalRecoreds.Location = new System.Drawing.Point(161, 775);
            this.LblTotalRecoreds.Name = "LblTotalRecoreds";
            this.LblTotalRecoreds.Size = new System.Drawing.Size(30, 28);
            this.LblTotalRecoreds.TabIndex = 8;
            this.LblTotalRecoreds.Text = "??";
            // 
            // FOManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 932);
            this.Controls.Add(this.LblTotalRecoreds);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblRecoreds);
            this.Controls.Add(this.PBManageUsers);
            this.Controls.Add(this.LblManageApplicationTypes);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManageApplicationTypes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManageApplicationTypes;
        private PictureBox PBManageUsers;
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
    }
}