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
        private void _defaultAppointmentDate()
        {
            DTPDate.MinDate = DateTime.Today; 
            DTPDate.Value = DateTime.Today;   
            DTPDate.MaxDate = DateTime.Today.AddMonths(6);
        }
        public FOScheduleTest()
        {
            InitializeComponent();
            _defaultAppointmentDate();
        }


    }
}
