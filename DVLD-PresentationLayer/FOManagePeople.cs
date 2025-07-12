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
    public partial class FOManagePeople : Form
    {
        public FOManagePeople()
        {
            InitializeComponent();
        }

        private void FOManagePeople_Load(object sender, EventArgs e)
        {
            CenterDataGridView();

        }

        private void CenterDataGridView()
        {
            int margin = 10;

            dGViewShowInformation.Left = (this.ClientSize.Width - dGViewShowInformation.Width) / 2;

            dGViewShowInformation.Top = (this.ClientSize.Height - dGViewShowInformation.Height) / 2;

            if (dGViewShowInformation.Top < margin) dGViewShowInformation.Top = margin;
            if (dGViewShowInformation.Left < margin) dGViewShowInformation.Left = margin;

        }
    }
}
