using DVLD_BusinessLayer;
using Syncfusion.PdfViewer.Base;
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
    public partial class FOIssueDriverLicenseFirstTime : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsNewLocalDrivingApplication _LocalDrivingLicense;
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private void _RefreshTestAppointmentsList()
        {
          
            _dtLicenseTestAppointments = clsTestAppointment.GetAllAppointments(_LocalDrivingLicenseApplicationID,(int)_TestType);
        }
        void _LoadLocalDrivingApplicationInfo()
        {
            ctrDrivingLicenseApplicationInfo1.LoadApplication(_LocalDrivingLicenseApplicationID);
        }
        public FOIssueDriverLicenseFirstTime( int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LoadLocalDrivingApplicationInfo();
        }
 
       
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FOListTestAppointments_Load(object sender, EventArgs e)
        {
            _RefreshTestAppointmentsList();
          
        }
        private void BtnAddAppointments_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.HasExistingAppointment(_LocalDrivingLicenseApplicationID, (int)_TestType))
            {
                MessageBox.Show("⚠️ An appointment already exists for this test type. Please choose a different date or test.", "Duplicate Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clsTestAppointment.HasPassedTestAppointment(_LocalDrivingLicenseApplicationID, (int)_TestType))
            {
                MessageBox.Show("✅ This test has already been passed. No need to schedule another appointment.", "Test Already Passed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FOScheduleTest frm = new FOScheduleTest(_TestType, _LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            FOListTestAppointments_Load(null, null);
        }


    }
}
