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

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOTakeTest : Form
    {
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private clsNewLocalDrivingApplication _LocalDrivingApplication;
        private int _LocalDrivingLicenseApplicationID;
        private clsTestAppointment _Appointment;
        private clsApplications _RetakeTest;
        private bool _HasPersonAlreadyFailedTest;
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
        public string TestID
        {
            get => LblValueTestID.Text.Trim();
            set => LblValueTestID.Text = value;
        }
        public FOTakeTest(clsManageTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _TestType = TestType;
            _LoadTestTypeImageAndTitle();
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
