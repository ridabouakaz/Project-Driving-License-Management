using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static DVLD_BusinessLayer.clsCountry;
namespace DVLD_PresentationLayer
{
    public partial class FOAddEditPersonInfo : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _PersonID;
        clsPerson _Person;

        public FOAddEditPersonInfo(int PersonID)
        {
            InitializeComponent();
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
            ctrDetailsPerson_Edit_Add_1.FirstNameValidating += CtrDetailsPerson1_FirstName_Validating;
            ctrDetailsPerson_Edit_Add_1.SecondNameValidating += CtrDetailsPerson1_SecondName_Validating;
            ctrDetailsPerson_Edit_Add_1.ThirdNameValidating += CtrDetailsPerson1_ThirdName_Validating;
            ctrDetailsPerson_Edit_Add_1.LastNameValidating += CtrDetailsPerson1_LastName_Validating;

            ctrDetailsPerson_Edit_Add_1.NationalNumberValidating += CtrDetailsPerson1_NationalNumberValidating;
            ctrDetailsPerson_Edit_Add_1.EmailValidating += CtrDetailsPerson1_Email_Validating;
            ctrDetailsPerson_Edit_Add_1.SaveButtonClick += CtrDetailsPerson1_SaveButtonClick;
            ctrDetailsPerson_Edit_Add_1.CloseButtonClick += CtrDetailsPerson1_CloseButtonClick;
            _LoadData();
        }
        private void CtrDetailsPerson1_FirstName_Validating(object sender, CancelEventArgs e)
        {
            string FirstName = ctrDetailsPerson_Edit_Add_1.FirstName.Trim();

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                e.Cancel = true; // يمنع مغادرة الـ TextBox
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.FirstNameTextBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.FirstNameTextBox, "");
            }
        }
        private void CtrDetailsPerson1_SecondName_Validating(object sender, CancelEventArgs e)
        {
            string SecondName = ctrDetailsPerson_Edit_Add_1.SecondName.Trim();

            if (string.IsNullOrWhiteSpace(SecondName))
            {
                e.Cancel = true; // يمنع مغادرة الـ TextBox
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.SecondNameTextBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.SecondNameTextBox, "");
            }
        }
        private void CtrDetailsPerson1_ThirdName_Validating(object sender, CancelEventArgs e)
        {
            string ThirdName = ctrDetailsPerson_Edit_Add_1.ThirdName.Trim();

            if (string.IsNullOrWhiteSpace(ThirdName))
            {
                e.Cancel = true; // يمنع مغادرة الـ TextBox
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.ThirdNameTextBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.ThirdNameTextBox, "");
            }
        }
        private void CtrDetailsPerson1_LastName_Validating(object sender, CancelEventArgs e)
        {
            string LastName = ctrDetailsPerson_Edit_Add_1.LastName.Trim();

            if (string.IsNullOrWhiteSpace(LastName))
            {
                e.Cancel = true; // يمنع مغادرة الـ TextBox
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.LastNameTextBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.LastNameTextBox, "");
            }
        }
        private void CtrDetailsPerson1_Email_Validating(object sender, CancelEventArgs e)
        {
            string email = ctrDetailsPerson_Edit_Add_1.Email.Trim();
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern))
            {
                e.Cancel = true; // يمنع مغادرة الـ TextBox
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.EmailTextBox, "Please enter a valid email address");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.EmailTextBox, "");
            }
        }
        private void CtrDetailsPerson1_NationalNumberValidating(object sender, CancelEventArgs e)
        {
            string nationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo;
            if (clsPerson.isNationalNumberExist(nationalNo)|| string.IsNullOrWhiteSpace(nationalNo))
            {
                e.Cancel = true;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "Please enter a valid National Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "");
            }
        }
        private void CtrDetailsPerson1_SaveButtonClick(object sender, EventArgs e)
        {
            int countryID = clsCountry.Find(ctrDetailsPerson_Edit_Add_1.CountryComboBox.Text).ID;
            if (ctrDetailsPerson_Edit_Add_1.FirstName=="" || ctrDetailsPerson_Edit_Add_1.SecondName == "" || ctrDetailsPerson_Edit_Add_1.ThirdName == "" || ctrDetailsPerson_Edit_Add_1.LastName == ""
                || ctrDetailsPerson_Edit_Add_1.NationalNo == "")
            {

                MessageBox.Show("❌ Error: Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
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

            _Person.PersonGender = ctrDetailsPerson_Edit_Add_1.SelectedGender;
            if (ctrDetailsPerson_Edit_Add_1.ImagePath != null)
                _Person.ImagePath = ctrDetailsPerson_Edit_Add_1.ImagePath;
            else
                _Person.ImagePath = "";
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
        private void CtrDetailsPerson1_CloseButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
