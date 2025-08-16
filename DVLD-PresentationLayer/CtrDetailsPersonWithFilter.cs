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
                    if (int.TryParse(MTBsearch.Text, out int id))
                        _Person = clsPerson.Find(id);
                    break;
                case "National No":
                    if (!string.IsNullOrWhiteSpace(MTBsearch.Text))
                        _Person = clsPerson.Find(MTBsearch.Text);
                    break;
            }
            MTBsearch.Text = "";
            if (_Person == null)
            {
                MessageBox.Show("No person found with the given criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            fOAddEditPersonInfo.ShowDialog();
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
            string selected = CBFindBy.SelectedItem.ToString();
            switch (selected)
            {
                case "Person ID":
                    MTBsearch.Mask = "000000";
                    MTBsearch.PromptChar = ' ';
                    MTBsearch.Visible = true;
                    break;

                case "National No":
                    MTBsearch.Mask = "";
                    MTBsearch.Visible = true;
                    break;

                case "None":
                    MTBsearch.Visible = false;
                    MTBsearch.Mask = "";
                    break;
            }
        }


        private void CtrDetailsPersonWithFilter_Load(object sender, EventArgs e)
        {
            CBFindBy.SelectedIndex = 0;
        }
    }
}
