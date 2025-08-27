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
using DVLD_BusinessLayer;
using DVLDShared;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class FOPersonInfo : Form
    {
        public enum enMode {Update = 1 };
        private enMode _Mode;
        int _PersonID;
        clsPerson _Person;
        public FOPersonInfo(int PersonID)
        {
             InitializeComponent();
            ctrDetailsPerson1.BorderStyle = BorderStyle.None;
            _PersonID = PersonID;
            _Mode = enMode.Update;
            _LoadData();
        }
        private void _LoadData()
        { 
            _Person = clsPerson.Find(_PersonID);

            if (_PersonID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();

                return;
            }
            ctrDetailsPerson1.PersonData= _Person;
        }
        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            string tempImagePath = _Person.ImagePath;
            if (!clsUtil.HandlePersonImage(ref tempImagePath, ctrDetailsPerson1.ImagePath))
            {
                MessageBox.Show("❌ Error: Handle Person Image was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _Person.ImagePath = tempImagePath;
            if (_Person.Save())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
