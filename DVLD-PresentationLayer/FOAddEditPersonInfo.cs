using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static DVLD_BusinessLayer.clsCountry;
namespace DVLD_PresentationLayer
{
    public partial class FOAddEditPersonInfo : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID;
        clsPerson _Person;

        public FOAddEditPersonInfo()
        {
            InitializeComponent();
            int PersonID = -1;
            _PersonID = PersonID;

            if (_PersonID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }
        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                LblAddEditPerson.Text = "Add New person";
                _Person = new clsPerson();
                return;
            }

            _Person = clsPerson.Find(_PersonID);

            if (_PersonID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();

                return;
            }

            LblAddEditPerson.Text = "Update Person";
            LbNumberlPersonID.Text = _Person.ID.ToString();

            ctrDetailsPerson_Edit_Add_1.FirstName = _Person.FirstName;
            ctrDetailsPerson_Edit_Add_1.SecondName = _Person.SecondName;
            ctrDetailsPerson_Edit_Add_1.ThirdName = _Person.ThirdName;
            ctrDetailsPerson_Edit_Add_1.LastName = _Person.LastName;
            ctrDetailsPerson_Edit_Add_1.NationalNo = _Person.NationalNo;

            ctrDetailsPerson_Edit_Add_1.Email = _Person.Email;
            ctrDetailsPerson_Edit_Add_1.Phone = _Person.Phone;
            ctrDetailsPerson_Edit_Add_1.Address = _Person.Address;

            ctrDetailsPerson_Edit_Add_1.BirthDate = _Person.DateOfBirth;
            ctrDetailsPerson_Edit_Add_1.CountryComboBox.SelectedIndex = ctrDetailsPerson_Edit_Add_1.CountryComboBox.FindString(clsCountry.Find(_Person.CountryID).CountryName);

            if (!string.IsNullOrEmpty(_Person.ImagePath))
                ctrDetailsPerson_Edit_Add_1.PersonImage = Image.FromFile(_Person.ImagePath);
            else
                ctrDetailsPerson_Edit_Add_1.PersonImage = null;


            ctrDetailsPerson_Edit_Add_1.SelectedGender = _Person.PersonGender;
            //this will select the country in the combobox.
            ctrDetailsPerson_Edit_Add_1.CountryComboBox.SelectedIndex = ctrDetailsPerson_Edit_Add_1.CountryComboBox.FindString(clsCountry.Find(_Person.CountryID).CountryName);
        }


        private void FOAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            ctrDetailsPerson_Edit_Add_1.NationalNumberValidating += CtrDetailsPerson1_NationalNumberValidating;
            ctrDetailsPerson_Edit_Add_1.SaveButtonClick += CtrDetailsPerson1_SaveButtonClick;
        }
        private void CtrDetailsPerson1_NationalNumberValidating(object sender, CancelEventArgs e)
        {
            string nationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo;

                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "Gg");
                //e.Cancel = true;
        }
        private void CtrDetailsPerson1_SaveButtonClick(object sender, EventArgs e)
        {
            int countryID = clsCountry.Find(ctrDetailsPerson_Edit_Add_1.CountryComboBox.Text).ID;

            // تعبئة بيانات الـ Contact
            _Person.FirstName = ctrDetailsPerson_Edit_Add_1.FirstName;
            _Person.SecondName = ctrDetailsPerson_Edit_Add_1.SecondName;
            _Person.ThirdName = ctrDetailsPerson_Edit_Add_1.ThirdName;
            _Person.LastName = ctrDetailsPerson_Edit_Add_1.LastName;
            _Person.NationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo;
            _Person.Email = ctrDetailsPerson_Edit_Add_1.Email;
            _Person.Phone = ctrDetailsPerson_Edit_Add_1.Phone;
            _Person.Address = ctrDetailsPerson_Edit_Add_1.Address;
            _Person.DateOfBirth = ctrDetailsPerson_Edit_Add_1.BirthDate;
            _Person.CountryID = countryID;

            // أخذ قيمة الجندر من الـ UserControl
            _Person.PersonGender = ctrDetailsPerson_Edit_Add_1.SelectedGender;

            // معالجة الصورة
            _Person.ImagePath = ctrDetailsPerson_Edit_Add_1.ImagePath?? "";

            // حفظ البيانات
            if (_Person.Save())
            {
                MessageBox.Show("✅ Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.Update;
            }
            else
            {
                MessageBox.Show("❌ Error: Data was not saved successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
