using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_PresentationLayer
{
    partial class FOManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManagePeople));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.SMItemCRUDpeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDPeople1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemSeparatorCRUDPeople2 = new System.Windows.Forms.ToolStripSeparator();
            this.SMItemSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemCallPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManagePeople = new System.Windows.Forms.Label();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.PBManagePeople = new System.Windows.Forms.PictureBox();
            this.LblFilterBy = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.CBFilterBy = new System.Windows.Forms.ComboBox();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SMItemCRUDpeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManagePeople)).BeginInit();
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
            this.dGViewShowInformation.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGViewShowInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.ContextMenuStrip = this.SMItemCRUDpeople;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11F);
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
            // SMItemCRUDpeople
            // 
            this.SMItemCRUDpeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMItemCRUDpeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemViewDetails,
            this.SMItemSeparatorCRUDPeople1,
            this.SMItemAddPerson,
            this.SMItemEditPerson,
            this.SMItemDeletePerson,
            this.SMItemSeparatorCRUDPeople2,
            this.SMItemSendEmail,
            this.SMItemCallPerson});
            this.SMItemCRUDpeople.Name = "SMItemCRUDpeople";
            this.SMItemCRUDpeople.Size = new System.Drawing.Size(200, 244);
            // 
            // SMItemViewDetails
            // 
            this.SMItemViewDetails.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemViewDetails.Image = ((System.Drawing.Image)(resources.GetObject("SMItemViewDetails.Image")));
            this.SMItemViewDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemViewDetails.Name = "SMItemViewDetails";
            this.SMItemViewDetails.Size = new System.Drawing.Size(199, 38);
            this.SMItemViewDetails.Text = "View Details";
            this.SMItemViewDetails.Click += new System.EventHandler(this.SMItemViewDetails_Click);
            // 
            // SMItemSeparatorCRUDPeople1
            // 
            this.SMItemSeparatorCRUDPeople1.Name = "SMItemSeparatorCRUDPeople1";
            this.SMItemSeparatorCRUDPeople1.Size = new System.Drawing.Size(196, 6);
            // 
            // SMItemAddPerson
            // 
            this.SMItemAddPerson.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("SMItemAddPerson.Image")));
            this.SMItemAddPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemAddPerson.Name = "SMItemAddPerson";
            this.SMItemAddPerson.Size = new System.Drawing.Size(199, 38);
            this.SMItemAddPerson.Text = "Add Person";
            this.SMItemAddPerson.Click += new System.EventHandler(this.SMItemAddPerson_Click);
            // 
            // SMItemEditPerson
            // 
            this.SMItemEditPerson.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemEditPerson.Image = ((System.Drawing.Image)(resources.GetObject("SMItemEditPerson.Image")));
            this.SMItemEditPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemEditPerson.Name = "SMItemEditPerson";
            this.SMItemEditPerson.Size = new System.Drawing.Size(199, 38);
            this.SMItemEditPerson.Text = "Edit Person";
            this.SMItemEditPerson.Click += new System.EventHandler(this.SMItemEditPerson_Click);
            // 
            // SMItemDeletePerson
            // 
            this.SMItemDeletePerson.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemDeletePerson.Image = ((System.Drawing.Image)(resources.GetObject("SMItemDeletePerson.Image")));
            this.SMItemDeletePerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemDeletePerson.Name = "SMItemDeletePerson";
            this.SMItemDeletePerson.Size = new System.Drawing.Size(199, 38);
            this.SMItemDeletePerson.Text = "Delete Person";
            this.SMItemDeletePerson.Click += new System.EventHandler(this.SMItemDeletePerson_Click);
            // 
            // SMItemSeparatorCRUDPeople2
            // 
            this.SMItemSeparatorCRUDPeople2.Name = "SMItemSeparatorCRUDPeople2";
            this.SMItemSeparatorCRUDPeople2.Size = new System.Drawing.Size(196, 6);
            // 
            // SMItemSendEmail
            // 
            this.SMItemSendEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("SMItemSendEmail.Image")));
            this.SMItemSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemSendEmail.Name = "SMItemSendEmail";
            this.SMItemSendEmail.Size = new System.Drawing.Size(199, 38);
            this.SMItemSendEmail.Text = "Send Email";
            // 
            // SMItemCallPerson
            // 
            this.SMItemCallPerson.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemCallPerson.Image = ((System.Drawing.Image)(resources.GetObject("SMItemCallPerson.Image")));
            this.SMItemCallPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemCallPerson.Name = "SMItemCallPerson";
            this.SMItemCallPerson.Size = new System.Drawing.Size(199, 38);
            this.SMItemCallPerson.Text = "Call Person";
            // 
            // LblManagePeople
            // 
            this.LblManagePeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManagePeople.AutoSize = true;
            this.LblManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.LblManagePeople.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManagePeople.Location = new System.Drawing.Point(620, 159);
            this.LblManagePeople.Name = "LblManagePeople";
            this.LblManagePeople.Size = new System.Drawing.Size(315, 54);
            this.LblManagePeople.TabIndex = 1;
            this.LblManagePeople.Text = "Manage People";
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAddPerson.BackgroundImage")));
            this.BtnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddPerson.Location = new System.Drawing.Point(1396, 228);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(90, 45);
            this.BtnAddPerson.TabIndex = 2;
            this.BtnAddPerson.UseVisualStyleBackColor = false;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // PBManagePeople
            // 
            this.PBManagePeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManagePeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("PBManagePeople.Image")));
            this.PBManagePeople.Location = new System.Drawing.Point(710, 31);
            this.PBManagePeople.Name = "PBManagePeople";
            this.PBManagePeople.Size = new System.Drawing.Size(137, 125);
            this.PBManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManagePeople.TabIndex = 2;
            this.PBManagePeople.TabStop = false;
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
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email"});
            this.CBFilterBy.Location = new System.Drawing.Point(145, 245);
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
            this.LblTotalRecoreds.Size = new System.Drawing.Size(24, 28);
            this.LblTotalRecoreds.TabIndex = 8;
            this.LblTotalRecoreds.Text = "2";
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
            this.MTBsearch.TextChanged += new System.EventHandler(this.MTBsearch_TextChanged);
            // 
            // FOManagePeople
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
            this.Controls.Add(this.BtnAddPerson);
            this.Controls.Add(this.PBManagePeople);
            this.Controls.Add(this.LblManagePeople);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManagePeople";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.FOManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDpeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManagePeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManagePeople;
        private Button BtnAddPerson;
        private PictureBox PBManagePeople;
        private Label LblFilterBy;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDpeople;
        private ToolStripMenuItem SMItemViewDetails;
        private ToolStripSeparator SMItemSeparatorCRUDPeople1;
        private ToolStripMenuItem SMItemAddPerson;
        private ToolStripMenuItem SMItemEditPerson;
        private ToolStripMenuItem SMItemDeletePerson;
        private ToolStripSeparator SMItemSeparatorCRUDPeople2;
        private ToolStripMenuItem SMItemSendEmail;
        private ToolStripMenuItem SMItemCallPerson;
        private ComboBox CBFilterBy;
        private Label LblTotalRecoreds;
        private MaskedTextBox MTBsearch;
    }
}