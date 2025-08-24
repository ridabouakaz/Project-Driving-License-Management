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

namespace DVLD_PresentationLayer
{
    public partial class FOLoginScreen : Form
    {
        private static clsUser _User = null;
        private string path = @"E:\DVLD\Shared\RememberMe.txt";
        private string Encrypt(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encrypted);
        }
        private string Decrypt(string cipher)
        {
            try
            {
                byte[] data = Convert.FromBase64String(cipher);
                byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(decrypted);
            }
            catch
            {
                return "";
            }
        }
        private void SaveLoginInfo(string username, string password, bool rememberMe)
        {
             string path = @"E:\DVLD\Shared\RememberMe.txt";
       

            if (rememberMe)
            {
                string[] lines =
                {
            Encrypt(username),
            Encrypt(password),
            "true"
        };
                File.WriteAllLines(path, lines);
            }
            else
            {
                if (File.Exists(path))
                    File.Delete(path); // امسح الملف لو المستخدم ما حبش يتذكر
            }
        }
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
                
                    SaveLoginInfo( Username,  Password, RBRememberMe.Checked);
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
                    Username = Decrypt(lines[0]);
                    Password = Decrypt(lines[1]);
                    RBRememberMe.Checked = true;
                }
            }
        }
    }
}
