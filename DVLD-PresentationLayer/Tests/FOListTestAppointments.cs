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

namespace DVLD_PresentationLayer.Tests
{
    public partial class FOListTestAppointments : Form
    {
        private DataTable _dtLicenseTestAppointments;
        private int _LocalDrivingLicenseApplicationID;
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;
        public FOListTestAppointments(int LocalDrivingLicenseApplicationID, clsManageTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
            _LoadTestTypeImageAndTitle();

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
    }
}
