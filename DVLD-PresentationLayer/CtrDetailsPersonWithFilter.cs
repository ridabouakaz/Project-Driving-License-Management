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
    public partial class CtrDetailsPersonWithFilter : UserControl
    {

        private clsPerson _Person;

        private void ApplyFind()
        {
            
            switch (CBFindBy.SelectedItem.ToString())
            {
                case "Person ID":
                    this.MTBsearch.Mask = "000000";
                    this.MTBsearch.PromptChar = ' ';
                    if (int.TryParse(MTBsearch.Text, out int id))
                        _Person = clsPerson.Find(id);
                    break;
                case "National No":
                    this.MTBsearch.Mask = "";
                    _Person = clsPerson.Find(MTBsearch.Text);
                    break;
            }
            if (_Person == null)
            {
                MessageBox.Show("No person found with the given criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ctrDetailsPerson1.PersonData = _Person;
        }
        public CtrDetailsPersonWithFilter()
        {
            InitializeComponent();
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            FOAddEditPersonInfo fOAddEditPersonInfo = new FOAddEditPersonInfo();
            fOAddEditPersonInfo.DataBack += FOAddEditPersonInfo_DataBack;
        }
        private void FOAddEditPersonInfo_DataBack(object sender, int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            ctrDetailsPerson1.PersonData = _Person;
        }
        private void BtnSearchPerson_Click(object sender, EventArgs e)
        {
            ApplyFind();
        }

        private void CBFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            MTBsearch.Visible = CBFindBy.SelectedItem.ToString() != "None";
            ApplyFind();
        }
        private void CBFindBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFind();

        }

        private void CtrDetailsPersonWithFilter_Load(object sender, EventArgs e)
        {
            CBFindBy.SelectedIndex = 0;
        }
    }
}
