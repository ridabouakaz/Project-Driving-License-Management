using System.Drawing;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    partial class FOmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SMItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SMItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMItem1,
            this.SMItem2,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.acToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.menuStrip1.Size = new System.Drawing.Size(1448, 108);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SMItem1
            // 
            this.SMItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiToolStripMenuItem,
            this.sadsaToolStripMenuItem});
            this.SMItem1.Image = ((System.Drawing.Image)(resources.GetObject("SMItem1.Image")));
            this.SMItem1.Name = "SMItem1";
            this.SMItem1.Size = new System.Drawing.Size(217, 68);
            this.SMItem1.Text = "Application";
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.hiToolStripMenuItem.Text = "aplliction";
            // 
            // sadsaToolStripMenuItem
            // 
            this.sadsaToolStripMenuItem.Name = "sadsaToolStripMenuItem";
            this.sadsaToolStripMenuItem.Size = new System.Drawing.Size(202, 30);
            this.sadsaToolStripMenuItem.Text = "Lincese";
            // 
            // SMItem2
            // 
            this.SMItem2.Image = ((System.Drawing.Image)(resources.GetObject("SMItem2.Image")));
            this.SMItem2.Name = "SMItem2";
            this.SMItem2.Size = new System.Drawing.Size(165, 68);
            this.SMItem2.Text = "people";
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversToolStripMenuItem.Image")));
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(172, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(153, 68);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acToolStripMenuItem.Image")));
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(280, 68);
            this.acToolStripMenuItem.Text = "Account Settings";
            // 
            // FOmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 499);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FOmain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FOmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SMItem1;
        private System.Windows.Forms.ToolStripMenuItem SMItem2;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem acToolStripMenuItem;
        private ToolStripMenuItem sadsaToolStripMenuItem;
    }
}

