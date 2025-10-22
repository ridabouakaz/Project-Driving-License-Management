using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Licenses.Control;
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
    public partial class FONewInternationalLicenseApplication : Form
    {
        private int _InternationalLicenseID = -1;
        public FONewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void ctrDetailsLicenseWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            ctrDetailsInternationalLicenseApplication1.LocalLicenseID = SelectedLicenseID.ToString();

            //llShowLicenseHistory.Enabled = (SelectedLicenseID != -1);

            if (SelectedLicenseID == -1)

            {
                return;
            }
            //check the license class, person could not issue international license without having
            //normal license of class 3.

            if (ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.LicenseClass != 3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //check if person already have an active international license
            int ActiveInternaionalLicenseID = clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LLShowLicensesinfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                BtnIssue.Enabled = false;
                return;
            }
            BtnIssue.Enabled = true;

        }
        private void BtnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
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
            ctrDetailsInternationalLicenseApplication1.ILApplicationID = InternationalLicense.ApplicationID.ToString();
            ctrDetailsInternationalLicenseApplication1.LLicenseID= InternationalLicense.InternationalLicenseID.ToString();
            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            MessageBox.Show("International License Issued Successfully with ID=" + InternationalLicense.InternationalLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BtnIssue.Enabled = false;
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
            LLShowLicensesinfo.Enabled = true;

        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
           this.Close();    
        }

        private void LLShowLicensesinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
