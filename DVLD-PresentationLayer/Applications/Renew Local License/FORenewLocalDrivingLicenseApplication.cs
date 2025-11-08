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
    public partial class FORenewLocalDrivingLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public FORenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrDetailsLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            //ctrDetailsInternationalLicenseApplication1.LocalLicenseID = SelectedLicenseID.ToString();
            ctrDetailsRenewLocalLicenseApplication1.OldLicenseID = SelectedLicenseID.ToString();

            //llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }
            int DefaultValidityLength = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidityLength;
            ctrDetailsRenewLocalLicenseApplication1.ExpirationDate = (DateTime.Now.AddYears(DefaultValidityLength)).ToShortDateString();
            ctrDetailsRenewLocalLicenseApplication1.LicenseFees = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.LicenseClassInfo.ClassFees.ToString();
            ctrDetailsRenewLocalLicenseApplication1.TotalFees = (Convert.ToSingle(ctrDetailsRenewLocalLicenseApplication1.ApplicationFees) + Convert.ToSingle(ctrDetailsRenewLocalLicenseApplication1.LicenseFees)).ToString();
            ctrDetailsRenewLocalLicenseApplication1.Notes = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.Notes;
            ctrDetailsRenewLocalLicenseApplication1.CreatedBy = (ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.CreatedByUserID).ToString();
            if (!ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show("Person already have an active  license with ID = " + SelectedLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LLShowLicensesinfo.Enabled = true;
                BtnRenew.Enabled = false;
                return;
            }
            if (ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.IsActive==ActiveStatus.No)
            {
                MessageBox.Show("Selected License is not Not Active, choose an active license" , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LLShowLicensesinfo.Enabled = true;
                BtnRenew.Enabled = false;
                return;
            }
            BtnRenew.Enabled = true;

        }
        private void BtnIssue_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            clsLicenses NewLicense =
                ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.RenewLicense(ctrDetailsRenewLocalLicenseApplication1.Notes,
                ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.CreatedByUserID);
            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            ctrDetailsRenewLocalLicenseApplication1.ILApplicationID = NewLicense.ApplicationID.ToString();
            _NewLicenseID = NewLicense.LicenseID;
            ctrDetailsRenewLocalLicenseApplication1.RenewedLicenseID = _NewLicenseID.ToString();

            MessageBox.Show("Licensed Renewed Successfully with ID=" + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnRenew.Enabled = false;
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
            LLShowLicensesinfo.Enabled = true;

        }
        private void LLShowLicensesinfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOLicenseInfo frm = new FOLicenseInfo(int.Parse(ctrDetailsRenewLocalLicenseApplication1.RenewedLicenseID));
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
            ctrDetailsRenewLocalLicenseApplication1.ApplicationDate = (DateTime.Now).ToShortDateString();
            ctrDetailsRenewLocalLicenseApplication1.IssueDate = ctrDetailsRenewLocalLicenseApplication1.ApplicationDate;
            ctrDetailsRenewLocalLicenseApplication1.ApplicationFees = clsManageApplicationTypes.Find((int)clsApplications.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
        }

        private void BtnAddClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
