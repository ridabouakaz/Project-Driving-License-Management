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
    public partial class FOmain : Form
    {
        public FOmain()
        {
            InitializeComponent();
        }
        private void SMItempeople_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo(-1);

        }

 
    }
}
