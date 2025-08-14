namespace DVLD_PresentationLayer
{
    partial class FOPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOPersonInfo));
            this.LblPersonInfo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAddSave = new System.Windows.Forms.Button();
            this.ctrDetailsPerson1 = new DVLD_PresentationLayer.CtrDetailsPerson();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPersonInfo
            // 
            this.LblPersonInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblPersonInfo.AutoSize = true;
            this.LblPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.LblPersonInfo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.LblPersonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblPersonInfo.Location = new System.Drawing.Point(456, 9);
            this.LblPersonInfo.Name = "LblPersonInfo";
            this.LblPersonInfo.Size = new System.Drawing.Size(269, 50);
            this.LblPersonInfo.TabIndex = 2;
            this.LblPersonInfo.Text = "Person Details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnAddSave
            // 
            this.BtnAddSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.BtnAddSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnAddSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddSave.Image")));
            this.BtnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddSave.Location = new System.Drawing.Point(923, 452);
            this.BtnAddSave.Name = "BtnAddSave";
            this.BtnAddSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnAddSave.Size = new System.Drawing.Size(130, 48);
            this.BtnAddSave.TabIndex = 36;
            this.BtnAddSave.Text = "Save";
            this.BtnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddSave.UseVisualStyleBackColor = false;
            this.BtnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
            // 
            // ctrDetailsPerson1
            // 
            this.ctrDetailsPerson1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ctrDetailsPerson1.ImagePath = null;
            this.ctrDetailsPerson1.Location = new System.Drawing.Point(31, 68);
            this.ctrDetailsPerson1.Name = "ctrDetailsPerson1";
            this.ctrDetailsPerson1.PersonData = null;
            this.ctrDetailsPerson1.Size = new System.Drawing.Size(1101, 421);
            this.ctrDetailsPerson1.TabIndex = 13;
            // 
            // FOPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1160, 544);
            this.Controls.Add(this.BtnAddSave);
            this.Controls.Add(this.ctrDetailsPerson1);
            this.Controls.Add(this.LblPersonInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FOPersonInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Detailes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPersonInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CtrDetailsPerson ctrDetailsPerson1;
        private System.Windows.Forms.Button BtnAddSave;
    }
}