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
        int _PerosnID;
        public FOAddEditPersonInfo(int PerosnID)
        {
            InitializeComponent();
            _PerosnID = PerosnID;

            if (_PerosnID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

        }
        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                LblAddEditPerson.Text = "Add New person";
                _PerosnID = new clsContact();
                return;
            }

            _PerosnID = clsContact.Find(_ContactID);

            if (_PerosnID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PerosnID);
                this.Close();

                return;
            }

            LblAddEditPerson.Text = "Update Person ";
            lblContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            txtAddress.Text = _Contact.Address;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "")
            {
                pictureBox1.Load(_Contact.ImagePath);
            }

            llRemoveImage.Visible = (_Contact.ImagePath != "");

            //this will select the country in the combobox.
            ctrDetailsPerson_Edit_Add_1.CountryComboBox.SelectedIndex = ctrDetailsPerson_Edit_Add_1.CountryComboBox.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

        }


        private void FOAddEditPersonInfo_Load(object sender, EventArgs e)
        {
            ctrDetailsPerson_Edit_Add_1.NationalNumberValidating += CtrDetailsPerson1_NationalNumberValidating;

        }
        private void CtrDetailsPerson1_NationalNumberValidating(object sender, CancelEventArgs e)
        {
            string nationalNo = ctrDetailsPerson_Edit_Add_1.NationalNo;

                errorProvider1.SetError(ctrDetailsPerson_Edit_Add_1.NationalNumberTextBox, "Gg");
                //e.Cancel = true;
        }

        
    }
}
