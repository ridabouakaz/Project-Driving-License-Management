using DVLD_BusinessLayer;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsManageTestTypes;

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOScheduleTest : Form
    {
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private clsNewLocalDrivingApplication _LocalDrivingApplication;
        private int _LocalDrivingLicenseApplicationID;
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
            get => DTPDate.Value.ToString("yyyy-MM-dd");
            set => DTPDate.Value = DateTime.Parse(value);
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
            DClass = clsNewLocalDrivingApplication.GetClassNameById(_LocalDrivingApplication.ApplicationTypeID);
            NamePerson = _LocalDrivingApplication.ApplicantFullName;
            FeesTest=clsManageTestTypes.GetFeesById((int)_TestType).ToString();
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

        
    }
}
