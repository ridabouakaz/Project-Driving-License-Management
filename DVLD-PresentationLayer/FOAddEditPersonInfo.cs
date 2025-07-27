using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class FOAddEditPersonInfo : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _ContactID;
        clsContact _Contact;
        public FOAddEditPersonInfo(int ContactID)
        {
            InitializeComponent();
            _ContactID = ContactID;

            if (_ContactID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;
        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                cbCountry.Items.Add(row["CountryName"]);

            }

        }
        private void FOAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            ctrDetailsPerson_Edit_Add_1.NationalNumberValidating += CtrDetailsPerson1_NationalNumberValidating;

        }
        private void CtrDetailsPerson1_NationalNumberValidating(object sender, CancelEventArgs e)
        {
            string nationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo;

                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "Gg");
                //e.Cancel = true;
        }

        
    }
}
