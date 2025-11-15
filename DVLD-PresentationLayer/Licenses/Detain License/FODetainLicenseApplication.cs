using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.Licenses.Control;
using DVLD_PresentationLayer.Tests;
using DVLDShared;
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
    public partial class FODetainLicenseApplication : Form
    {
        private int _DetainID = -1;
        private int _SelectedLicenseID = -1;
        private clsUser _currentUser = null;
        public FODetainLicenseApplication(clsUser currentUser)
        {
            InitializeComponent();
            _currentUser= currentUser;
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
            if (ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.IsDetained)
            {
                MessageBox.Show("Selected License i is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtFineFees.Focus();
            BtnDetain.Enabled = true;
        }
        private void BtnIssue_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            _DetainID = ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFineFees.Text), _currentUser.ID);
            if (_DetainID == -1)
            {
                MessageBox.Show("Faild to Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lblvalueDetainID.Text = _DetainID.ToString();
            MessageBox.Show("License Detained Successfully with ID=" + _DetainID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnDetain.Enabled = false;
            ctrDetailsLicenseWithFilter1.FilterEnabled = false;
            txtFineFees.Enabled = false;
            LLShowLicensesinfo.Enabled = true;

        }
        private void LLShowLicensesinfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOLicenseInfo frm = new FOLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void LLShowLicensesHistroy_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FOShowPersonLicenseHistory frm = new FOShowPersonLicenseHistory(ctrDetailsLicenseWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void BtnAddClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FODetainLicenseApplication_Load(object sender, EventArgs e)
        {
            lblvalueDetainDate.Text =DateTime.Now.ToShortDateString();
            lblvalueCreatedByUser.Text = _currentUser.UserName;
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);

            }
            ;


            if (!clsValidatoin.IsNumber(txtFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFineFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtFineFees, null);
            }
            ;
        }
    }
}
