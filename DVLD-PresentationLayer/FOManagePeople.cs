using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
          
            this.Size = new Size(1400, 650);

        }
        private void _RefreshPeopleList()
        {
            _peopleTable = clsPerson.GetAllPeople();
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
            FOAddEditPersonInfo frm = new FOAddEditPersonInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
            
        }

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SMItemViewDetails_Click(object sender, EventArgs e)
        {
            FOPersonInfo frm = new FOPersonInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
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
                File.Delete(clsPerson.ReturnPathDeletePeople((int)dGViewShowInformation.CurrentRow.Cells[0].Value));
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

            MTBsearch.Visible = CBFilterBy.SelectedItem.ToString() != "None";
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_peopleTable == null) return;

            IPersonFilter filter = null;

            switch (CBFilterBy.SelectedItem.ToString())
            {
                case "Person ID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        filter = new PersonIdFilter(id);
                    break;
                case "National No":
                    this.MTBsearch.Mask = "";
                    filter = new NationalNoFilter(MTBsearch.Text);
                    break;
                case "First Name":
                    this.MTBsearch.Mask = "";
                    filter = new FirstNameFilter(MTBsearch.Text);
                    break;
                case "Second Name":
                    this.MTBsearch.Mask = "";
                    filter = new SecondNameFilter(MTBsearch.Text);
                    break;
                case "Third Name":
                    this.MTBsearch.Mask = "";
                    filter = new ThirdNameFilter(MTBsearch.Text);
                    break;
                case "Last Name":
                    this.MTBsearch.Mask = "";
                    filter = new LastNameFilter(MTBsearch.Text);
                    break;
                case "Nationality":
                    this.MTBsearch.Mask = "";
                    filter = new CountryFilter(MTBsearch.Text);
                    break;
                case "Gender":
                    this.MTBsearch.Mask = "";
                    filter = new GenderFilter(MTBsearch.Text);
                    break;
                case "Phone":
                    this.MTBsearch.Mask = "0000000000";
                    this.MTBsearch.PromptChar = ' ';
                    this.MTBsearch.SkipLiterals = true;

                    filter = new PhoneFilter(MTBsearch.Text);
                    break;
                case "Email":
                    this.MTBsearch.Mask = "";
                    filter = new EmailFilter(MTBsearch.Text);
                    break;
            }

            DataView view = (filter != null)
                ? filter.ApplyFilter(_peopleTable)
                : new DataView(_peopleTable);

            dGViewShowInformation.DataSource = view;
            LblTotalRecoreds.Text = view.Count.ToString();
        }
        private void MTBsearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }

      
    }
}
