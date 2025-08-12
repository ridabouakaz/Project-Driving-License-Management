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
using DVLD_PresentationLayer;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsPerson : UserControl
    {
        private clsPerson _Person;

        public CtrDetailsPerson()
        {
            InitializeComponent();
        }
        public clsPerson PersonData
        {
            get => _Person;
            set
            {
                _Person = value;
                FillUIFromPerson();
            }
        }
        private void FillUIFromPerson()
        {
            if (_Person == null)
            {
                ValuePersonID = "[????????]";
                FullName = "[????????]";
                NumberNationalNo = "[????????]";
                valueEmail = "[????????]";
                valuePhone = "[????????]";
                valueAddress = "[????????]";
                DateOfBrith = "[????????]";
                valueCountry = "[????????]";
                ImagePerson = null;
                LblTypeGender.Text = "[????????]";
                return;
            }
            ValuePersonID = _Person.ID.ToString();
            FullName = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            NumberNationalNo = _Person.NationalNo;
            valueEmail = _Person.Email;
            valuePhone = _Person.Phone;
            valueAddress = _Person.Address;
            DateOfBrith = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            valueCountry = (clsCountry.Find(_Person.CountryID).CountryName);
            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
            {
                    PBImagePerson.ImageLocation = _Person.ImagePath;
            }
            else
            {
                ImagePerson = null;
            }
            TypeGender = _Person.PersonGender;
        }
        public string FullName
        {
            set => LblFullName.Text = value;
        }
        public Gender TypeGender
        {
            set
            {
                if (value == Gender.Male)
                    LblTypeGender.Text = "Male";
                else
                    LblTypeGender.Text = "Female";
            }
        }
        public string NumberNationalNo
        {
            set => LblNumberNationalNo.Text = value;
        }
        public string valueEmail
        {
            set => LblvalueEmail.Text = value;
        }
        public string valueAddress
        {
            set => LblvalueAddress.Text = value;
        }
        public string DateOfBrith
        {
            set => LblvalueDateOfBrith.Text = value;
        }
        public string valuePhone
        {
            set => LblvaluePhone.Text = value;
        }
        public string valueCountry
        {
            set => LblvalueCountry.Text = value;
        }
        public string ValuePersonID
        {
            set => LblValuePersonID.Text = value;
        }
        public string ImagePath
        {
            get => PBImagePerson.ImageLocation;
            set => PBImagePerson.ImageLocation = value;
        }
        public Image ImagePerson
        {
            set => PBImagePerson.Image = value;
        }

        private void LLEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OFDialogPictureImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            OFDialogPictureImage.FilterIndex = 1;
            OFDialogPictureImage.RestoreDirectory = true;

            if (OFDialogPictureImage.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = OFDialogPictureImage.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                PBImagePerson.Load(selectedFilePath);
                // ...
            }
        }

    }
}
