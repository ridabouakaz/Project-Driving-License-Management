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
            this.PBManagePeople = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBManagePeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dGViewShowInformation
            // 
            this.dGViewShowInformation.AllowUserToAddRows = false;
            this.dGViewShowInformation.AllowUserToDeleteRows = false;
            this.dGViewShowInformation.AllowUserToOrderColumns = true;
            this.dGViewShowInformation.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dGViewShowInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGViewShowInformation.Location = new System.Drawing.Point(47, 279);
            this.dGViewShowInformation.Name = "dGViewShowInformation";
            this.dGViewShowInformation.ReadOnly = true;
            this.dGViewShowInformation.RowHeadersWidth = 51;
            this.dGViewShowInformation.RowTemplate.Height = 24;
            this.dGViewShowInformation.Size = new System.Drawing.Size(1345, 441);
            this.dGViewShowInformation.TabIndex = 0;
            this.dGViewShowInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // LblManagePeople
            // 
            this.LblManagePeople.AutoSize = true;
            this.LblManagePeople.BackColor = System.Drawing.Color.Transparent;
            this.LblManagePeople.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManagePeople.Location = new System.Drawing.Point(533, 143);
            this.LblManagePeople.Name = "LblManagePeople";
            this.LblManagePeople.Size = new System.Drawing.Size(315, 54);
            this.LblManagePeople.TabIndex = 1;
            this.LblManagePeople.Text = "Manage People";
            this.LblManagePeople.Anchor = AnchorStyles.Top;

            // 
            // PBManagePeople
            // 
            this.PBManagePeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManagePeople.Image = ((System.Drawing.Image)(resources.GetObject("PBManagePeople.Image")));
            this.PBManagePeople.ImageRotate = 0F;
            this.PBManagePeople.Location = new System.Drawing.Point(623, 15);
            this.PBManagePeople.Name = "PBManagePeople";
            this.PBManagePeople.Size = new System.Drawing.Size(137, 125);
            this.PBManagePeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManagePeople.TabIndex = 2;
            this.PBManagePeople.TabStop = false;
            this.PBManagePeople.Anchor = AnchorStyles.Top ;

            // 
            // FOManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 853);
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
        private Guna.UI2.WinForms.Guna2PictureBox PBManagePeople;
    }
}