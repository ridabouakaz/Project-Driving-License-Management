using DVLD_BusinessLayer;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsManageTestTypes;
using static DVLDShared.DVLDShared;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOScheduleTest : Form
    {
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private clsNewLocalDrivingApplication _LocalDrivingApplication;
        private int _LocalDrivingLicenseApplicationID;
        //private clsTestAppointment _Appointment;
        private clsTestAppointment _Appointment = new clsTestAppointment();
        private clsApplications _RetakeTest;
        private bool _HasPersonAlreadyFailedTest;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode; 
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
        public DateTime DateOFAppointment
        {
            get => DTPDate.Value;
            set => DTPDate.Value = value;
        }
        public string FeesTest
        {
            get => LblvalueFees.Text.Trim();
            set => LblvalueFees.Text = value;
        }
        private void _defaultAppointmentDate()
        {
            DTPDate.MinDate = DateTime.Today;
            DTPDate.Value = DateTime.Today;
            DTPDate.MaxDate = DateTime.Today.AddMonths(6);
        }
       void  _LoadLocalDrivingApplicationInfo()
        {
            _LocalDrivingApplication = clsNewLocalDrivingApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
            LocalDrivingApplicationID = _LocalDrivingApplication.ApplicationID.ToString();
            DClass = clsNewLocalDrivingApplication.GetClassNameById(_LocalDrivingApplication.LocalDrivingLicenseApplicationID);
            NamePerson = _LocalDrivingApplication.ApplicantFullName;
            FeesTest = clsManageTestTypes.GetFeesById((int)_TestType).ToString();
            _HasPersonAlreadyFailedTest = clsTest.HasPersonAlreadyFailedTest((int)_TestType, _LocalDrivingLicenseApplicationID);
            GBRetakeTestInfo.Enabled = _HasPersonAlreadyFailedTest;
            if (_HasPersonAlreadyFailedTest)
            {
                LblScheduleTest.Text = "Schedule Retake Test";
                _RetakeTest = _LocalDrivingApplication;
                _RetakeTest.ApplicationTypeID = 7;
                _RetakeTest.PaidFees = clsManageApplicationTypes.GetFeesById(_RetakeTest.ApplicationTypeID);
                _RetakeTest.Save();
            }
        }
        public FOScheduleTest(clsManageTestTypes.enTestType TestType, int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _defaultAppointmentDate();
            _TestType = TestType;
            _LoadTestTypeImageAndTitle();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LoadLocalDrivingApplicationInfo();

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

            _Appointment.TestTypeID = (int)_TestType;
            _Appointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _Appointment.AppointmentDate = DateOFAppointment;
            _Appointment.PaidFees = clsManageTestTypes.GetFeesById((int)_TestType);
            _Appointment.CreatedByUserID = _LocalDrivingApplication.CreatedByUserID;
            _Appointment.IsLocked = IsLocked.No;
            if (_HasPersonAlreadyFailedTest)
                _Appointment.RetakeTestApplicationID = _RetakeTest.ApplicationID;
            else
                _Appointment.RetakeTestApplicationID = null;
            if (_Appointment.Save())
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
