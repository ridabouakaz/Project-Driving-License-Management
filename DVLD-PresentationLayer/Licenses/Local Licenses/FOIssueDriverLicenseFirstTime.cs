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
            int LicenseID = _LocalDrivingLicense.IssueLicenseForTheFirtTime(Notes, _LocalDrivingLicense.CreatedByUserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
