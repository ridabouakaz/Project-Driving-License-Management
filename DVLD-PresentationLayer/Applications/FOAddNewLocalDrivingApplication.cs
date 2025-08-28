using DVLD_BusinessLayer;
using DVLDShared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class FONewLocalDrivingApplication : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _UserID;
        clsUser _User;
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
        public ActiveStatus IsActive
        {
            get => CBIsActive.Checked ? ActiveStatus.Yes : ActiveStatus.No;
            set
            {
                              CBIsActive.Checked = (value == ActiveStatus.Yes);
            }
        }
        public FONewLocalDrivingApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FONewLocalDrivingApplication(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }
        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                LblAddEditUser.Text = "Add New User";
                this.Text = "Add New User";
                TPApplicationInfo.Enabled = false;
                _User = new clsUser();
                return;
            }
            else
            {
                LblAddEditUser.Text = "Update User";
                this.Text = "Update User";
                TPApplicationInfo.Enabled = true;
                BtnAddSave.Enabled = true;
                ctrDetailsPersonWithFilter1.DisablePersonDetails();
                BtnAddNext.Visible = false;
            }
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _UserID);
                this.Close();
                return;
            }
            LblValueUserID.Text = _User.ID.ToString();
            UserName = _User.UserName;
            Password= _User.Password;
            PasswordConfirm = _User.Password;
            IsActive = _User.isActive;
            ctrDetailsPersonWithFilter1.PersonData = clsPerson.Find(_User.PersonID);
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
            TPApplicationInfo.Enabled = true;
            TCAddEditUser.SelectedTab = TPApplicationInfo;
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
            _User.UserName = UserName.Trim();
            _User.Password = Password.Trim();
            _User.isActive= IsActive;
            _User.PersonID = ctrDetailsPersonWithFilter1.PersonID;
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
        private void FOAddEditUserInfo_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
    }
}
