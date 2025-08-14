namespace DVLD_PresentationLayer
{
    partial class CtrDetailsPersonWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrDetailsPersonWithFilter));
            this.GBUserControlDetailesPersonWithFilter = new System.Windows.Forms.GroupBox();
            this.BtnAddPerson = new System.Windows.Forms.Button();
            this.BtnSearchPerson = new System.Windows.Forms.Button();
            this.MTBsearch = new System.Windows.Forms.MaskedTextBox();
            this.CBFindBy = new System.Windows.Forms.ComboBox();
            this.LblFindBy = new System.Windows.Forms.Label();
            this.ctrDetailsPerson1 = new DVLD_PresentationLayer.CtrDetailsPerson();
            this.GBUserControlDetailesPersonWithFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBUserControlDetailesPersonWithFilter
            // 
            this.GBUserControlDetailesPersonWithFilter.BackColor = System.Drawing.SystemColors.Window;
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.BtnAddPerson);
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.BtnSearchPerson);
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.MTBsearch);
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.CBFindBy);
            this.GBUserControlDetailesPersonWithFilter.Controls.Add(this.LblFindBy);
            this.GBUserControlDetailesPersonWithFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.GBUserControlDetailesPersonWithFilter.Location = new System.Drawing.Point(49, 48);
            this.GBUserControlDetailesPersonWithFilter.Name = "GBUserControlDetailesPersonWithFilter";
            this.GBUserControlDetailesPersonWithFilter.Size = new System.Drawing.Size(1010, 89);
            this.GBUserControlDetailesPersonWithFilter.TabIndex = 1;
            this.GBUserControlDetailesPersonWithFilter.TabStop = false;
            this.GBUserControlDetailesPersonWithFilter.Text = "Filter";
            // 
            // BtnAddPerson
            // 
            this.BtnAddPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddPerson.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnAddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAddPerson.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddPerson.Image")));
            this.BtnAddPerson.Location = new System.Drawing.Point(751, 40);
            this.BtnAddPerson.Name = "BtnAddPerson";
            this.BtnAddPerson.Size = new System.Drawing.Size(56, 32);
            this.BtnAddPerson.TabIndex = 4;
            this.BtnAddPerson.UseVisualStyleBackColor = false;
            this.BtnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // BtnSearchPerson
            // 
            this.BtnSearchPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSearchPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearchPerson.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSearchPerson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSearchPerson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSearchPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSearchPerson.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchPerson.Image")));
            this.BtnSearchPerson.Location = new System.Drawing.Point(664, 40);
            this.BtnSearchPerson.Name = "BtnSearchPerson";
            this.BtnSearchPerson.Size = new System.Drawing.Size(56, 32);
            this.BtnSearchPerson.TabIndex = 3;
            this.BtnSearchPerson.UseVisualStyleBackColor = false;
            this.BtnSearchPerson.Click += new System.EventHandler(this.BtnSearchPerson_Click);
            // 
            // MTBsearch
            // 
            this.MTBsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.MTBsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBsearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MTBsearch.ForeColor = System.Drawing.Color.Black;
            this.MTBsearch.Location = new System.Drawing.Point(413, 42);
            this.MTBsearch.Name = "MTBsearch";
            this.MTBsearch.Size = new System.Drawing.Size(213, 30);
            this.MTBsearch.TabIndex = 2;
            // 
            // CBFindBy
            // 
            this.CBFindBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CBFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFindBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBFindBy.ForeColor = System.Drawing.Color.Black;
            this.CBFindBy.FormattingEnabled = true;
            this.CBFindBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No"});
            this.CBFindBy.Location = new System.Drawing.Point(126, 42);
            this.CBFindBy.Name = "CBFindBy";
            this.CBFindBy.Size = new System.Drawing.Size(262, 31);
            this.CBFindBy.TabIndex = 2;
            this.CBFindBy.SelectedIndexChanged += new System.EventHandler(this.CBFindBy_SelectedIndexChanged);
            this.CBFindBy.TextChanged += new System.EventHandler(this.CBFindBy_TextChanged);
            // 
            // LblFindBy
            // 
            this.LblFindBy.AutoSize = true;
            this.LblFindBy.BackColor = System.Drawing.Color.Transparent;
            this.LblFindBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblFindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblFindBy.Location = new System.Drawing.Point(33, 40);
            this.LblFindBy.Name = "LblFindBy";
            this.LblFindBy.Size = new System.Drawing.Size(87, 28);
            this.LblFindBy.TabIndex = 37;
            this.LblFindBy.Text = "Find By:";
            // 
            // ctrDetailsPerson1
            // 
            this.ctrDetailsPerson1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsPerson1.ImagePath = null;
            this.ctrDetailsPerson1.Location = new System.Drawing.Point(38, 137);
            this.ctrDetailsPerson1.Name = "ctrDetailsPerson1";
            this.ctrDetailsPerson1.PersonData = null;
            this.ctrDetailsPerson1.Size = new System.Drawing.Size(1032, 383);
            this.ctrDetailsPerson1.TabIndex = 0;
            // 
            // CtrDetailsPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GBUserControlDetailesPersonWithFilter);
            this.Controls.Add(this.ctrDetailsPerson1);
            this.Name = "CtrDetailsPersonWithFilter";
            this.Size = new System.Drawing.Size(1101, 542);
            this.Load += new System.EventHandler(this.CtrDetailsPersonWithFilter_Load);
            this.GBUserControlDetailesPersonWithFilter.ResumeLayout(false);
            this.GBUserControlDetailesPersonWithFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBUserControlDetailesPersonWithFilter;
        private CtrDetailsPerson ctrDetailsPerson1;
        private System.Windows.Forms.Label LblFindBy;
        private System.Windows.Forms.ComboBox CBFindBy;
        private System.Windows.Forms.MaskedTextBox MTBsearch;
        private System.Windows.Forms.Button BtnSearchPerson;
        private System.Windows.Forms.Button BtnAddPerson;
    }
}
