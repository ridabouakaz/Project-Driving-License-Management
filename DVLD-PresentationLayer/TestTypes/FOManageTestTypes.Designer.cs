using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOManageTestTypes));
            this.dGViewShowInformation = new System.Windows.Forms.DataGridView();
            this.SMItemCRUDUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMItemEditTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.LblManageTestTypes = new System.Windows.Forms.Label();
            this.PBManageTestTypes = new System.Windows.Forms.PictureBox();
            this.LblRecoreds = new System.Windows.Forms.Label();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.LblTotalRecoreds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).BeginInit();
            this.SMItemCRUDUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBManageTestTypes)).BeginInit();
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
            this.dGViewShowInformation.ContextMenuStrip = this.SMItemCRUDUsers;
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
            this.dGViewShowInformation.Size = new System.Drawing.Size(987, 481);
            this.dGViewShowInformation.TabIndex = 3;
            // 
            // SMItemCRUDUsers
            // 
            this.SMItemCRUDUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMItemCRUDUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItemEditTestType});
            this.SMItemCRUDUsers.Name = "SMItemCRUDUsers";
            this.SMItemCRUDUsers.Size = new System.Drawing.Size(227, 70);
            // 
            // SMItemEditTestType
            // 
            this.SMItemEditTestType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.SMItemEditTestType.Image = ((System.Drawing.Image)(resources.GetObject("SMItemEditTestType.Image")));
            this.SMItemEditTestType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SMItemEditTestType.Name = "SMItemEditTestType";
            this.SMItemEditTestType.Size = new System.Drawing.Size(226, 38);
            this.SMItemEditTestType.Text = "Edit Test Type";
            this.SMItemEditTestType.Click += new System.EventHandler(this.SMItemEditTestType_Click);
            // 
            // LblManageTestTypes
            // 
            this.LblManageTestTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblManageTestTypes.AutoSize = true;
            this.LblManageTestTypes.BackColor = System.Drawing.Color.Transparent;
            this.LblManageTestTypes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblManageTestTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblManageTestTypes.Location = new System.Drawing.Point(275, 182);
            this.LblManageTestTypes.Name = "LblManageTestTypes";
            this.LblManageTestTypes.Size = new System.Drawing.Size(522, 54);
            this.LblManageTestTypes.TabIndex = 1;
            this.LblManageTestTypes.Text = "Manage Application Types";
            // 
            // PBManageTestTypes
            // 
            this.PBManageTestTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PBManageTestTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PBManageTestTypes.Image = ((System.Drawing.Image)(resources.GetObject("PBManageTestTypes.Image")));
            this.PBManageTestTypes.Location = new System.Drawing.Point(469, 30);
            this.PBManageTestTypes.Name = "PBManageTestTypes";
            this.PBManageTestTypes.Size = new System.Drawing.Size(137, 125);
            this.PBManageTestTypes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBManageTestTypes.TabIndex = 2;
            this.PBManageTestTypes.TabStop = false;
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
            this.BtnAddClose.Location = new System.Drawing.Point(879, 775);
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
            this.LblTotalRecoreds.Location = new System.Drawing.Point(161, 775);
            this.LblTotalRecoreds.Name = "LblTotalRecoreds";
            this.LblTotalRecoreds.Size = new System.Drawing.Size(30, 28);
            this.LblTotalRecoreds.TabIndex = 8;
            this.LblTotalRecoreds.Text = "??";
            // 
            // FOManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 932);
            this.Controls.Add(this.LblTotalRecoreds);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.LblRecoreds);
            this.Controls.Add(this.PBManageTestTypes);
            this.Controls.Add(this.LblManageTestTypes);
            this.Controls.Add(this.dGViewShowInformation);
            this.Name = "FOManageTestTypes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.FOManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGViewShowInformation)).EndInit();
            this.SMItemCRUDUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBManageTestTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGViewShowInformation;
        private System.Windows.Forms.Label LblManageTestTypes;
        private PictureBox PBManageTestTypes;
        private Label LblRecoreds;
        private Button BtnAddClose;
        private ContextMenuStrip SMItemCRUDUsers;
        private ToolStripMenuItem SMItemEditTestType;
        private Label LblTotalRecoreds;
    }
}