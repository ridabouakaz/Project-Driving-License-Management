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
using static DVLD_BusinessLayer.clsDriverFilter;

namespace DVLD_PresentationLayer
{
    public partial class FOManageDrivers : Form
    {
        private static DataTable _DriversTable = clsDrivers.GetAllDrivers();

        public FOManageDrivers()
        {
            InitializeComponent();
        }
        private void _RefreshPeopleList()
        {
            _DriversTable = clsDrivers.GetAllDrivers();
            dGViewShowInformation.DataSource = _DriversTable;
            LblTotalRecoreds.Text = _DriversTable.Rows.Count.ToString();
        }
        //private void SMItemViewDetails_Click(object sender, EventArgs e)
        //{
        //    FODriverInfo frm = new FODriverInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
        //    frm.ShowDialog();
        //    _RefreshPeopleList();
        //}
        private void ApplyFilter()
        {
            if (_DriversTable == null) return;

            IDriverFilter filter = null;
            
            switch (CBFilterBy.SelectedItem.ToString())
            {

                case "Driver ID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        filter = new DriverIdFilter(id);
                    break;
                case "Person ID":
                    this.MTBsearch.Mask = "0000000000";
                    if (int.TryParse(MTBsearch.Text, out int Personid))
                        filter = new PersonIdFilter(Personid);
                    break;
                case "National No":
                    filter = new NationalNoFilter(MTBsearch.Text);
                    break;
                case "Full Name":
                    filter = new FullNameFilter(MTBsearch.Text);
                    break;
             
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_DriversTable)
                : new DataView(_DriversTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }
        private void FOManageDrivers_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            _RefreshPeopleList();
        }

        private void MTBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            MTBsearch.Visible = CBFilterBy.SelectedItem.ToString() != "None";
            ApplyFilter();
        }
    }
}
