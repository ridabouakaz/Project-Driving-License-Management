using System.Drawing;

namespace DVLD_PresentationLayer
{
    partial class FOAddEditPersonInfo
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
            this.ctrDetailsPerson_Edit_Add_1 = new DVLD_PresentationLayer.CtrDetailsPerson_Edit_Add_();
            this.SuspendLayout();
            // 
            // ctrDetailsPerson_Edit_Add_1
            // 
            this.ctrDetailsPerson_Edit_Add_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ctrDetailsPerson_Edit_Add_1.Location = new System.Drawing.Point(31, 120);
            this.ctrDetailsPerson_Edit_Add_1.Name = "ctrDetailsPerson_Edit_Add_1";
            this.ctrDetailsPerson_Edit_Add_1.Size = new System.Drawing.Size(1097, 451);
            this.ctrDetailsPerson_Edit_Add_1.TabIndex = 0;
            // 
            // FOAddEditPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1160, 594);
            this.Controls.Add(this.ctrDetailsPerson_Edit_Add_1);
            this.Name = "FOAddEditPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info";
            this.ResumeLayout(false);

        }

        #endregion

        private CtrDetailsPerson_Edit_Add_ ctrDetailsPerson_Edit_Add_1;
    }
}