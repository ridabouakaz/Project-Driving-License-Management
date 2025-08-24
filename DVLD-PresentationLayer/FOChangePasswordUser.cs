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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_PresentationLayer
{
    public partial class FOChangePasswordUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _UserID;
        clsUser _User;
        clsPerson _Person;
        public string CurrentPassword
        {
            get => TBCurrentPassword.Text.Trim();
            set => TBCurrentPassword.Text = value;
        }
        public TextBox CurrentPasswordTextBox => TBCurrentPassword;
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
        public FOChangePasswordUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _LoadData();
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            _Person = clsPerson.Find(_User.PersonID);
            if (_UserID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _UserID);
                this.Close();

                return;
            }
            ctrDetailsUser1.Personinformation = _Person;
            ctrDetailsUser1.UserData = _User;
        }
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
        private void TBCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (CurrentPassword!= _User.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(CurrentPasswordTextBox, "Please enter a password correct");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(CurrentPasswordTextBox, "");
            }
        }
        private void TBPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(Password, PasswordTextBox, e);
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("❌ Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _User.Password = Password.Trim();
            if (_User.Save())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
