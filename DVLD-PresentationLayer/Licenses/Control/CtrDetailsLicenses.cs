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
    public partial class CtrDetailsLicenses : UserControl
    {
        private clsLicenses _License;

        public CtrDetailsLicenses()
        {
            InitializeComponent();
        }
        public clsLicenses PersonData
        {
            get => _License;
            set
            {
                _License = value;
                FillUIFromPerson();
            }
        }
        private void FillUIFromPerson()
        {
            if (_License == null)
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
                LblValueNationalNo.Text = "[????????]";
                return;
            }
            ValuePersonID = _License.ID.ToString();
            FullName = _License.FirstName + " " + _License.SecondName + " " + _License.ThirdName + " " + _License.LastName;
            NumberNationalNo = _License.NationalNo;
            valueEmail = _License.Email;
            valuePhone = _License.Phone;
            valueAddress = _License.Address;
            DateOfBrith = _License.DateOfBirth.ToString("dd/MM/yyyy");
            valueCountry = (clsCountry.Find(_License.CountryID).CountryName);
            if (!string.IsNullOrEmpty(_License.ImagePath) && File.Exists(_License.ImagePath))
            {
                    PBImagePerson.ImageLocation = _License.ImagePath;
            }
            else
            {
                ImagePerson = null;
            }
            TypeGender = _License.PersonGender;
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
                    LblValueNationalNo.Text = "Male";
                else
                    LblValueNationalNo.Text = "Female";
            }
        }
        public string NumberNationalNo
        {
            set => LblNumberLicenseID.Text = value;
        }
        public string valueEmail
        {
            set => LblvalueGender.Text = value;
        }
        public string valueAddress
        {
            set => LblvalueIssueDate.Text = value;
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
            set => LblValueClass.Text = value;
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
