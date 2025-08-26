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
    public partial class FOManageApplicationTypes : Form
    {
        private static DataTable _dtApplicationTypes = clsManageApplicationTypes.GetAllApplicationTypes();

        public FOManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleList()
        {
            _dtApplicationTypes = clsManageApplicationTypes.GetAllApplicationTypes();
            dGViewShowInformation.DataSource = _dtApplicationTypes;
            LblTotalRecoreds.Text = _dtApplicationTypes.Rows.Count.ToString();
        }

        private void FOManageApplicationTypes_Load(object sender, EventArgs e)
        {
            dGViewShowInformation.DataSource = _dtApplicationTypes;
            LblTotalRecoreds.Text = dGViewShowInformation.Rows.Count.ToString();
            if (dGViewShowInformation.Rows.Count > 0)
            {

                dGViewShowInformation.Columns[0].HeaderText = "ID";
                dGViewShowInformation.Columns[0].Width = 30;

                dGViewShowInformation.Columns[1].HeaderText = "Title";
                dGViewShowInformation.Columns[1].Width = 120;


                dGViewShowInformation.Columns[2].HeaderText = "Fees";
                dGViewShowInformation.Columns[2].Width = 110;
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
            _RefreshPeopleList();
        }
    }
}
