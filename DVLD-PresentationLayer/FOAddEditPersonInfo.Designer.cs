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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOAddEditPersonInfo));
            this.LblAddEditPerson = new System.Windows.Forms.Label();
            this.LblPersonID = new System.Windows.Forms.Label();
            this.PBPersonID = new System.Windows.Forms.PictureBox();
            this.LbNumberlPersonID = new System.Windows.Forms.Label();
            this.ctrDetailsPerson_Edit_Add_1 = new DVLD_PresentationLayer.CtrDetailsPerson_Edit_Add_();
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonID)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAddEditPerson
            // 
            this.LblAddEditPerson.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblAddEditPerson.AutoSize = true;
            this.LblAddEditPerson.BackColor = System.Drawing.Color.Transparent;
            this.LblAddEditPerson.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.LblAddEditPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.LblAddEditPerson.Location = new System.Drawing.Point(416, 9);
            this.LblAddEditPerson.Name = "LblAddEditPerson";
            this.LblAddEditPerson.Size = new System.Drawing.Size(337, 54);
            this.LblAddEditPerson.TabIndex = 2;
            this.LblAddEditPerson.Text = "Add New Person";
            // 
            // LblPersonID
            // 
            this.LblPersonID.AutoSize = true;
            this.LblPersonID.BackColor = System.Drawing.Color.Transparent;
            this.LblPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblPersonID.Location = new System.Drawing.Point(26, 79);
            this.LblPersonID.Name = "LblPersonID";
            this.LblPersonID.Size = new System.Drawing.Size(107, 28);
            this.LblPersonID.TabIndex = 3;
            this.LblPersonID.Text = "Person ID:";
            // 
            // PBPersonID
            // 
            this.PBPersonID.Image = ((System.Drawing.Image)(resources.GetObject("PBPersonID.Image")));
            this.PBPersonID.Location = new System.Drawing.Point(187, 75);
            this.PBPersonID.Name = "PBPersonID";
            this.PBPersonID.Size = new System.Drawing.Size(32, 32);
            this.PBPersonID.TabIndex = 11;
            this.PBPersonID.TabStop = false;
            // 
            // LbNumberlPersonID
            // 
            this.LbNumberlPersonID.AutoSize = true;
            this.LbNumberlPersonID.BackColor = System.Drawing.Color.Transparent;
            this.LbNumberlPersonID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LbNumberlPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LbNumberlPersonID.Location = new System.Drawing.Point(250, 79);
            this.LbNumberlPersonID.Name = "LbNumberlPersonID";
            this.LbNumberlPersonID.Size = new System.Drawing.Size(51, 28);
            this.LbNumberlPersonID.TabIndex = 12;
            this.LbNumberlPersonID.Text = "N/A";
            // 
            // ctrDetailsPerson_Edit_Add_1
            // 
            this.ctrDetailsPerson_Edit_Add_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ctrDetailsPerson_Edit_Add_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Controls.Add(this.LbNumberlPersonID);
            this.Controls.Add(this.PBPersonID);
            this.Controls.Add(this.LblPersonID);
            this.Controls.Add(this.LblAddEditPerson);
            this.Controls.Add(this.ctrDetailsPerson_Edit_Add_1);
            this.Name = "FOAddEditPersonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info";
            ((System.ComponentModel.ISupportInitialize)(this.PBPersonID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CtrDetailsPerson_Edit_Add_ ctrDetailsPerson_Edit_Add_1;
        private System.Windows.Forms.Label LblAddEditPerson;
        private System.Windows.Forms.Label LblPersonID;
        private System.Windows.Forms.PictureBox PBPersonID;
        private System.Windows.Forms.Label LbNumberlPersonID;
    }
}