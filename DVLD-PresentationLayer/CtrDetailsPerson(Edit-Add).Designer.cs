using System.Drawing;

namespace DVLD_PresentationLayer
{
    partial class CtrDetailsPerson_Edit_Add_
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblNationalNo = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblName.Location = new System.Drawing.Point(28, 65);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(62, 23);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name:";
            // 
            // LblNationalNo
            // 
            this.LblNationalNo.AutoSize = true;
            this.LblNationalNo.BackColor = System.Drawing.Color.Transparent;
            this.LblNationalNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblNationalNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblNationalNo.Location = new System.Drawing.Point(28, 113);
            this.LblNationalNo.Name = "LblNationalNo";
            this.LblNationalNo.Size = new System.Drawing.Size(111, 23);
            this.LblNationalNo.TabIndex = 1;
            this.LblNationalNo.Text = "National No:";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.BackColor = System.Drawing.Color.Transparent;
            this.LblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblGender.Location = new System.Drawing.Point(28, 158);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(74, 23);
            this.LblGender.TabIndex = 2;
            this.LblGender.Text = "Gender:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.Transparent;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblEmail.Location = new System.Drawing.Point(28, 201);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(59, 23);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.BackColor = System.Drawing.Color.Transparent;
            this.LblAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblAddress.Location = new System.Drawing.Point(28, 242);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(79, 23);
            this.LblAddress.TabIndex = 4;
            this.LblAddress.Text = "Address:";
            // 
            // CtrDetailsPerson_Edit_Add_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LblAddress);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblNationalNo);
            this.Controls.Add(this.LblName);
            this.Name = "CtrDetailsPerson_Edit_Add_";
            this.Size = new System.Drawing.Size(759, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNationalNo;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblAddress;
    }
}
