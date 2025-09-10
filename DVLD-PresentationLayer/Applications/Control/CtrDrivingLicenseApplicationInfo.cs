using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsApplications;
using DVLD_BusinessLayer;

namespace DVLD_PresentationLayer
{
    public partial class CtrDrivingLicenseApplicationInfo : UserControl
    {


        private clsNewLocalDrivingApplication _LocalDrivingApplication;
        private int _ApplicationID;
        private int _LocalDrivingLicenseApplicationID;
        public CtrDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadApplication(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LocalDrivingApplication = clsNewLocalDrivingApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingApplication != null)
                _LoadData();
            else
                MessageBox.Show($"❌ Application with ID {_ApplicationID} not found.");
        }
        public void LoadApplicationBYApplicationID(int applicationId)
        {
            _ApplicationID = applicationId;
            _LocalDrivingApplication = clsNewLocalDrivingApplication.FindByApplicationID(_ApplicationID);

            if (_LocalDrivingApplication != null)
                _LoadData();
            else
                MessageBox.Show($"❌ Application with ID {_ApplicationID} not found.");
        }
        public string DLAppID
        {
            set => LblValueDLAppID.Text = value;
        }
        public string PassedTests
        {
            set => LblValuePassedTests.Text = value;
        }
        public string AppliedForLicense
        {
            set => LblValueAppliedForLicense.Text = value;
        }
        private void _LoadData()
        {
            ctrDetailsApplication1.ApplicationData = _LocalDrivingApplication;
            DLAppID = _LocalDrivingApplication.LocalDrivingLicenseApplicationID.ToString();
            AppliedForLicense = clsManageApplicationTypes.GetTitleById(_LocalDrivingApplication.ApplicationTypeID);
            PassedTests = _LocalDrivingApplication.GetPassedTestCount().ToString() + "/3";
        }
    }
}
