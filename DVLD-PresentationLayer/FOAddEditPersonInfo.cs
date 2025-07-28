using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static DVLD_BusinessLayer.clsCountry;
namespace DVLD_PresentationLayer
{
    public partial class FOAddEditPersonInfo : Form
    {

        public FOAddEditPersonInfo()
        {
            InitializeComponent();
 
        }
        private void FOAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            ctrDetailsPerson_Edit_Add_1.NationalNumberValidating += CtrDetailsPerson1_NationalNumberValidating;

        }
        private void CtrDetailsPerson1_NationalNumberValidating(object sender, CancelEventArgs e)
        {
            string nationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo;

                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "Gg");
                //e.Cancel = true;
        }

        
    }
}
