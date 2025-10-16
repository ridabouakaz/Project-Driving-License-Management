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

namespace DVLD_PresentationLayer.Licenses.Control
{
    public partial class CtrDetailsLicenseWithFilter : UserControl
    {

        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return ctrDetailsLicenses1.LicenseIDValue; }
        }

        public CtrDetailsLicenseWithFilter()
        {
            InitializeComponent();
        }
        public void LoadLicenseInfo(int LicenseID)
        {
            MTBsearch.Text = LicenseID.ToString();
            ctrDetailsLicenses1.LoadInfo(LicenseID);
            _LicenseID = ctrDetailsLicenses1.LicenseIDValue;
        }
    }
}
