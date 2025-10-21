using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Applications.International_License
{
    public partial class FONewInternationalLicenseApplication : Form
    {
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

        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
           this.Close();    
        }
    }
}
