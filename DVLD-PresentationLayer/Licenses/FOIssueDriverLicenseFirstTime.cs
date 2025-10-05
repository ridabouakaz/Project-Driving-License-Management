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
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOIssueDriverLicenseFirstTime : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsNewLocalDrivingApplication _LocalDrivingLicense;
        private clsDrivers _Driver = new clsDrivers();
        private clsLicenses _License = new clsLicenses();
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public string Notes
        {
            get => TBNotes.Text.Trim();
            set => TBNotes.Text = value;
        }
        void _LoadLocalDrivingApplicationInfo()
        {
            ctrDrivingLicenseApplicationInfo1.LoadApplication(_LocalDrivingLicenseApplicationID);
            _LocalDrivingLicense=clsNewLocalDrivingApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);
        }
        public FOIssueDriverLicenseFirstTime( int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.AddNew;
            _LoadLocalDrivingApplicationInfo();
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnIssue_Click(object sender, EventArgs e)
        {
            _Driver.PersonID= _LocalDrivingLicense.ApplicantPersonID;
            _Driver.CreatedByUserID= _LocalDrivingLicense.CreatedByUserID;
            _Driver.CreatedDate= DateTime.Today;

            if (!_Driver.Save())
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _License.ApplicationID= _LocalDrivingLicense.ApplicationID;
            _License.DriverID= _Driver.DriverID;
            _License.LicenseClass= _LocalDrivingLicense.LicenseClassID;
            _License.IssueDate= DateTime.Today;
            _License.ExpirationDate= DateTime.Today.AddYears(clsLicenses.GetDefaultValidityLengthById(_LocalDrivingLicense.LicenseClassID));
            _License.Notes = Notes;
            _License.PaidFees = _LocalDrivingLicense.PaidFees;
            _License.IsActive = ActiveStatus.Yes;
            _License.IssueReason = IssueReason.FirstTime;
            _License.CreatedByUserID = _LocalDrivingLicense.CreatedByUserID;
            if (_License.Save())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
