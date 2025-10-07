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

namespace DVLD_PresentationLayer.Licenses
{
    public partial class FOLicenseInfo : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsLicenses _License;
        public FOLicenseInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _LoadData();
        }
        private void _LoadData()
        {
            _License = clsLicenses.FindByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID);

            if (_License == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _License.LicenseID);
                this.Close();

                return;
            }
            ctrDetailsLicenses1.LicenseData = _License;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
