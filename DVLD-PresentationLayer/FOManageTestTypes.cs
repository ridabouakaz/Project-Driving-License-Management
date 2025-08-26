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

namespace DVLD_PresentationLayer
{
    public partial class FOManageTestTypes : Form
    {
        private static DataTable _dtTestTypes;

        public FOManageTestTypes()
        {
            InitializeComponent();
        }

    

        private void FOManageTestTypes_Load(object sender, EventArgs e)
        {
            _dtTestTypes= clsManageTestTypes.GetAllTestTypes();
            dGViewShowInformation.DataSource = _dtTestTypes;
            LblTotalRecoreds.Text = dGViewShowInformation.Rows.Count.ToString();
            if (dGViewShowInformation.Rows.Count > 0)
            {

                dGViewShowInformation.Columns[0].HeaderText = "ID";
                dGViewShowInformation.Columns[0].Width = 30;

                dGViewShowInformation.Columns[1].HeaderText = "Title";
                dGViewShowInformation.Columns[1].Width = 60;

                dGViewShowInformation.Columns[2].HeaderText = "Title";
                dGViewShowInformation.Columns[2].Width = 120;


                dGViewShowInformation.Columns[3].HeaderText = "Fees";
                dGViewShowInformation.Columns[3].Width = 110;
            }
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
           this.Close();    
        }

        private void SMItemEditApplicationType_Click(object sender, EventArgs e)
        {
            FOEditApplicationType frm = new FOEditApplicationType((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FOManageTestTypes_Load(null,null);
        }

        private void SMItemEditTestType_Click(object sender, EventArgs e)
        {
            FOEditTestType frm = new FOEditTestType((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FOManageTestTypes_Load(null, null);
        }
    }
}
