using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.International_License;
using DVLD_PresentationLayer.Licenses;
using DVLD_PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsDetainedLicenseFilter.DetainedLicenseFilterService;

namespace DVLD_PresentationLayer
{
    public partial class FOManageDetainedLicenses : Form
    {
        private static DataTable _DetainedLicensesTable = clsDetainedLicense.GetAllDetainedLicenses();
        private clsUser _currentUser = null;
        public FOManageDetainedLicenses()
        {
            InitializeComponent();
        }
        public FOManageDetainedLicenses(clsUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }
        private void _RefreshPeopleList()
        {
            _DetainedLicensesTable = clsDetainedLicense.GetAllDetainedLicenses();
            dGViewShowInformation.DataSource = _DetainedLicensesTable;
            LblTotalRecoreds.Text = _DetainedLicensesTable.Rows.Count.ToString();
        }
        private void SMItemViewDetails_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dGViewShowInformation.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenses.FindByLicenseID(LicenseID).DriverInfo.PersonID;

            FOPersonInfo frm = new FOPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void SMItemAddUser_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dGViewShowInformation.CurrentRow.Cells[1].Value;

            FOLicenseInfo frm = new FOLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void SMItemEditUser_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dGViewShowInformation.CurrentRow.Cells[1].Value;
            int PersonID = clsLicenses.FindByLicenseID(LicenseID).DriverInfo.PersonID;
            FOShowPersonLicenseHistory frm = new FOShowPersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }
        private void SMItemReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dGViewShowInformation.CurrentRow.Cells[1].Value;

            FOReleaseDetainedLicenseApplication frm = new FOReleaseDetainedLicenseApplication(LicenseID);
            frm.ShowDialog();
            FOManageUsers_Load(null, null);
        }
  
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            FODetainLicenseApplication frm = new FODetainLicenseApplication(_currentUser);
            frm.ShowDialog();
            //refresh
            FOManageUsers_Load(null, null);
        }


        private void ApplyFilter()
        {
            if (_DetainedLicensesTable == null) return;

            IDetainedLicenseFilter filter = null;
            
            switch (CBFilterBy.SelectedItem.ToString())
            {

                case "Detain ID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        filter = new DetainIdFilter(id);
                    break;
                case "Is Released":
                    this.MTBsearch.Mask = "";
                    filter = new IsReleasedFilter(cbIsReleased.SelectedItem.ToString());
                    break;
                case "National No":
                    this.MTBsearch.Mask = "";
                    filter = new NationalNoFilter(MTBsearch.Text);
                    break;
                case "Full Name":
                    this.MTBsearch.Mask = "";
                    filter = new FullNameFilter(MTBsearch.Text);
                    break;
                case "Release Application ID":
                    this.MTBsearch.Mask = "0000000000";
                    this.MTBsearch.PromptChar = ' ';
                    this.MTBsearch.SkipLiterals = true;
                    if (int.TryParse(MTBsearch.Text, out int ReleaseApplicationId))
                        filter = new ReleaseApplicationIdFilter(ReleaseApplicationId);
                    break;
         
               
             
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_DetainedLicensesTable)
                : new DataView(_DetainedLicensesTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CBFilterBy.SelectedItem.ToString();

            if (selected == "Is Released")
            {
                MTBsearch.Visible = false;
                cbIsReleased.Visible = true;
            }
            else if (selected == "None")
            {
                MTBsearch.Visible = false;
                cbIsReleased.Visible = false;
            }
            else
            {
                MTBsearch.Visible = true;
                cbIsReleased.Visible = false;
            }
            ApplyFilter();
        }
        private void FOManageUsers_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            cbIsReleased.SelectedIndex = 0;
            _RefreshPeopleList();
        }

        private void MTBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CBActiveStatusBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            FOReleaseDetainedLicenseApplication frm = new FOReleaseDetainedLicenseApplication();
            frm.ShowDialog();
            //refresh
            FOManageUsers_Load(null, null);
        }
    }
}
