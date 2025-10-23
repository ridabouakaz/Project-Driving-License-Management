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
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsNewLocalDrivingApplication _LocalDrivingLicense;
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        private void _RefreshTestAppointmentsList()
        {
          
            //_dtLicenseTestAppointments = clsTestAppointment.GetAllAppointments(_LocalDrivingLicenseApplicationID,(int)_TestType);
            //dGViewShowInformation.DataSource = _dtLicenseTestAppointments;
            //LblTotalRecoreds.Text = dGViewShowInformation.Rows.Count.ToString();
        }
        void _LoadLocalDrivingApplicationInfo()
        {
            //ctrDrivingLicenseApplicationInfo1.LoadApplication(_LocalDrivingLicenseApplicationID);
        }
        public FOShowPersonLicenseHistory(clsManageTestTypes.enTestType TestType, int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
            _LoadLocalDrivingApplicationInfo();

        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FOListTestAppointments_Load(object sender, EventArgs e)
        {
            _RefreshTestAppointmentsList();
            //if (dGViewShowInformation.Rows.Count > 0)
            //{
            //    dGViewShowInformation.Columns[0].HeaderText = "Appointment ID";
            //    dGViewShowInformation.Columns[0].Width = 90;

            //    dGViewShowInformation.Columns[1].HeaderText = "Appointment Date";
            //    dGViewShowInformation.Columns[1].Width = 140;

            //    dGViewShowInformation.Columns[2].HeaderText = "Paid Fees";
            //    dGViewShowInformation.Columns[2].Width = 120;

            //    dGViewShowInformation.Columns[3].HeaderText = "Is Locked";
            //    dGViewShowInformation.Columns[3].Width = 100;
            //}
        }


    
    }
}
