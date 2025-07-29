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
namespace DVLD_PresentationLayer
{
    public partial class FOManagePeople : Form
    {
        public FOManagePeople()
        {
            InitializeComponent();
        }
        private void _RefreshPeopleList()
        {
            dGViewShowInformation.DataSource = clsPerson.GetAllPeople();
        }
  
     
        private void SMItemEditPerson_Click(object sender, EventArgs e)
        {

            FOAddEditPersonInfo frm = new FOAddEditPersonInfo((int)dGViewShowInformation.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void SMItemDeletePerson_Click(object sender, EventArgs e)
        {

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
    }
}
