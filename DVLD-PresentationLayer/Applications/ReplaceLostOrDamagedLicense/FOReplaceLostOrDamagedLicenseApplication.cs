using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.Licenses.Control;
using DVLD_PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer.Applications.International_License
{
    public partial class FOReplaceLostOrDamagedLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public FOReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            //this will decide which application type to use accirding 
            // to user selection.

            if (RBDamagedLicense.Checked)

                return (int)clsApplications.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)clsApplications.enApplicationType.ReplaceLostDrivingLicense;
        }
        private void RBDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            LblHeaderTitle.Text = "Replacement for Damaged License";
            this.Text = LblHeaderTitle.Text;
            ctrDetailsReplaceLostOrDamagedLicenseApplication1.ApplicationFees = clsManageApplicationTypes.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }

        private void RBLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            LblHeaderTitle.Text = "Replacement for Lost License";
            this.Text = LblHeaderTitle.Text;
            ctrDetailsReplaceLostOrDamagedLicenseApplication1.ApplicationFees =
                clsManageApplicationTypes.Find(_GetApplicationTypeID()).ApplicationFees.ToString();
        }
        private IssueReason _GetIssueReason()
        {
            //this will decide which reason to issue a replacement for

            if (RBDamagedLicense.Checked)

                return IssueReason.ReplacementforDamaged;
            else
                return IssueReason.ReplacementforLost;
        }
        private void ctrDetailsLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            ctrDetailsReplaceLostOrDamagedLicenseApplication1.OldLicenseID = SelectedLicenseID.ToString();

            LLShowLicensesHistroy.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }
            int DefaultValidityLength = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLength;
            if (ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.IsActive==ActiveStatus.No)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license" , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LLShowLicensesinfo.Enabled = true;
                BtnIssueReplacement.Enabled = false;
                return;
            }
            BtnIssueReplacement.Enabled = true;

        }
        private void BtnIssue_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            clsLicenses NewLicense =
                ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(),
                ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.CreatedByUserID);
            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ctrDetailsReplaceLostOrDamagedLicenseApplication1.LRApplicationID = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            ctrDetailsReplaceLostOrDamagedLicenseApplication1.ReplacedLicenseID = _NewLicenseID.ToString();

            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnIssueReplacement.Enabled = false;
            GBRepalcementFor.Enabled = false;
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
            LLShowLicensesinfo.Enabled = true;

        }
        private void LLShowLicensesinfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOLicenseInfo frm = new FOLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }

        private void LLShowLicensesHistroy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOShowPersonLicenseHistory frm = new FOShowPersonLicenseHistory(ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void FORenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            LLShowLicensesinfo.Enabled = false;
            ctrDetailsReplaceLostOrDamagedLicenseApplication1.ApplicationDate = (DateTime.Now).ToShortDateString();
            ctrDetailsReplaceLostOrDamagedLicenseApplication1.CreatedBy = clsManageApplicationTypes.Find((int)clsApplications.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();

        }

        private void BtnAddClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
