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
using static DVLD_BusinessLayer.clsUserFilter.UserFilterService;
using static DVLD_BusinessLayer.PersonFilterService;

namespace DVLD_PresentationLayer
{
    public partial class FOManageUsers : Form
    {
        private static DataTable _UsersTable = clsUser.GetAllUsers();

        public FOManageUsers()
        {
            InitializeComponent();
        }
        private void _RefreshPeopleList()
        {
            _UsersTable = clsUser.GetAllUsers();
            dGViewShowInformation.DataSource = _UsersTable;
            LblTotalRecoreds.Text = _UsersTable.Rows.Count.ToString();
        }
        private void SMItemViewDetails_Click(object sender, EventArgs e)
        {
            FOUserInfo frm = new FOUserInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemAddUser_Click(object sender, EventArgs e)
        {
            FOAddEditUserInfo frm = new FOAddEditUserInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemEditUser_Click(object sender, EventArgs e)
        {
            FOAddEditUserInfo frm = new FOAddEditUserInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + dGViewShowInformation.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsUser.DeleteUsers((int)dGViewShowInformation.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("User is not deleted.");

            }
        }
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            FOAddEditUserInfo frm = new FOAddEditUserInfo();
            frm.ShowDialog();
            _RefreshPeopleList();
        }
        private void SMItemChangePasswordUser_Click(object sender, EventArgs e)
        {
            FOChangePasswordUser frm = new FOChangePasswordUser((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }


        private void ApplyFilter()
        {
            if (_UsersTable == null) return;

            IUserFilter filter = null;
            
            switch (CBFilterBy.SelectedItem.ToString())
            {

                case "User ID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        filter = new UserIdFilter(id);
                    break;
                case "User Name":
                    this.MTBsearch.Mask = "";
                    filter = new UserNameFilter(MTBsearch.Text);
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
                ? filter.ApplyFilter(_UsersTable)
                : new DataView(_UsersTable);

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
        private void FOManageUsers_Load(object sender, EventArgs e)
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
