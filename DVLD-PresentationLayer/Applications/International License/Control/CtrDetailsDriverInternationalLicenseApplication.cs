using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
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
using static DVLD_BusinessLayer.clsApplications;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsDriverInternationalLicenseApplication : UserControl
    {
        private clsNewLocalDrivingApplication _Application;

        public CtrDetailsDriverInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        public string Name
        {
            set => LblValueName.Text = value;
        }
        public string IntLicenseID
        {
            set => LblValueIntLicenseID.Text = value;
        }
        public string LicenseID
        {
            set => LblValueLicenseID.Text = value;
        }
        public string NationalNo
        {
            set => LblValueNationalNo.Text = value;
        }
     
        public string Gendor
        {
            set => LblValueGendor.Text = value;
        }
        public string IssueDate
        {
            set => LblValueIssueDate.Text = value;
        }
        public string ApplicationID
        {
            set => LblvalueApplicationID.Text = value;
        }
        public string IsActive
        {
            set => LblvalueIsActive.Text = value;
        }
        public string DateOfBirth
        {
            set => LblvalueDateOfBirth.Text = value;
        }
        public string DriverID
        {
            set => LblDriverID.Text = value;
        }
        public string ExpirationDate
        {
            set => LblvalueExpirationDate.Text = value;
        }
        private void LLEditApplicationInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOPersonInfo frm = new FOPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }

    }
}
