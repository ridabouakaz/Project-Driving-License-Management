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
    public partial class CtrDetailsReplaceLostOrDamagedLicenseApplication : UserControl
    {
        private clsNewLocalDrivingApplication _Application;

        public CtrDetailsReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }

        public string LRApplicationID
        {
            set => LblValueLRApplicationID.Text = value;
        }
        public string ApplicationDate
        {
            get => LblValueApplicationDate.Text.Trim();
            set => LblValueApplicationDate.Text = value;
        }
     
        public string ApplicationFees
        {
            get => LblValueApplicationFees.Text.Trim();
            set => LblValueApplicationFees.Text = value;
        }


        public string ReplacedLicenseID
        {
            get => LblvalueReplacedLicenseID.Text.Trim();
            set => LblvalueReplacedLicenseID.Text = value;
        }
        public string OldLicenseID
        {
            set => LblvalueOldLicenseID.Text = value;
        }
      
        public string CreatedBy
        {
            set => LblvalueCreatedBy.Text = value;
        }
        private void LLEditApplicationInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOPersonInfo frm = new FOPersonInfo(_Application.ApplicantPersonID);
            frm.ShowDialog();
        }

    }
}
