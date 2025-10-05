using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.Local_Driving_License;
using DVLD_PresentationLayer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.LocalDrivingApplicationFilter.LocalDrivingApplicationFilterService;
using static DVLD_BusinessLayer.PersonFilterService;
namespace DVLD_PresentationLayer
{
    public partial class FOManageLocalDrivingApplication : Form
    {
        private static DataTable _LocalDrivingApplicationsTable = clsNewLocalDrivingApplication.GetAllLocalDrivingApplications();
        clsUser _CurrentUser;
        public FOManageLocalDrivingApplication(clsUser CurrentUser)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
            this.Size = new Size(1400, 650);

        }
        private void BtnAddLocalDrivingApplication_Click(object sender, EventArgs e)
        {
            FONewLocalDrivingApplication frm = new FONewLocalDrivingApplication(_CurrentUser);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }
        private void _RefreshLocalDrivingApplicationsList()
        {
            _LocalDrivingApplicationsTable = clsNewLocalDrivingApplication.GetAllLocalDrivingApplications();
            dGViewShowInformation.DataSource = _LocalDrivingApplicationsTable;
            LblTotalRecoreds.Text = _LocalDrivingApplicationsTable.Rows.Count.ToString();
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected = CBFilterBy.SelectedItem.ToString();

            if (selected == "Status")
            {
                MTBsearch.Visible = false;
                CBActiveStatusBy.Visible = true;
            }
            else if (selected == "None")
            {
                MTBsearch.Visible = false;
                CBActiveStatusBy.Visible = false;
            }
            else
            {
                MTBsearch.Visible = true;
                CBActiveStatusBy.Visible = false;
            }
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_LocalDrivingApplicationsTable == null) return;

            ILocalDrivingApplicationFilter filter = null;

            switch (CBFilterBy.SelectedItem.ToString())
            {
                case "D.L.AppID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        filter = new LDLAppIDFilter(id);
                    break;
                case "National No":
                    this.MTBsearch.Mask = "";
                    filter = new NationalNoLDLFilter(MTBsearch.Text);
                    break;
                case "Full Name":
                    this.MTBsearch.Mask = "";
                    filter = new FullNameFilter(MTBsearch.Text);
                    break;

                case "Status":
                    this.MTBsearch.Mask = "";
                    filter = new ActiveStatusFilter(CBActiveStatusBy.SelectedItem.ToString());
                    break;
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_LocalDrivingApplicationsTable)
                : new DataView(_LocalDrivingApplicationsTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }
        private void MTBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void FOManageLocalDrivingApplication_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            CBActiveStatusBy.SelectedIndex = 0;
            _RefreshLocalDrivingApplicationsList();
        }

        private void CBActiveStatusBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }
        private void SMItemShowApplicationDetails_Click(object sender, EventArgs e)
        {
            FOLocalDrivingLicenseApplicationInfo frm = new FOLocalDrivingLicenseApplicationInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void SMItemCancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Cancel Application [" + dGViewShowInformation.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                if (clsNewLocalDrivingApplication.CancelledLocalDrivingLicenseApplications((int)dGViewShowInformation.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Cancelled Successfully.");
                    _RefreshLocalDrivingApplicationsList();
                }
                else
                    MessageBox.Show("Application is not Cancelled.");

            }
        }
        private void SMItemDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete Application [" + dGViewShowInformation.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                if (clsNewLocalDrivingApplication.DeleteLocalDrivingLicenseApplications((int)dGViewShowInformation.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Application Deleted Successfully.");
                    _RefreshLocalDrivingApplicationsList();
                }
                else
                    MessageBox.Show("Application is not Deleted.");
            }
        }

        private void SMItemScheduleVisionTest_Click(object sender, EventArgs e)
        {
            FOListTestAppointments frm = new FOListTestAppointments(clsManageTestTypes.enTestType.VisionTest, (int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }

        private void SMItemScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            FOListTestAppointments frm = new FOListTestAppointments(clsManageTestTypes.enTestType.WrittenTest, (int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }

        private void SMItemScheduleStreetTest_Click(object sender, EventArgs e)
        {
            FOListTestAppointments frm = new FOListTestAppointments(clsManageTestTypes.enTestType.StreetTest, (int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }

        private void SMItemCRUDLocalDrivingApplications_Opening(object sender, CancelEventArgs e)
        {
            bool HasIssuedLicense = clsLicenses.HasIssuedLicense((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            SMItemScheduleVisionTest.Enabled = (clsNewLocalDrivingApplication.GetPassedTestCount((int)dGViewShowInformation.CurrentRow.Cells[0].Value) == 0) && !HasIssuedLicense;
            SMItemScheduleWrittenTest.Enabled = (clsNewLocalDrivingApplication.GetPassedTestCount((int)dGViewShowInformation.CurrentRow.Cells[0].Value) == 1) && !HasIssuedLicense;
            SMItemScheduleStreetTest.Enabled = (clsNewLocalDrivingApplication.GetPassedTestCount((int)dGViewShowInformation.CurrentRow.Cells[0].Value) == 2) && !HasIssuedLicense;
            SMItemIssueDrivingLicenseFirstTime.Enabled = (clsNewLocalDrivingApplication.GetPassedTestCount((int)dGViewShowInformation.CurrentRow.Cells[0].Value) == 3) && !HasIssuedLicense;
            SMItemCancelApplication.Enabled = !HasIssuedLicense;
            SMItemDeleteApplication.Enabled = !HasIssuedLicense;
            SMItemEditApplication.Enabled = !HasIssuedLicense;
            SMItemScheduleTest.Enabled= !HasIssuedLicense;
        }


        private void SMItemIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            FOIssueDriverLicenseFirstTime frm = new FOIssueDriverLicenseFirstTime((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }
    }
}

