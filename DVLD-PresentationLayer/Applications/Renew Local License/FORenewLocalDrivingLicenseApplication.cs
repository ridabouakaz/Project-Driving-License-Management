using DVLD_BusinessLayer;
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
        private int _InternationalLicenseID = -1;
        public FORenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrDetailsLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            //ctrDetailsInternationalLicenseApplication1.LocalLicenseID = SelectedLicenseID.ToString();

            //llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }

            if (ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
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
            ctrDetailsRenewLocalLicenseApplication1.RenewedLicenseID = NewLicense.LicenseID.ToString();

            MessageBox.Show("Licensed Renewed Successfully with ID=" + NewLicense.LicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnRenew.Enabled = false;
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
            //llShowLicenseInfo.Enabled = true;
        

            clsInternationalLicense InternationalLicense = new clsInternationalLicense();
            //those are the information for the base application, because it inhirts from application, they are part of the sub class.

            InternationalLicense.ApplicantPersonID = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsManageApplicationTypes.Find(6).ApplicationFees;
            InternationalLicense.CreatedByUserID = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.CreatedByUserID;
            InternationalLicense.DriverID = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            ctrDetailsRenewLocalLicenseApplication1.ILApplicationID = InternationalLicense.ApplicationID.ToString();
            ctrDetailsRenewLocalLicenseApplication1.ApplicationDate = InternationalLicense.ApplicationDate.ToShortDateString();
            ctrDetailsRenewLocalLicenseApplication1.IssueDate = InternationalLicense.IssueDate.ToShortDateString();
            ctrDetailsRenewLocalLicenseApplication1.ApplicationFees = InternationalLicense.IssueDate.ToShortDateString();
            ctrDetailsRenewLocalLicenseApplication1.LicenseFees = InternationalLicense.PaidFees.ToString();
            ctrDetailsRenewLocalLicenseApplication1.Notes = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            ctrDetailsRenewLocalLicenseApplication1.RenewedLicenseID = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            ctrDetailsRenewLocalLicenseApplication1.OldLicenseID = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            ctrDetailsRenewLocalLicenseApplication1.ExpirationDate = InternationalLicense.ExpirationDate.ToShortDateString();
            ctrDetailsRenewLocalLicenseApplication1.CreatedBy = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.CreatedByUserID.ToString();
            ctrDetailsRenewLocalLicenseApplication1.TotalFees = InternationalLicense.InternationalLicenseID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnRenew.Enabled = false;
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
            LLShowLicensesinfo.Enabled = true;

        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
           this.Close();    
        }

        private void LLShowLicensesinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOInternationalDriverInfo frm = new FOInternationalDriverInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }
        private void LLShowLicensesHistroy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOShowPersonLicenseHistory frm = new FOShowPersonLicenseHistory(ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void FONewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            LLShowLicensesinfo.Enabled = false;
        }
    }
}
