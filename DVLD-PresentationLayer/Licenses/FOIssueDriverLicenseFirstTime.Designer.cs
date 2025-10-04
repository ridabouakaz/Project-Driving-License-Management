using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    partial class FOIssueDriverLicenseFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOIssueDriverLicenseFirstTime));
            this.SMItemCRUDUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItemTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LblNotes = new System.Windows.Forms.Label();
            this.ctrDrivingLicenseApplicationInfo1 = new DVLD_PresentationLayer.CtrDrivingLicenseApplicationInfo();
            this.TBNotes = new System.Windows.Forms.TextBox();
            this.PBNotes = new System.Windows.Forms.PictureBox();
            this.BtnIssue = new System.Windows.Forms.Button();
            this.SMItemCRUDUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // SMItemCRUDUsers
            // 
            this.SMItemCRUDUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMItemCRUDUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemEdit,
            this.SMItemTakeTest});
            this.SMItemCRUDUsers.Name = "SMItemCRUDUsers";
            this.SMItemCRUDUsers.Size = new System.Drawing.Size(170, 80);
            // 
            // SMItemEdit
            // 
            this.SMItemEdit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemEdit.Image = ((System.Drawing.Image)(resources.GetObject("SMItemEdit.Image")));
            this.SMItemEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemEdit.Name = "SMItemEdit";
            this.SMItemEdit.Size = new System.Drawing.Size(169, 38);
            this.SMItemEdit.Text = "Edit";
            // 
            // SMItemTakeTest
            // 
            this.SMItemTakeTest.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemTakeTest.Image = ((System.Drawing.Image)(resources.GetObject("SMItemTakeTest.Image")));
            this.SMItemTakeTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemTakeTest.Name = "SMItemTakeTest";
            this.SMItemTakeTest.Size = new System.Drawing.Size(169, 38);
            this.SMItemTakeTest.Text = "Take Test";
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
            this.BtnAddClose.Location = new System.Drawing.Point(824, 641);
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
            // LblNotes
            // 
            this.LblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNotes.AutoSize = true;
            this.LblNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblNotes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LblNotes.Location = new System.Drawing.Point(12, 420);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(73, 28);
            this.LblNotes.TabIndex = 9;
            this.LblNotes.Text = "Notes:";
            // 
            // ctrDrivingLicenseApplicationInfo1
            // 
            this.ctrDrivingLicenseApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 12);
            this.ctrDrivingLicenseApplicationInfo1.Name = "ctrDrivingLicenseApplicationInfo1";
            this.ctrDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(1168, 395);
            this.ctrDrivingLicenseApplicationInfo1.TabIndex = 10;
            // 
            // TBNotes
            // 
            this.TBNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBNotes.ForeColor = System.Drawing.Color.Black;
            this.TBNotes.Location = new System.Drawing.Point(137, 423);
            this.TBNotes.Multiline = true;
            this.TBNotes.Name = "TBNotes";
            this.TBNotes.Size = new System.Drawing.Size(1015, 202);
            this.TBNotes.TabIndex = 22;
            // 
            // PBNotes
            // 
            this.PBNotes.Image = ((System.Drawing.Image)(resources.GetObject("PBNotes.Image")));
            this.PBNotes.Location = new System.Drawing.Point(91, 420);
            this.PBNotes.Name = "PBNotes";
            this.PBNotes.Size = new System.Drawing.Size(40, 32);
            this.PBNotes.TabIndex = 55;
            this.PBNotes.TabStop = false;
            // 
            // BtnIssue
            // 
            this.BtnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIssue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnIssue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnIssue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnIssue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIssue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIssue.Image = ((System.Drawing.Image)(resources.GetObject("BtnIssue.Image")));
            this.BtnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIssue.Location = new System.Drawing.Point(997, 641);
            this.BtnIssue.Name = "BtnIssue";
            this.BtnIssue.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnIssue.Size = new System.Drawing.Size(155, 50);
            this.BtnIssue.TabIndex = 56;
            this.BtnIssue.Text = "Issue";
            this.BtnIssue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIssue.UseVisualStyleBackColor = false;
            // 
            // FOIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 703);
            this.Controls.Add(this.BtnIssue);
            this.Controls.Add(this.PBNotes);
            this.Controls.Add(this.TBNotes);
            this.Controls.Add(this.ctrDrivingLicenseApplicationInfo1);
            this.Controls.Add(this.LblNotes);
            this.Controls.Add(this.BtnAddClose);
            this.Name = "FOIssueDriverLicenseFirstTime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driver License First Time";
            this.Load += new System.EventHandler(this.FOListTestAppointments_Load);
            this.SMItemCRUDUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDUsers;
        private ToolStripMenuItem SMItemEdit;
        private ToolStripMenuItem SMItemTakeTest;
        private Label LblNotes;
        private CtrDrivingLicenseApplicationInfo ctrDrivingLicenseApplicationInfo1;
        private TextBox TBNotes;
        private PictureBox PBNotes;
        private Button BtnIssue;
    }
}