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
    public partial class FOAddEditUserInfo : Form
    {
        public FOAddEditUserInfo()
        {
            InitializeComponent();
        }
        private void BtnAddNext_Click(object sender, EventArgs e)
        {
            if (ctrDetailsPersonWithFilter1.PersonData ==null)
            {
                MessageBox.Show("Please enter the person data before proceeding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
