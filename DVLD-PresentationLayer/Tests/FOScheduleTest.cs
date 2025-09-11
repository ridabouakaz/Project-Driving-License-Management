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
    public partial class FOScheduleTest : Form
    {
        private clsManageTestTypes.enTestType _TestType = clsManageTestTypes.enTestType.VisionTest;

        private void _defaultAppointmentDate()
        {
            DTPDate.MinDate = DateTime.Today; 
            DTPDate.Value = DateTime.Today;   
            DTPDate.MaxDate = DateTime.Today.AddMonths(6);
        }
        public FOScheduleTest(clsManageTestTypes.enTestType TestType)
        {
            InitializeComponent();
            _defaultAppointmentDate();
            _TestType = TestType;
            _LoadTestTypeImageAndTitle();
        }
        private void _LoadTestTypeImageAndTitle()
        {
            switch (_TestType)
            {
                case clsManageTestTypes.enTestType.VisionTest:
                    {
                        GBUserControlDetailesApplication.Text = "Vision Test";
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.eyetest;
                        break;
                    }
                case clsManageTestTypes.enTestType.WrittenTest:
                    {
                        GBUserControlDetailesApplication.Text = "Written Test";
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.test;
                        break;
                    }
                case clsManageTestTypes.enTestType.StreetTest:
                    {
                        GBUserControlDetailesApplication.Text = "Street Test";
                        PBManageTestAppointments.Image = DVLD_PresentationLayer.Properties.Resources.StreetTest;
                        break;
                    }
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
