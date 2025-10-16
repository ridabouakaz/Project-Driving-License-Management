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
        // Define a custom event handler delegate with parameters
        public event Action<int> OnLicenseSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID); // Raise the event with the parameter
            }
        }

        private int _LicenseID = -1;

        public int LicenseID
        {
            get { return ctrDetailsLicenses1.LicenseIDValue; }
        }
        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                GBUserControlDetailesLicenseWithFilter.Enabled = _FilterEnabled;
            }
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
            if (OnLicenseSelected != null && FilterEnabled)
                // Raise the event with a parameter
                OnLicenseSelected(_LicenseID);
        }

        private void BtnSearchPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MTBsearch.Focus();
                return;

            }
            _LicenseID = int.Parse(MTBsearch.Text);
            LoadLicenseInfo(_LicenseID);
        }
    }
}
