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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_PresentationLayer
{
    public partial class FONewLocalDrivingApplication : Form
    {
        public enum enMode { AddNew = 0 };
        private enMode _Mode;
        clsUser _User;
        clsApplications _Application;
        clsNewLocalDrivingApplication _NewLocalDrivingApplication;
        public string LocalDrivingApplicationID
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
        public FONewLocalDrivingApplication(clsUser User)
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            _User = User;
        }
        private void _ResetDefaults()
        {
            if (_Mode == enMode.AddNew)
            {
                LblHeaderTitle.Text = "New Local Driving Application";
                this.Text = "New Local Driving Application";
                TPApplicationInfo.Enabled = false;
                CBLicenseClassBy.SelectedIndex = 0;
                _Application = new clsApplications();
                _NewLocalDrivingApplication = new clsNewLocalDrivingApplication();
            }

        }
        private void _PrepareNewApplication()
        {
            _Application.LastStatusDate = DateTime.Now;
            _Application.ApplicationDate = DateTime.Now;
            _Application.PaidFees = clsManageApplicationTypes.GetFeesById(_Application.ApplicationTypeID);
            _Application.ApplicationStatus = enApplicationStatus.New;
            _Application.ApplicationTypeID = 1; // Local Driving
            _Application.CreatedByUserID = _User.ID;
            _Application.ApplicantPersonID = ctrDetailsPersonWithFilter1.PersonData?.ID ?? -1;
        }
        private void _LoadApplicationInfo()
        {
            ApplicationDate = _Application.ApplicationDate.ToShortDateString();
            ApplicationFees = clsManageApplicationTypes.GetFeesById(_Application.ApplicationTypeID).ToString();
            Createdby = _User.UserName;
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
            _PrepareNewApplication();
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
            _NewLocalDrivingApplication.ApplicationID = _Application.ID;
            _NewLocalDrivingApplication.LicenseClassID = CBLicenseClassBy.SelectedIndex + 1;
            if (clsNewLocalDrivingApplication.DoesApplicationExistForPerson(
            _Application.ApplicantPersonID,
            _NewLocalDrivingApplication.LicenseClassID))
            {
                MessageBox.Show(
                    "This person already has an application for the selected license class. Please choose another.",
                    "Duplicate Application",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            if (_NewLocalDrivingApplication.Save())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LocalDrivingApplicationID= _NewLocalDrivingApplication.ID.ToString();
        }
        private void FONewLocalDrivingApplication_Load(object sender, EventArgs e)
        {
            _InitializeForm();
        }
        private void _InitializeForm()
        {
  
            _ResetDefaults();
            _PrepareNewApplication();
            _LoadApplicationInfo();
        }
    }
}
  
