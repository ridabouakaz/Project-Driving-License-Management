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
    public partial class FOListTestAppointments : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsNewLocalDrivingApplication _LocalDrivingLicense;
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private void _RefreshTestAppointmentsList()
        {
            _dtLicenseTestAppointments = clsTestAppointment.GetAllAppointments();
            dGViewShowInformation.DataSource = _dtLicenseTestAppointments;
            LblTotalRecoreds.Text = dGViewShowInformation.Rows.Count.ToString();
        }
        void _LoadLocalDrivingApplicationInfo()
        {
            ctrDrivingLicenseApplicationInfo1.LoadApplication(_LocalDrivingLicenseApplicationID);
        }
        public FOListTestAppointments( clsManageTestTypes.enTestType TestType, int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
            _LoadTestTypeImageAndTitle();
            _LoadLocalDrivingApplicationInfo();

        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {
                case clsManageTestTypes.enTestType.VisionTest:
                    {
                        LblManageTestAppointments.Text = "Vision Test Appointments";
                        this.Text = LblManageTestAppointments.Text;
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.eyetest;
                        break;
                    }
                case clsManageTestTypes.enTestType.WrittenTest:
                    {
                        LblManageTestAppointments.Text = "Written Test Appointments";
                        this.Text = LblManageTestAppointments.Text;
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.test;
                        break;
                    }
                case clsManageTestTypes.enTestType.StreetTest:
                    {
                        LblManageTestAppointments.Text = "Street Test Appointments";
                        this.Text = LblManageTestAppointments.Text;
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.StreetTest;
                        break;
                    }
            }
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FOListTestAppointments_Load(object sender, EventArgs e)
        {
            _RefreshTestAppointmentsList();
            if (dGViewShowInformation.Rows.Count > 0)
            {
                dGViewShowInformation.Columns[0].HeaderText = "Appointment ID";
                dGViewShowInformation.Columns[0].Width = 90;

                dGViewShowInformation.Columns[1].HeaderText = "Appointment Date";
                dGViewShowInformation.Columns[1].Width = 140;

                dGViewShowInformation.Columns[2].HeaderText = "Paid Fees";
                dGViewShowInformation.Columns[2].Width = 120;

                dGViewShowInformation.Columns[3].HeaderText = "Is Locked";
                dGViewShowInformation.Columns[3].Width = 100;
            }
        }
        private void BtnAddAppointments_Click(object sender, EventArgs e)
        {
            FOScheduleTest frm = new FOScheduleTest(_TestType, _LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            FOListTestAppointments_Load(null, null);
        }
    }
}
