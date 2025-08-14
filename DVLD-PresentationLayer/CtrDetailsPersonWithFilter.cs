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
    public partial class CtrDetailsPersonWithFilter : UserControl
    {
        public CtrDetailsPersonWithFilter()
        {
            InitializeComponent();
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo fOAddEditPersonInfo = new FOAddEditPersonInfo();
            fOAddEditPersonInfo.DataBack += FOAddEditPersonInfo_DataBack;
        }
        private void FOAddEditPersonInfo_DataBack(object sender, int PersonID)
        {
         
        }
    }
}
