using DVLD_BusinessLayer;
using DVLDShared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class FOAddEditUserInfo : Form
    {
        public FOAddEditUserInfo()
        {
            InitializeComponent();
        }
        public string UserName
        {
            get => TBUserName.Text.Trim();
            set => TBUserName.Text = value;
        }
        public TextBox UserNameTextBox => TBUserName;
        public string Password
        {
            get => TBPassword.Text.Trim();
            set => TBPassword.Text = value;
        }
        public TextBox PasswordTextBox => TBPassword;
        public string PasswordConfirm
        {
            get => TBPasswordConfirm.Text.Trim();
            set => TBPasswordConfirm.Text = value;
        }
        public TextBox PasswordConfirmTextBox => TBPasswordConfirm;
        private void ValidateRequiredField(string value, TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }
        private void BtnAddNext_Click(object sender, EventArgs e)
        {
            if (ctrDetailsPersonWithFilter1.PersonData == null)
            {
                MessageBox.Show("Please enter the person data before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsUser.isUsersExistByPersonID(ctrDetailsPersonWithFilter1.PersonID))
            {
                MessageBox.Show("Selected Person Alredy has a User , choose another one.", "Selected another Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            TCAddEditUser.SelectedTab = TPLoginInfo;
        }

        private void TBPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.ValidateRequiredField(Password, PasswordConfirm))
            {
                e.Cancel = true;
                errorProvider1.SetError(PasswordConfirmTextBox, "Password Confrimation does not Match password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PasswordConfirmTextBox, "");
            }
        }

        private void TBPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(Password, PasswordTextBox, e);
        }

        private void TBUserName_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(UserName, UserNameTextBox, e);

        }
    }
}
