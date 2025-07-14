using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManagePeople));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.LblManagePeople = new System.Windows.Forms.Label();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.PBManagePeople = new System.Windows.Forms.PictureBox();
            this.LblFilterBy = new System.Windows.Forms.Label();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
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
            this.dGViewShowInformation.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.Location = new System.Drawing.Point(47, 279);
            this.dGViewShowInformation.Name = "dGViewShowInformation";
            this.dGViewShowInformation.ReadOnly = true;
            this.dGViewShowInformation.RowHeadersWidth = 51;
            this.dGViewShowInformation.RowTemplate.Height = 24;
            this.dGViewShowInformation.Size = new System.Drawing.Size(1439, 481);
            this.dGViewShowInformation.TabIndex = 0;
            // 
            // LblManagePeople
            // 
            this.LblManagePeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManagePeople.AutoSize = true;
            this.LblManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.LblManagePeople.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManagePeople.Location = new System.Drawing.Point(580, 143);
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
            this.BtnAddPerson.TabIndex = 3;
            this.BtnAddPerson.UseVisualStyleBackColor = false;
            // 
            // PBManagePeople
            // 
            this.PBManagePeople.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManagePeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("PBManagePeople.Image")));
            this.PBManagePeople.Location = new System.Drawing.Point(670, 15);
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
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(1331, 775);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(155, 50);
            this.BtnAddClose.TabIndex = 6;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // 
            // FOManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 932);
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
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBManagePeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManagePeople;
        //private Guna.UI2.WinForms.Guna2PictureBox PBManagePeople;
        private Button BtnAddPerson;
        private PictureBox PBManagePeople;
        private Label LblFilterBy;
        private Label LblRecoreds;
        private Button BtnAddClose;
    }
}