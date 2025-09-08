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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_PresentationLayer
{
    public partial class ForTest : Form
    {
        public enum enMode { Update = 1 };
        private enMode _Mode;
        int _PersonID;
        clsApplications _Application;
        public ForTest()
        {
            InitializeComponent();
            _LoadData();
        }
        private void _LoadData()
        {
            
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationBYApplicationID(4);
        }
    }

}
