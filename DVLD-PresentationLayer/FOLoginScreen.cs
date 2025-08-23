using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class FOLoginScreen : Form
    {
        private static clsUser _User =null;

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
        public byte RememberMe
        {
            get => (byte)(RBRememberMe.Checked? 1: 0);
            set
            {
                RBRememberMe.Checked =(value==1);
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
    }
}
