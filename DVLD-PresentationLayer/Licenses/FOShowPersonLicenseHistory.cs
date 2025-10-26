using DVLD_BusinessLayer;
using Syncfusion.PdfViewer.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        private int _DriverID;
        private clsDrivers _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;
        private void _LoadLocalLicenseInfo()
        {

            _dtDriverLocalLicensesHistory = clsDrivers.GetLicenses(_DriverID);


            dGViewShowInformationLocalLicenses.DataSource = _dtDriverLocalLicensesHistory;
            LblTotalRecoreds.Text = dGViewShowInformationLocalLicenses.Rows.Count.ToString();

            if (dGViewShowInformationLocalLicenses.Rows.Count > 0)
            {
                dGViewShowInformationLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dGViewShowInformationLocalLicenses.Columns[0].Width = 110;

                dGViewShowInformationLocalLicenses.Columns[1].HeaderText = "App.ID";
                dGViewShowInformationLocalLicenses.Columns[1].Width = 110;

                dGViewShowInformationLocalLicenses.Columns[2].HeaderText = "Class Name";
                dGViewShowInformationLocalLicenses.Columns[2].Width = 270;

                dGViewShowInformationLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dGViewShowInformationLocalLicenses.Columns[3].Width = 170;

                dGViewShowInformationLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dGViewShowInformationLocalLicenses.Columns[4].Width = 170;

                dGViewShowInformationLocalLicenses.Columns[5].HeaderText = "Is Active";
                dGViewShowInformationLocalLicenses.Columns[5].Width = 110;

            }
        }

        private void _LoadInternationalLicenseInfo()
        {

            _dtDriverInternationalLicensesHistory = clsDrivers.GetInternationalLicenses(_DriverID);
            dGViewShowInformationInternationalLicenses.DataSource = _dtDriverInternationalLicensesHistory;
            LblTotalRecoreds.Text = dGViewShowInformationInternationalLicenses.Rows.Count.ToString();

            if (dGViewShowInformationInternationalLicenses.Rows.Count > 0)
            {
                dGViewShowInformationInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dGViewShowInformationInternationalLicenses.Columns[0].Width = 160;

                dGViewShowInformationInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dGViewShowInformationInternationalLicenses.Columns[1].Width = 130;

                dGViewShowInformationInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dGViewShowInformationInternationalLicenses.Columns[2].Width = 130;

                dGViewShowInformationInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dGViewShowInformationInternationalLicenses.Columns[3].Width = 180;

                dGViewShowInformationInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dGViewShowInformationInternationalLicenses.Columns[4].Width = 180;

                dGViewShowInformationInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dGViewShowInformationInternationalLicenses.Columns[5].Width = 120;

            }
        }

        public FOShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FOShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            loadDriverLicenseHistory();
        }
        private void loadDriverLicenseHistory()
        {
            if (_PersonID != -1)
            {
                ctrDetailsPersonWithFilter1.PersonData = clsPerson.Find(_PersonID);
                ctrDetailsPersonWithFilter1.DisablePersonDetails();
            }
            else
            {
                return;
            }
            _Driver = clsDrivers.FindByPersonID(_PersonID);
            if (_Driver != null)
            {
                _DriverID = _Driver.DriverID;
            }
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }
    }
}
