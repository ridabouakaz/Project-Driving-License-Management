using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DVLD_PresentationLayer
{
    public partial class FOmain : Form
    {
        public FOmain()
        {
            InitializeComponent();
        }

        private void FOmain_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();

        }
    }
}
