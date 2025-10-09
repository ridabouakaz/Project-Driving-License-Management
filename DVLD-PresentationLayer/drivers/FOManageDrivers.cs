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
using static DVLD_BusinessLayer.clsDriverFilter.DriverFilterService;
using static DVLD_BusinessLayer.PersonFilterService;

namespace DVLD_PresentationLayer
{
    public partial class FOManageDrivers : Form
    {
        private static DataTable _DriversTable = clsDriver.GetAllDrivers();

        public FOManageDrivers()
        {
            InitializeComponent();
        }
        private void _RefreshPeopleList()
        {
            _DriversTable = clsDriver.GetAllDrivers();
            dGViewShowInformation.DataSource = _DriversTable;
            LblTotalRecoreds.Text = _DriversTable.Rows.Count.ToString();
        }
        private void SMItemViewDetails_Click(object sender, EventArgs e)
        {
            FODriverInfo frm = new FODriverInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemAddDriver_Click(object sender, EventArgs e)
        {
            FOAddEditDriverInfo frm = new FOAddEditDriverInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemEditDriver_Click(object sender, EventArgs e)
        {
            FOAddEditDriverInfo frm = new FOAddEditDriverInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemDeleteDriver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Driver [" + dGViewShowInformation.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsDriver.DeleteDrivers((int)dGViewShowInformation.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Driver Deleted Successfully.");
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("Driver is not deleted.");

            }
        }
        private void BtnAddDriver_Click(object sender, EventArgs e)
        {
            FOAddEditDriverInfo frm = new FOAddEditDriverInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void SMItemChangePasswordDriver_Click(object sender, EventArgs e)
        {
            FOChangePasswordDriver frm = new FOChangePasswordDriver((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }


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
                case "Driver Name":
                    this.MTBsearch.Mask = "";
                    filter = new DriverNameFilter(MTBsearch.Text);
                    break;
                case "Person ID":
                    this.MTBsearch.Mask = "0000000000";
                    this.MTBsearch.PromptChar = ' ';
                    this.MTBsearch.SkipLiterals = true;
                    if (int.TryParse(MTBsearch.Text, out int Personid))
                        filter = new IdPersonFilter(Personid);
                    break;
                case "Full Name":
                    this.MTBsearch.Mask = "";
                    filter = new FullNameFilter(MTBsearch.Text);
                    break;
                case "Is ActiveStatus":
                    this.MTBsearch.Mask = "";
                    filter = new ActiveStatusFilter(CBActiveStatusBy.SelectedItem.ToString());
                    break;
             
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_DriversTable)
                : new DataView(_DriversTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = CBFilterBy.SelectedItem.ToString();

            if (selected == "Is ActiveStatus")
            {
                MTBsearch.Visible = false;
                CBActiveStatusBy.Visible = true;
            }
            else if (selected == "None")
            {
                MTBsearch.Visible = false;
                CBActiveStatusBy.Visible = false;
            }
            else
            {
                MTBsearch.Visible = true;
                CBActiveStatusBy.Visible = false;
            }
            ApplyFilter();
        }
        private void FOManageDrivers_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            CBActiveStatusBy.SelectedIndex = 0;
            _RefreshPeopleList();
        }

        private void MTBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void CBActiveStatusBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
