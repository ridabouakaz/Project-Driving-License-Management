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
    public partial class FOInternationalDriverInfo : Form
    {
        private int _InternationalLicenseID;
        public FOInternationalDriverInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }
        private void FOInternationalDriverInfo_Load(object sender, EventArgs e)
        {
            ctrDetailsDriverInternationalLicenseApplication1.LoadInfo(_InternationalLicenseID);
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
