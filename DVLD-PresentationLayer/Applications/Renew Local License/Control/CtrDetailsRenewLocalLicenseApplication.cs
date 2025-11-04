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
    public partial class CtrDetailsRenewLocalLicenseApplication : UserControl
    {
        private clsNewLocalDrivingApplication _Application;

        public CtrDetailsRenewLocalLicenseApplication()
        {
            InitializeComponent();
        }

        public string ILApplicationID
        {
            set => LblValueILApplicationID.Text = value;
        }
        public string ApplicationDate
        {
            set => LblValueApplicationDate.Text = value;
        }
        public string IssueDate
        {
            set => LblValueIssueDate.Text = value;
        }
        public string ApplicationFees
        {
            set => LblValueApplicationFees.Text = value;
        }

        public string LicenseFees
        {
            set => LblValueLicenseFees.Text = value;
        }
        public string Notes
        {
            set => TBNotes.Text = value;
        }
        
        public string RenewedLicenseID
        {
            set => LblvalueRenewedLicenseID.Text = value;
        }
        public string OldLicenseID
        {
            set => LblvalueOldLicenseID.Text = value;
        }
        public string ExpirationDate
        {
            set => LblvalueExpirationDate.Text = value;
        }
        public string CreatedBy
        {
            set => LblvalueCreatedBy.Text = value;
        }
        public string TotalFees
        {
            set => LblvalueTotalFees.Text = value;
        }
        private void LLEditApplicationInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOPersonInfo frm = new FOPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }

    }
}
