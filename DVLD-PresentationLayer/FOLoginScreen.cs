using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static DVLDShared.DVLDShared;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class FOLoginScreen : Form
    {
        private static clsUser _User = null;
        private string path = @"E:\DVLD\Shared\RememberMe.txt";
      
        public FOLoginScreen()
        {
            InitializeComponent();
        }
        public string Username
        {
            get => signup_username.Text;
            set => signup_username.Text = value;
        }
        public string Password
        {
            get => signup_password.Text;
            set => signup_password.Text = value;
        }
        public bool RememberMe
        {
            get => (RBRememberMe.Checked? true: false);
            set
            {
                RBRememberMe.Checked =(value== true);
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _User = clsUser.Find(Username, Password);
            if (_User != null)
            {
                if (_User.isActive != ActiveStatus.No)
                {
                
                    clsUtil.SaveLoginInfo( Username,  Password, RBRememberMe.Checked);
                    this.Hide();
                    using (FOmain frm = new FOmain(_User))
                    {
                        frm.ShowDialog(); 
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
               "This user account is not active.",
               "Inactive Account",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning
           );
                    return;
                }
            }
            else
            {
                MessageBox.Show(
             "Invalid username or password. Please try again.",
             "Login Failed",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error
         );
            }
        }
        private void FOLoginScreen_Load(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length >= 3 && lines[2] == "true")
                {
                    Username = clsUtil.Decrypt(lines[0]);
                    Password = clsUtil.Decrypt(lines[1]);
                    RBRememberMe.Checked = true;
                }
            }
        }
    }
}
