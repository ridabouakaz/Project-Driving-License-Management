using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static DVLD_BusinessLayer.PersonFilterService;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsApplicationWithLocalDrivingInfo : UserControl
    {

        private clsNewLocalDrivingApplication _LocalDrivingApplication;
        private int _ApplicationID;
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
            DLAppID= _LocalDrivingApplication.LocalDrivingLicenseApplicationID.ToString();
            AppliedForLicense = clsManageApplicationTypes.GetTitleById(_LocalDrivingApplication.ApplicationTypeID);
            PassedTests=_LocalDrivingApplication.GetPassedTestCount().ToString() + "/3";
        }
        public CtrDetailsApplicationWithLocalDrivingInfo(int ApplicationID)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID;
            _LocalDrivingApplication= clsNewLocalDrivingApplication.FindByLocalDrivingAppLicenseID(_ApplicationID);
        }

    }
}
