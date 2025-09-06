namespace DVLD_PresentationLayer
{
    partial class ForTest
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
            this.ctrDetailsApplication1 = new DVLD_PresentationLayer.CtrDetailsApplication();
            this.SuspendLayout();
            // 
            // ctrDetailsApplication1
            // 
            this.ctrDetailsApplication1.ApplicationData = null;
            this.ctrDetailsApplication1.BackColor = System.Drawing.Color.White;
            this.ctrDetailsApplication1.Location = new System.Drawing.Point(2, 60);
            this.ctrDetailsApplication1.Name = "ctrDetailsApplication1";
            this.ctrDetailsApplication1.Size = new System.Drawing.Size(1165, 383);
            this.ctrDetailsApplication1.TabIndex = 0;
            // 
            // ForTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 561);
            this.Controls.Add(this.ctrDetailsApplication1);
            this.Name = "ForTest";
            this.Text = "ForTest";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrDetailsApplication ctrDetailsApplication1;
    }
}