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
        public enum enMode { AddNew = 0 };
        private enMode _Mode;
        int _UserID;
        clsUser _User;
        public string ApplicationID
        {
            get => LblValueApplicationID.Text.Trim();
            set => LblValueApplicationID.Text = value;
        }
        public string ApplicationDate
        {
            get => LblValueApplicationDate.Text.Trim();
            set => LblValueApplicationDate.Text = value;
        }
        public string ApplicationFees
        {
            get => LblValueApplicationFees.Text.Trim();
            set => LblValueApplicationFees.Text = value;
        }
        public string Createdby
        {
            get => LblValueCreatedby.Text.Trim();
            set => LblValueCreatedby.Text = value;
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
        }
        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                LblAddEditApplication.Text = "Add New User";
                this.Text = "Add New User";
                TPApplicationInfo.Enabled = false;
                _User = new clsUser();
                return;
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
   
        private void BtnAddNext_Click(object sender, EventArgs e)
        {
            if (ctrDetailsPersonWithFilter1.PersonData == null)
            {
                MessageBox.Show("Please enter the person data before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (clsUser.isUsersExistByPersonID(ctrDetailsPersonWithFilter1.PersonID))
            //{
            //    MessageBox.Show("Selected Person Alredy has a User , choose another one.", "Selected another Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    return;
            //}
            TPApplicationInfo.Enabled = true;
            TCAddEditApplication.SelectedTab = TPApplicationInfo;
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
