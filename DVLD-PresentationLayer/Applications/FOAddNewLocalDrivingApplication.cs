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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_PresentationLayer
{
    public partial class FONewLocalDrivingApplication : Form
    {
        public enum enMode { AddNew = 0 };
        private enMode _Mode;
        int _UserID;
        clsApplications _Application;
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
     
        public FONewLocalDrivingApplication(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _UserID = UserID;
        }
        private void _ResetDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                LblAddEditApplication.Text = "New Local Driving Application";
                this.Text = "New Local Driving Application";
                TPApplicationInfo.Enabled = false;
                _Application = new clsApplications();
                return;
            }

        }
        private void _AddingDataAppliction()
        {
            _Application.LastStatusDate = DateTime.Now;
            _Application.ApplicationDate = DateTime.Now;
            _Application.ApplicationStatus = clsApplications.enApplicationStatus.New;
            _Application.ApplicationTypeID = 1; // Local Driving
            _Application.CreatedByUserID = _UserID;
            if (ctrDetailsPersonWithFilter1.PersonData != null)
                _Application.ApplicantPersonID = ctrDetailsPersonWithFilter1.PersonID;
            else
                _Application.ApplicantPersonID = -1;  
        }
        private void _LoadData()
        {
            LblValueUserID.Text = _User.ID.ToString();
            ApplicationDate = _Application.ApplicationDate.ToString();
            ApplicationFees = _Application.Password;
            Createdby = _User.Password;
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
                MessageBox.Show("Selected Person is User , choose another one.", "Selected another Person", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            _AddingDataAppliction();
            if (!_Application.Save())
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            _LoadData();
        }
    }
}
