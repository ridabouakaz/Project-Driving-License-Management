namespace DVLD_PresentationLayer
{
    partial class FOEditApplicationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOEditApplicationType));
            this.LblAddEditPerson = new System.Windows.Forms.Label();
            this.LblFees = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.PBFees = new System.Windows.Forms.PictureBox();
            this.PBTitle = new System.Windows.Forms.PictureBox();
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.TBFees = new System.Windows.Forms.TextBox();
            this.LblValueID = new System.Windows.Forms.Label();
            this.BtnAddSave = new System.Windows.Forms.Button();
            this.BtnAddClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddEditPerson
            // 
            this.LblAddEditPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddEditPerson.AutoSize = true;
            this.LblAddEditPerson.BackColor = System.Drawing.Color.Transparent;
            this.LblAddEditPerson.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblAddEditPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblAddEditPerson.Location = new System.Drawing.Point(71, 9);
            this.LblAddEditPerson.Name = "LblAddEditPerson";
            this.LblAddEditPerson.Size = new System.Drawing.Size(454, 50);
            this.LblAddEditPerson.TabIndex = 3;
            this.LblAddEditPerson.Text = "Update Application Type";
            // 
            // LblFees
            // 
            this.LblFees.AutoSize = true;
            this.LblFees.BackColor = System.Drawing.Color.Transparent;
            this.LblFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblFees.Location = new System.Drawing.Point(31, 181);
            this.LblFees.Name = "LblFees";
            this.LblFees.Size = new System.Drawing.Size(58, 28);
            this.LblFees.TabIndex = 38;
            this.LblFees.Text = "Fees:";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblTitle.Location = new System.Drawing.Point(31, 130);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(60, 28);
            this.LblTitle.TabIndex = 39;
            this.LblTitle.Text = "Title:";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BackColor = System.Drawing.Color.Transparent;
            this.LblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblID.Location = new System.Drawing.Point(51, 78);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(38, 28);
            this.LblID.TabIndex = 40;
            this.LblID.Text = "ID:";
            // 
            // PBFees
            // 
            this.PBFees.Image = ((System.Drawing.Image)(resources.GetObject("PBFees.Image")));
            this.PBFees.Location = new System.Drawing.Point(97, 181);
            this.PBFees.Name = "PBFees";
            this.PBFees.Size = new System.Drawing.Size(32, 32);
            this.PBFees.TabIndex = 41;
            this.PBFees.TabStop = false;
            // 
            // PBTitle
            // 
            this.PBTitle.Image = ((System.Drawing.Image)(resources.GetObject("PBTitle.Image")));
            this.PBTitle.Location = new System.Drawing.Point(97, 130);
            this.PBTitle.Name = "PBTitle";
            this.PBTitle.Size = new System.Drawing.Size(32, 32);
            this.PBTitle.TabIndex = 42;
            this.PBTitle.TabStop = false;
            // 
            // TBTitle
            // 
            this.TBTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBTitle.ForeColor = System.Drawing.Color.Black;
            this.TBTitle.Location = new System.Drawing.Point(164, 131);
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.Size = new System.Drawing.Size(361, 30);
            this.TBTitle.TabIndex = 43;
            this.TBTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TBTitle_Validating);
            // 
            // TBFees
            // 
            this.TBFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.TBFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFees.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TBFees.ForeColor = System.Drawing.Color.Black;
            this.TBFees.Location = new System.Drawing.Point(164, 181);
            this.TBFees.Name = "TBFees";
            this.TBFees.Size = new System.Drawing.Size(361, 30);
            this.TBFees.TabIndex = 44;
            this.TBFees.Validating += new System.ComponentModel.CancelEventHandler(this.TBFees_Validating);
            // 
            // LblValueID
            // 
            this.LblValueID.AutoSize = true;
            this.LblValueID.BackColor = System.Drawing.Color.Transparent;
            this.LblValueID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblValueID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblValueID.Location = new System.Drawing.Point(159, 78);
            this.LblValueID.Name = "LblValueID";
            this.LblValueID.Size = new System.Drawing.Size(30, 28);
            this.LblValueID.TabIndex = 45;
            this.LblValueID.Text = "??";
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSave.Image")));
            this.BtnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSave.Location = new System.Drawing.Point(395, 254);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddSave.Size = new System.Drawing.Size(130, 48);
            this.BtnAddSave.TabIndex = 46;
            this.BtnAddSave.Text = "Save";
            this.BtnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSave.UseVisualStyleBackColor = false;
            this.BtnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // BtnAddClose
            // 
            this.BtnAddClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddClose.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddClose.Image")));
            this.BtnAddClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddClose.Location = new System.Drawing.Point(225, 254);
            this.BtnAddClose.Name = "BtnAddClose";
            this.BtnAddClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddClose.Size = new System.Drawing.Size(142, 48);
            this.BtnAddClose.TabIndex = 47;
            this.BtnAddClose.Text = "Close";
            this.BtnAddClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddClose.UseVisualStyleBackColor = false;
            this.BtnAddClose.Click += new System.EventHandler(this.BtnAddClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FOEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 342);
            this.Controls.Add(this.BtnAddClose);
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.LblValueID);
            this.Controls.Add(this.TBFees);
            this.Controls.Add(this.TBTitle);
            this.Controls.Add(this.PBTitle);
            this.Controls.Add(this.PBFees);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblFees);
            this.Controls.Add(this.LblAddEditPerson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOEditApplicationType";
            this.ShowIcon = false;
            this.Text = "Update Application Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FOEditApplicationType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddEditPerson;
        private System.Windows.Forms.Label LblFees;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.PictureBox PBFees;
        private System.Windows.Forms.PictureBox PBTitle;
        private System.Windows.Forms.TextBox TBTitle;
        private System.Windows.Forms.TextBox TBFees;
        private System.Windows.Forms.Label LblValueID;
        private System.Windows.Forms.Button BtnAddSave;
        private System.Windows.Forms.Button BtnAddClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}