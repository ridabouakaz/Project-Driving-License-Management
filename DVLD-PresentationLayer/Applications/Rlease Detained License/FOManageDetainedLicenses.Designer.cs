using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOManageDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManageDetainedLicenses));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.SMItemCRUDUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemShowLicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemShowPersonLicenseHistroy = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDUsers2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManageDetainedLicenses = new System.Windows.Forms.Label();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.PBManageDetainedLicenses = new System.Windows.Forms.PictureBox();
            this.LblFilterBy = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            this.btnReleaseDetainedLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SMItemCRUDUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageDetainedLicenses)).BeginInit();
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
            this.SMItemShowPersonDetails,
            this.SMItemShowLicenseDetails,
            this.SMItemShowPersonLicenseHistroy,
            this.SMItemSeparatorCRUDUsers2,
            this.SMItemReleaseDetainedLicense});
            this.SMItemCRUDUsers.Name = "SMItemCRUDUsers";
            this.SMItemCRUDUsers.Size = new System.Drawing.Size(308, 162);
            // 
            // SMItemShowPersonDetails
            // 
            this.SMItemShowPersonDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemShowPersonDetails.Image = ((System.Drawing.Image)(resources.GetObject("SMItemShowPersonDetails.Image")));
            this.SMItemShowPersonDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemShowPersonDetails.Name = "SMItemShowPersonDetails";
            this.SMItemShowPersonDetails.Size = new System.Drawing.Size(307, 38);
            this.SMItemShowPersonDetails.Text = "Show Person Details";
            this.SMItemShowPersonDetails.Click += new System.EventHandler(this.SMItemViewDetails_Click);
            // 
            // SMItemShowLicenseDetails
            // 
            this.SMItemShowLicenseDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemShowLicenseDetails.Image = ((System.Drawing.Image)(resources.GetObject("SMItemShowLicenseDetails.Image")));
            this.SMItemShowLicenseDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemShowLicenseDetails.Name = "SMItemShowLicenseDetails";
            this.SMItemShowLicenseDetails.Size = new System.Drawing.Size(307, 38);
            this.SMItemShowLicenseDetails.Text = "Show License Details";
            this.SMItemShowLicenseDetails.Click += new System.EventHandler(this.SMItemAddUser_Click);
            // 
            // SMItemShowPersonLicenseHistroy
            // 
            this.SMItemShowPersonLicenseHistroy.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemShowPersonLicenseHistroy.Image = ((System.Drawing.Image)(resources.GetObject("SMItemShowPersonLicenseHistroy.Image")));
            this.SMItemShowPersonLicenseHistroy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemShowPersonLicenseHistroy.Name = "SMItemShowPersonLicenseHistroy";
            this.SMItemShowPersonLicenseHistroy.Size = new System.Drawing.Size(307, 38);
            this.SMItemShowPersonLicenseHistroy.Text = "Show Person License Histroy";
            this.SMItemShowPersonLicenseHistroy.Click += new System.EventHandler(this.SMItemEditUser_Click);
            // 
            // SMItemSeparatorCRUDUsers2
            // 
            this.SMItemSeparatorCRUDUsers2.Name = "SMItemSeparatorCRUDUsers2";
            this.SMItemSeparatorCRUDUsers2.Size = new System.Drawing.Size(304, 6);
            // 
            // SMItemReleaseDetainedLicense
            // 
            this.SMItemReleaseDetainedLicense.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("SMItemReleaseDetainedLicense.Image")));
            this.SMItemReleaseDetainedLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemReleaseDetainedLicense.Name = "SMItemReleaseDetainedLicense";
            this.SMItemReleaseDetainedLicense.Size = new System.Drawing.Size(307, 38);
            this.SMItemReleaseDetainedLicense.Text = "Release Detained License";
            this.SMItemReleaseDetainedLicense.Click += new System.EventHandler(this.SMItemReleaseDetainedLicense_Click);
            // 
            // LblManageDetainedLicenses
            // 
            this.LblManageDetainedLicenses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageDetainedLicenses.AutoSize = true;
            this.LblManageDetainedLicenses.BackColor = System.Drawing.Color.Transparent;
            this.LblManageDetainedLicenses.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageDetainedLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageDetainedLicenses.Location = new System.Drawing.Point(499, 159);
            this.LblManageDetainedLicenses.Name = "LblManageDetainedLicenses";
            this.LblManageDetainedLicenses.Size = new System.Drawing.Size(524, 54);
            this.LblManageDetainedLicenses.TabIndex = 1;
            this.LblManageDetainedLicenses.Text = "Manage Detained Licenses";
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetainLicense.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetainLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDetainLicense.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDetainLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDetainLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnDetainLicense.Image")));
            this.btnDetainLicense.Location = new System.Drawing.Point(1396, 228);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(90, 45);
            this.btnDetainLicense.TabIndex = 2;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // PBManageDetainedLicenses
            // 
            this.PBManageDetainedLicenses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageDetainedLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageDetainedLicenses.Image = ((System.Drawing.Image)(resources.GetObject("PBManageDetainedLicenses.Image")));
            this.PBManageDetainedLicenses.Location = new System.Drawing.Point(710, 31);
            this.PBManageDetainedLicenses.Name = "PBManageDetainedLicenses";
            this.PBManageDetainedLicenses.Size = new System.Drawing.Size(137, 125);
            this.PBManageDetainedLicenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageDetainedLicenses.TabIndex = 2;
            this.PBManageDetainedLicenses.TabStop = false;
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
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
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
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.CBFilterBy.Location = new System.Drawing.Point(154, 245);
            this.CBFilterBy.Name = "CBFilterBy";
            this.CBFilterBy.Size = new System.Drawing.Size(208, 31);
            this.CBFilterBy.TabIndex = 0;
            this.CBFilterBy.SelectedIndexChanged += new System.EventHandler(this.CBFilterBy_SelectedIndexChanged);
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
            this.MTBsearch.Size = new System.Drawing.Size(258, 30);
            this.MTBsearch.TabIndex = 1;
            this.MTBsearch.TextChanged += new System.EventHandler(this.MTBsearch_TextChanged);
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsReleased.ForeColor = System.Drawing.Color.Black;
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(371, 245);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(201, 31);
            this.cbIsReleased.TabIndex = 9;
            this.cbIsReleased.TextChanged += new System.EventHandler(this.CBActiveStatusBy_TextChanged);
            // 
            // btnReleaseDetainedLicense
            // 
            this.btnReleaseDetainedLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReleaseDetainedLicense.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReleaseDetainedLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReleaseDetainedLicense.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReleaseDetainedLicense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReleaseDetainedLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnReleaseDetainedLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseDetainedLicense.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReleaseDetainedLicense.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseDetainedLicense.Image")));
            this.btnReleaseDetainedLicense.Location = new System.Drawing.Point(1280, 228);
            this.btnReleaseDetainedLicense.Name = "btnReleaseDetainedLicense";
            this.btnReleaseDetainedLicense.Size = new System.Drawing.Size(90, 45);
            this.btnReleaseDetainedLicense.TabIndex = 10;
            this.btnReleaseDetainedLicense.UseVisualStyleBackColor = false;
            this.btnReleaseDetainedLicense.Click += new System.EventHandler(this.btnReleaseDetainedLicense_Click);
            // 
            // FOManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 932);
            this.Controls.Add(this.btnReleaseDetainedLicense);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.MTBsearch);
            this.Controls.Add(this.LblTotalRecoreds);
            this.Controls.Add(this.CBFilterBy);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblRecoreds);
            this.Controls.Add(this.LblFilterBy);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.PBManageDetainedLicenses);
            this.Controls.Add(this.LblManageDetainedLicenses);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManageDetainedLicenses";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.FOManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageDetainedLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManageDetainedLicenses;
        private Button btnDetainLicense;
        private PictureBox PBManageDetainedLicenses;
        private Label LblFilterBy;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDUsers;
        private ToolStripMenuItem SMItemShowPersonDetails;
        private ToolStripMenuItem SMItemShowLicenseDetails;
        private ToolStripMenuItem SMItemShowPersonLicenseHistroy;
        private ToolStripMenuItem SMItemReleaseDetainedLicense;
        private ComboBox CBFilterBy;
        private Label LblTotalRecoreds;
        private MaskedTextBox MTBsearch;
        private ComboBox cbIsReleased;
        private ToolStripSeparator SMItemSeparatorCRUDUsers2;
        private Button btnReleaseDetainedLicense;
    }
}