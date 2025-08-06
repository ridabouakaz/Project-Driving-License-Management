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
            FOManagePeople frm = new FOManagePeople();
            frm.ShowDialog();
        }

        private void FOmain_Load(object sender, EventArgs e)
        {
            MSMain.Renderer = new MyRenderer();
        }
    }
}
