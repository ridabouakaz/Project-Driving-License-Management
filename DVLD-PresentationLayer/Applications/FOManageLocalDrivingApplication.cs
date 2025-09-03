using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.LocalDrivingApplicationFilter.LocalDrivingApplicationFilterService;
using static DVLD_BusinessLayer.PersonFilterService;
namespace DVLD_PresentationLayer
{
    public partial class FOManageLocalDrivingApplication : Form
    {
        private static DataTable _LocalDrivingApplicationsTable = clsNewLocalDrivingApplication.GetAllLocalDrivingApplications();
        public FOManageLocalDrivingApplication()
        {
            InitializeComponent();
          
            this.Size = new Size(1400, 650);

        }
        private void _RefreshLocalDrivingApplicationsList()
        {
            _LocalDrivingApplicationsTable = clsNewLocalDrivingApplication.GetAllLocalDrivingApplications();
            dGViewShowInformation.DataSource = _LocalDrivingApplicationsTable;
            LblTotalRecoreds.Text = _LocalDrivingApplicationsTable.Rows.Count.ToString();
        }



        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
            
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SMItemViewDetails_Click(object sender, EventArgs e)
        {
            FOPersonInfo frm = new FOPersonInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }
        private void SMItemEditPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();
        }

        private void SMItemAddPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshLocalDrivingApplicationsList();

        }

        private void SMItemDeletePerson_Click(object sender, EventArgs e)
        {
     
        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selected = CBFilterBy.SelectedItem.ToString();

            if (selected == "Status")
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

        private void ApplyFilter()
        {
            if (_LocalDrivingApplicationsTable == null) return;

            ILocalDrivingApplicationFilter filter = null;

            switch (CBFilterBy.SelectedItem.ToString())
            {
                case "L.D.LAppID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        filter = new LDLAppIDFilter(id);
                    break;
                case "National No":
                    this.MTBsearch.Mask = "";
                    filter = new NationalNoLDLFilter(MTBsearch.Text);
                    break;
                case "Full Name":
                    this.MTBsearch.Mask = "";
                    filter = new FullNameFilter(MTBsearch.Text);
                    break;

                case "Status":
                    this.MTBsearch.Mask = "";
                    filter = new ActiveStatusFilter(CBActiveStatusBy.SelectedItem.ToString());
                    break;
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_LocalDrivingApplicationsTable)
                : new DataView(_LocalDrivingApplicationsTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }
        private void MTBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void FOManageLocalDrivingApplication_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            CBActiveStatusBy.SelectedIndex = 0;
            _RefreshLocalDrivingApplicationsList();
        }

        private void CBActiveStatusBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }
    }
}
