using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManageUsers));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.SMItemCRUDUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDUsers1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDUsers2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemCallUser = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManageUsers = new System.Windows.Forms.Label();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.PBManageUsers = new System.Windows.Forms.PictureBox();
            this.LblFilterBy = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
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
            this.dGViewShowInformation.Size = new System.Drawing.Size(1439, 481);
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
            this.SMItemSeparatorCRUDUsers2,
            this.SMItemSendEmail,
            this.SMItemCallUser});
            this.SMItemCRUDUsers.Name = "SMItemCRUDUsers";
            this.SMItemCRUDUsers.Size = new System.Drawing.Size(189, 244);
            // 
            // SMItemViewDetails
            // 
            this.SMItemViewDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemViewDetails.Image = ((System.Drawing.Image)(resources.GetObject("SMItemViewDetails.Image")));
            this.SMItemViewDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemViewDetails.Name = "SMItemViewDetails";
            this.SMItemViewDetails.Size = new System.Drawing.Size(188, 38);
            this.SMItemViewDetails.Text = "View Details";
            this.SMItemViewDetails.Click += new System.EventHandler(this.SMItemViewDetails_Click);
            // 
            // SMItemSeparatorCRUDUsers1
            // 
            this.SMItemSeparatorCRUDUsers1.Name = "SMItemSeparatorCRUDUsers1";
            this.SMItemSeparatorCRUDUsers1.Size = new System.Drawing.Size(223, 6);
            // 
            // SMItemAddUser
            // 
            this.SMItemAddUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemAddUser.Image = ((System.Drawing.Image)(resources.GetObject("SMItemAddUser.Image")));
            this.SMItemAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemAddUser.Name = "SMItemAddUser";
            this.SMItemAddUser.Size = new System.Drawing.Size(226, 38);
            this.SMItemAddUser.Text = "Add User";
            this.SMItemAddUser.Click += new System.EventHandler(this.SMItemAddUser_Click);
            // 
            // SMItemEditUser
            // 
            this.SMItemEditUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemEditUser.Image = ((System.Drawing.Image)(resources.GetObject("SMItemEditUser.Image")));
            this.SMItemEditUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemEditUser.Name = "SMItemEditUser";
            this.SMItemEditUser.Size = new System.Drawing.Size(226, 38);
            this.SMItemEditUser.Text = "Edit User";
            this.SMItemEditUser.Click += new System.EventHandler(this.SMItemEditUser_Click);
            // 
            // SMItemDeleteUser
            // 
            this.SMItemDeleteUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("SMItemDeleteUser.Image")));
            this.SMItemDeleteUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemDeleteUser.Name = "SMItemDeleteUser";
            this.SMItemDeleteUser.Size = new System.Drawing.Size(226, 38);
            this.SMItemDeleteUser.Text = "Delete User";
            this.SMItemDeleteUser.Click += new System.EventHandler(this.SMItemDeleteUser_Click);
            // 
            // SMItemSeparatorCRUDUsers2
            // 
            this.SMItemSeparatorCRUDUsers2.Name = "SMItemSeparatorCRUDUsers2";
            this.SMItemSeparatorCRUDUsers2.Size = new System.Drawing.Size(223, 6);
            // 
            // SMItemSendEmail
            // 
            this.SMItemSendEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("SMItemSendEmail.Image")));
            this.SMItemSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemSendEmail.Name = "SMItemSendEmail";
            this.SMItemSendEmail.Size = new System.Drawing.Size(226, 38);
            this.SMItemSendEmail.Text = "Send Email";
            // 
            // SMItemCallUser
            // 
            this.SMItemCallUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemCallUser.Image = ((System.Drawing.Image)(resources.GetObject("SMItemCallUser.Image")));
            this.SMItemCallUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemCallUser.Name = "SMItemCallUser";
            this.SMItemCallUser.Size = new System.Drawing.Size(226, 38);
            this.SMItemCallUser.Text = "Call User";
            // 
            // LblManageUsers
            // 
            this.LblManageUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageUsers.AutoSize = true;
            this.LblManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.LblManageUsers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageUsers.Location = new System.Drawing.Point(635, 159);
            this.LblManageUsers.Name = "LblManageUsers";
            this.LblManageUsers.Size = new System.Drawing.Size(290, 54);
            this.LblManageUsers.TabIndex = 1;
            this.LblManageUsers.Text = "Manage Users";
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddUser.Image")));
            this.BtnAddUser.Location = new System.Drawing.Point(1396, 228);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(90, 45);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // PBManageUsers
            // 
            this.PBManageUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("PBManageUsers.Image")));
            this.PBManageUsers.Location = new System.Drawing.Point(710, 31);
            this.PBManageUsers.Name = "PBManageUsers";
            this.PBManageUsers.Size = new System.Drawing.Size(137, 125);
            this.PBManageUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageUsers.TabIndex = 2;
            this.PBManageUsers.TabStop = false;
            // 
            // LblFilterBy
            // 
            this.LblFilterBy.AutoSize = true;
            this.LblFilterBy.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LblFilterBy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblFilterBy.Location = new System.Drawing.Point(44, 242);
            this.LblFilterBy.Name = "LblFilterBy";
            this.LblFilterBy.Size = new System.Drawing.Size(104, 30);
            this.LblFilterBy.TabIndex = 4;
            this.LblFilterBy.Text = "Filter By:";
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
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(1331, 775);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 4;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            // 
            // CBFilterBy
            // 
            this.CBFilterBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFilterBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBFilterBy.ForeColor = System.Drawing.Color.Black;
            this.CBFilterBy.FormattingEnabled = true;
            this.CBFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "Person ID",
            "Full Name",
            "Is ActiveStatus"});
            this.CBFilterBy.Location = new System.Drawing.Point(154, 245);
            this.CBFilterBy.Name = "CBFilterBy";
            this.CBFilterBy.Size = new System.Drawing.Size(208, 31);
            this.CBFilterBy.TabIndex = 0;
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
            // MTBsearch
            // 
            this.MTBsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.MTBsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MTBsearch.ForeColor = System.Drawing.Color.Black;
            this.MTBsearch.Location = new System.Drawing.Point(371, 245);
            this.MTBsearch.Name = "MTBsearch";
            this.MTBsearch.Size = new System.Drawing.Size(184, 30);
            this.MTBsearch.TabIndex = 1;
            // 
            // FOManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 932);
            this.Controls.Add(this.MTBsearch);
            this.Controls.Add(this.LblTotalRecoreds);
            this.Controls.Add(this.CBFilterBy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblRecoreds);
            this.Controls.Add(this.LblFilterBy);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.PBManageUsers);
            this.Controls.Add(this.LblManageUsers);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManageUsers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManageUsers;
        private Button BtnAddUser;
        private PictureBox PBManageUsers;
        private Label LblFilterBy;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDUsers;
        private ToolStripMenuItem SMItemViewDetails;
        private ToolStripSeparator SMItemSeparatorCRUDUsers1;
        private ToolStripMenuItem SMItemAddUser;
        private ToolStripMenuItem SMItemEditUser;
        private ToolStripMenuItem SMItemDeleteUser;
        private ToolStripSeparator SMItemSeparatorCRUDUsers2;
        private ToolStripMenuItem SMItemSendEmail;
        private ToolStripMenuItem SMItemCallUser;
        private ComboBox CBFilterBy;
        private Label LblTotalRecoreds;
        private MaskedTextBox MTBsearch;
    }
}