using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static DVLD_BusinessLayer.PersonFilterService;
namespace DVLD_PresentationLayer
{
    public partial class FOManagePeople : Form
    {
        private DataTable _peopleTable;

        public FOManagePeople()
        {
            InitializeComponent();
        }

        private void _RefreshPeopleList()
        {
            DataTable _peopleTable = clsPerson.GetAllPeople();
            dGViewShowInformation.DataSource = _peopleTable;
            LblTotalRecoreds.Text = _peopleTable.Rows.Count.ToString();
        }

        private void FOManagePeople_Load(object sender, EventArgs e)
        {
            CBFilterBy.SelectedIndex = 0;
            _RefreshPeopleList();

        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo(-1);
            frm.ShowDialog();
            _RefreshPeopleList();
            
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SMItemEditPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemAddPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo(-1);
            frm.ShowDialog();
            _RefreshPeopleList();

        }

        private void SMItemDeletePerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete person [" + dGViewShowInformation.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsPerson.DeletePeople((int)dGViewShowInformation.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("person Deleted Successfully.");
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("person is not deleted.");

            }
        }

        private void CBFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            TBsearch.Visible = CBFilterBy.SelectedItem.ToString() != "None";
            ApplyFilter();
        }

        private void TBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void ApplyFilter()
        {
            if (_peopleTable == null) return;

            IPersonFilter filter = null;

            switch (CBFilterBy.SelectedItem.ToString())
            {
                case "Person ID":
                    if (int.TryParse(TBsearch.Text, out int id))
                        filter = new PersonIdFilter(id);
                    break;
                case "National No":
                    filter = new NationalNoFilter(TBsearch.Text);
                    break;
                case "First Name":
                    filter = new FirstNameFilter(TBsearch.Text);
                    break;
                case "Second Name":
                    filter = new SecondNameFilter(TBsearch.Text);
                    break;
                case "Third Name":
                    filter = new ThirdNameFilter(TBsearch.Text);
                    break;
                case "Last Name":
                    filter = new LastNameFilter(TBsearch.Text);
                    break;
                case "Nationality":
                    filter = new CountryFilter(TBsearch.Text);
                    break;
                case "Gender":
                    filter = new GenderFilter(TBsearch.Text);
                    break;
                case "Phone":
                    filter = new PhoneFilter(TBsearch.Text);
                    break;
                case "Email":
                    filter = new EmailFilter(TBsearch.Text);
                    break;
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_peopleTable)
                : new DataView(_peopleTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }
    }
}
