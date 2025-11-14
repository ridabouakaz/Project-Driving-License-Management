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
    public partial class FOReleaseDetainedLicenseApplication : Form
    {
        private int _SelectedLicenseID = -1;
        public FOReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }

        public FOReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = LicenseID;
            ctrDetailsLicenseWithFilter1.LoadLicenseInfo(_SelectedLicenseID);
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
        }

        private void ctrDetailsLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;
            lblvalueLicenseID.Text = _SelectedLicenseID.ToString();

            LLShowLicensesHistroy.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }
            if (!ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblvalueApplicationFees.Text = clsManageApplicationTypes.Find((int)clsApplications.enApplicationType.ReleaseDetainedDrivingLicsense).ApplicationFees.ToString();
            lblvalueCreatedByUser.Text = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.CreatedByUserID.ToString();

            lblvalueDetainID.Text = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblvalueLicenseID.Text = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            lblvalueCreatedByUser.Text = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DetainedInfo.CreatedByUserInfo.UserName;
            lblvalueDetainDate.Text = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate.ToShortDateString();
            lblvalueFineFees.Text = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lblvalueTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblFineFees.Text)).ToString();
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

            BtnRelease.Enabled = false;
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
