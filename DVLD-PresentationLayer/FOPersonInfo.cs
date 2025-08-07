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
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class FOPersonInfo : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID;
        clsPerson _Person;
        public FOPersonInfo(int PersonID)
        {
            InitializeComponent();
            ctrDetailsPerson1.BorderStyle = BorderStyle.None;
            _PersonID = PersonID;
            if (_PersonID == -1)
                MessageBox.Show("please choose person to show Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                _Mode = enMode.Update;

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

            ctrDetailsPerson1.ValuePersonID = _Person.ID.ToString();
            ctrDetailsPerson1.FullName = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            ctrDetailsPerson1.NumberNationalNo = _Person.NationalNo;
            ctrDetailsPerson1.valueEmail = _Person.Email;
            ctrDetailsPerson1.valuePhone = _Person.Phone;
            ctrDetailsPerson1.valueAddress = _Person.Address;
            ctrDetailsPerson1.DateOfBrith = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            ctrDetailsPerson1.valueCountry = (clsCountry.Find(_Person.CountryID).CountryName);
            if (!string.IsNullOrEmpty(_Person.ImagePath))
                ctrDetailsPerson1.ImagePerson = Image.FromFile(_Person.ImagePath);
            else
                ctrDetailsPerson1.ImagePerson = null;
            ctrDetailsPerson1.TypeGender = _Person.PersonGender;
        }

        private void FOPersonInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void BtnAddSave_Click(object sender, EventArgs e)
        {

            if (ctrDetailsPerson1.ImagePath != null)
                _Person.ImagePath = ctrDetailsPerson1.ImagePath;

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
