using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOManageDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManageDrivers));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.SMItemCRUDDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDDrivers1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemCallDriver = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManageDrivers = new System.Windows.Forms.Label();
            this.BtnAddDriver = new System.Windows.Forms.Button();
            this.PBManageDrivers = new System.Windows.Forms.PictureBox();
            this.LblFilterBy = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SMItemCRUDDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageDrivers)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewShowInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.ContextMenuStrip = this.SMItemCRUDDrivers;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGViewShowInformation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGViewShowInformation.Location = new System.Drawing.Point(47, 279);
            this.dGViewShowInformation.Name = "dGViewShowInformation";
            this.dGViewShowInformation.ReadOnly = true;
            this.dGViewShowInformation.RowHeadersWidth = 51;
            this.dGViewShowInformation.RowTemplate.Height = 24;
            this.dGViewShowInformation.Size = new System.Drawing.Size(1439, 481);
            this.dGViewShowInformation.TabIndex = 3;
            // 
            // SMItemCRUDDrivers
            // 
            this.SMItemCRUDDrivers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMItemCRUDDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemViewDetails,
            this.SMItemSeparatorCRUDDrivers1,
            this.SMItemSendEmail,
            this.SMItemCallDriver});
            this.SMItemCRUDDrivers.Name = "SMItemCRUDDrivers";
            this.SMItemCRUDDrivers.Size = new System.Drawing.Size(189, 124);
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
            // SMItemSeparatorCRUDDrivers1
            // 
            this.SMItemSeparatorCRUDDrivers1.Name = "SMItemSeparatorCRUDDrivers1";
            this.SMItemSeparatorCRUDDrivers1.Size = new System.Drawing.Size(185, 6);
            // 
            // SMItemSendEmail
            // 
            this.SMItemSendEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("SMItemSendEmail.Image")));
            this.SMItemSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemSendEmail.Name = "SMItemSendEmail";
            this.SMItemSendEmail.Size = new System.Drawing.Size(188, 38);
            this.SMItemSendEmail.Text = "Send Email";
            // 
            // SMItemCallDriver
            // 
            this.SMItemCallDriver.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemCallDriver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemCallDriver.Name = "SMItemCallDriver";
            this.SMItemCallDriver.Size = new System.Drawing.Size(188, 38);
            this.SMItemCallDriver.Text = "Call Driver";
            // 
            // LblManageDrivers
            // 
            this.LblManageDrivers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageDrivers.AutoSize = true;
            this.LblManageDrivers.BackColor = System.Drawing.Color.Transparent;
            this.LblManageDrivers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageDrivers.Location = new System.Drawing.Point(635, 159);
            this.LblManageDrivers.Name = "LblManageDrivers";
            this.LblManageDrivers.Size = new System.Drawing.Size(322, 54);
            this.LblManageDrivers.TabIndex = 1;
            this.LblManageDrivers.Text = "Manage Drivers";
            // 
            // BtnAddDriver
            // 
            this.BtnAddDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddDriver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddDriver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddDriver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddDriver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddDriver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddDriver.Location = new System.Drawing.Point(1396, 228);
            this.BtnAddDriver.Name = "BtnAddDriver";
            this.BtnAddDriver.Size = new System.Drawing.Size(90, 45);
            this.BtnAddDriver.TabIndex = 2;
            this.BtnAddDriver.UseVisualStyleBackColor = false;
            // 
            // PBManageDrivers
            // 
            this.PBManageDrivers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageDrivers.Location = new System.Drawing.Point(710, 31);
            this.PBManageDrivers.Name = "PBManageDrivers";
            this.PBManageDrivers.Size = new System.Drawing.Size(137, 125);
            this.PBManageDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageDrivers.TabIndex = 2;
            this.PBManageDrivers.TabStop = false;
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
            "Driver ID",
            "Driver Name",
            "Person ID",
            "Full Name"});
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
            this.MTBsearch.Size = new System.Drawing.Size(258, 30);
            this.MTBsearch.TabIndex = 1;
            this.MTBsearch.TextChanged += new System.EventHandler(this.MTBsearch_TextChanged);
            // 
            // FOManageDrivers
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
            this.Controls.Add(this.BtnAddDriver);
            this.Controls.Add(this.PBManageDrivers);
            this.Controls.Add(this.LblManageDrivers);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManageDrivers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Drivers";
            this.Load += new System.EventHandler(this.FOManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManageDrivers;
        private Button BtnAddDriver;
        private PictureBox PBManageDrivers;
        private Label LblFilterBy;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDDrivers;
        private ToolStripMenuItem SMItemViewDetails;
        private ToolStripSeparator SMItemSeparatorCRUDDrivers1;
        private ToolStripMenuItem SMItemSendEmail;
        private ToolStripMenuItem SMItemCallDriver;
        private ComboBox CBFilterBy;
        private Label LblTotalRecoreds;
        private MaskedTextBox MTBsearch;
    }
}