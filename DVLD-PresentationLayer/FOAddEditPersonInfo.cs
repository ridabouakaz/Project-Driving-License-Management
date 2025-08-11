using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static DVLD_BusinessLayer.clsCountry;
using DVLDShared;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.Management;
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
            _Mode = enMode.Update;
            _LoadData();

        }
        public FOAddEditPersonInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            LblAddEditPerson.Text = "Add New person";
            _Person = new clsPerson();
            return;
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
            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                using (var fs = new FileStream(_Person.ImagePath, FileMode.Open, FileAccess.Read))
                {
                    ctrDetailsPerson_Edit_Add_1.PersonImage = Image.FromStream(fs);
                }
            }
            else
            {
                ctrDetailsPerson_Edit_Add_1.PersonImage = null;
            }


            ctrDetailsPerson_Edit_Add_1.SelectedGender = _Person.PersonGender;

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
        }
        private void ValidateRequiredField(string value, TextBox textBox, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox, "Please enter a value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }
        private void CtrDetailsPerson1_FirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(ctrDetailsPerson_Edit_Add_1.FirstName, ctrDetailsPerson_Edit_Add_1.FirstNameTextBox, e);
        }
        private void CtrDetailsPerson1_SecondName_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(ctrDetailsPerson_Edit_Add_1.SecondName, ctrDetailsPerson_Edit_Add_1.SecondNameTextBox, e);

        }
        private void CtrDetailsPerson1_ThirdName_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(ctrDetailsPerson_Edit_Add_1.ThirdName, ctrDetailsPerson_Edit_Add_1.ThirdNameTextBox, e);

        }
        private void CtrDetailsPerson1_LastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(ctrDetailsPerson_Edit_Add_1.LastName, ctrDetailsPerson_Edit_Add_1.LastNameTextBox, e);

        }
        private void CtrDetailsPerson1_Email_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidatoin.ValidateEmail(ctrDetailsPerson_Edit_Add_1.Email.Trim()))
            {
                e.Cancel = true; 
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
            if (clsPerson.isNationalNumberExist(nationalNo) || string.IsNullOrWhiteSpace(nationalNo))
            {
                if (ctrDetailsPerson_Edit_Add_1.NationalNo == _Person.NationalNo)
                    return;
                e.Cancel = true;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "Please enter a valid National Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "");
            }
        }

        private bool _HandlePersonImage()
        {
            if (_Person.ImagePath != ctrDetailsPerson_Edit_Add_1.ImagePath)
            {
                if (_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {

                        throw;
                    }
                }
            }
            if (ctrDetailsPerson_Edit_Add_1.ImagePath != null)
            {
                string SourceImageFill = ctrDetailsPerson_Edit_Add_1.ImagePath;
                if (clsUtil.copyImageToProjectImagesFolder(ref SourceImageFill))
                {
                    ctrDetailsPerson_Edit_Add_1.ImagePath = SourceImageFill;
                    return true;
                }
                else
                {
                    MessageBox.Show("❌ Error: Image could not be copied to the project folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return true; 
        }
        private void CtrDetailsPerson1_SaveButtonClick(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("❌ Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!_HandlePersonImage())
            {
                return;
            }
            int countryID = clsCountry.Find(ctrDetailsPerson_Edit_Add_1.CountryComboBox.Text).ID;
            _Person.FirstName = ctrDetailsPerson_Edit_Add_1.FirstName.Trim();
            _Person.SecondName = ctrDetailsPerson_Edit_Add_1.SecondName.Trim();
            _Person.ThirdName = ctrDetailsPerson_Edit_Add_1.ThirdName.Trim();
            _Person.LastName = ctrDetailsPerson_Edit_Add_1.LastName.Trim();
            _Person.NationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo.Trim();
            _Person.Email = ctrDetailsPerson_Edit_Add_1.Email.Trim();
            _Person.Phone = ctrDetailsPerson_Edit_Add_1.Phone.Trim();
            _Person.Address = ctrDetailsPerson_Edit_Add_1.Address.Trim();
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
