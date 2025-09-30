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

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOTakeTest : Form
    {
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private clsNewLocalDrivingApplication _LocalDrivingApplication;
        private clsTestAppointment _Appointment;
        private int _LocalDrivingLicenseApplicationID;
        private int _TestAppointmentID;
        private clsTest _Test = new clsTest();

        public string LocalDrivingApplicationID
        {
            get => LblValueDLAppID.Text.Trim();
            set => LblValueDLAppID.Text = value;
        }
        public string DClass
        {
            get => LblValueDClass.Text.Trim();
            set => LblValueDClass.Text = value;
        }
        public string NamePerson
        {
            get => LblValueName.Text.Trim();
            set => LblValueName.Text = value;
        }
        public string DateOFAppointment
        {
            get => LblValueDate.Text.Trim();
            set => LblValueDate.Text = value;
        }
        public string FeesTest
        {
            get => LblvalueFees.Text.Trim();
            set => LblvalueFees.Text = value;
        }
        public string TestID
        {
            get => LblValueTestID.Text.Trim();
            set => LblValueTestID.Text = value;
        }
        public string Notes
        {
            get => TBNotes.Text.Trim();
            set => TBNotes.Text = value;
        }
        public Result ResultTest
        {
            get => RBPass.Checked ? Result.Pass : Result.Fail;
            set
            {
                if (value == Result.Pass)
                    RBPass.Checked = true;
                else
                    RBFail.Checked = true;
            }
        }
        void _LoadLocalDrivingApplicationInfo()
        {
            
            _LocalDrivingApplication = clsNewLocalDrivingApplication.FindByLocalDrivingAppLicenseID(_Appointment.LocalDrivingLicenseApplicationID);
            LocalDrivingApplicationID = _LocalDrivingApplication.ApplicationID.ToString();
            DClass = clsNewLocalDrivingApplication.GetClassNameById(_LocalDrivingApplication.LocalDrivingLicenseApplicationID);
            NamePerson = _LocalDrivingApplication.ApplicantFullName;
            FeesTest = clsManageTestTypes.GetFeesById((int)_TestType).ToString();
            DateOFAppointment = _Appointment.AppointmentDate.ToString("yyyy-MM-dd");
            TestID = _Test.TestID.ToString();
        }
        public FOTakeTest(clsManageTestTypes.enTestType TestType, int TestAppointmentID)
        {
            InitializeComponent();
            _TestType = TestType;
            _TestAppointmentID = TestAppointmentID;
            _LoadTestTypeImageAndTitle();
            _LoadTestTAppointment();
            _LoadLocalDrivingApplicationInfo();
        }
        private void _LoadTestTAppointment()
        {
            _Appointment= clsTestAppointment.Find(_TestAppointmentID);
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {
                case clsManageTestTypes.enTestType.VisionTest:
                    {
                        GBUserControlDetailesApplication.Text = "Vision Test";
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.eyetest;
                        break;
                    }
                case clsManageTestTypes.enTestType.WrittenTest:
                    {
                        GBUserControlDetailesApplication.Text = "Written Test";
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.test;
                        break;
                    }
                case clsManageTestTypes.enTestType.StreetTest:
                    {
                        GBUserControlDetailesApplication.Text = "Street Test";
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.StreetTest;
                        break;
                    }
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            _Test.TestResult = ResultTest;
            _Test.Notes = Notes;
            _Test.CreatedByUserID = _Appointment.CreatedByUserID;
            _Test.TestAppointmentID= _Appointment.TestAppointmentID;
            _Appointment.IsLocked = IsLocked.Yes;
            if (_Test.Save() && _Appointment.LockedAppointment())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TestID = _Test.TestID.ToString();
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
