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
            this.ctrDetailsPerson1 = new DVLD_PresentationLayer.CtrDetailsPerson();
            this.GBUserControlDetailesPersonWithFilter = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
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
            // GBUserControlDetailesPersonWithFilter
            // 
            this.GBUserControlDetailesPersonWithFilter.Location = new System.Drawing.Point(49, 48);
            this.GBUserControlDetailesPersonWithFilter.Name = "GBUserControlDetailesPersonWithFilter";
            this.GBUserControlDetailesPersonWithFilter.Size = new System.Drawing.Size(1010, 89);
            this.GBUserControlDetailesPersonWithFilter.TabIndex = 1;
            this.GBUserControlDetailesPersonWithFilter.TabStop = false;
            this.GBUserControlDetailesPersonWithFilter.Text = "groupBox1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private CtrDetailsPerson ctrDetailsPerson1;
        private System.Windows.Forms.GroupBox GBUserControlDetailesPersonWithFilter;
    }
}
