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
        private int _LicenseID;
        public FOLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }
      
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FOLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrDetailsLicenses1.LoadInfo(_LicenseID);
        }
    }
}
