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
    public partial class CtrDetailsInternationalLicenseApplication : UserControl
    {
        private clsNewLocalDrivingApplication _Application;

        public CtrDetailsInternationalLicenseApplication()
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
        public string Fees
        {
            set => LblValueFees.Text = value;
        }
     
        public string CreatedBy
        {
            set => LblvalueCreatedBy.Text = value;
        }

        public string LLicenseID
        {
            set => LblvalueLLicenseID.Text = value;
        }
        public string LocalLicenseID
        {
            set => LblvalueLocalLicenseID.Text = value;
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
