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
                LicenseID = "[????????]";
                DriverID = "[????????]";
                FullName = "[????????]";
                NationalNo = "[????????]";
                DateOfBirth = "[????????]";
                Gender = "[????????]";
                Class = "[????????]";
                IssueDate = "[????????]";
                ExpirationDate = "[????????]";
                IsActive = "[????????]";
                IsDetained = "[????????]";
                IssueReason = "[????????]";
                Notes = "[????????]";
                ImagePerson = null;
                return;
            }

            LicenseID = _License.LicenseID.ToString();
            DriverID = _License.ID.ToString();
            FullName = $"{_License.FirstName} {_License.SecondName} {_License.ThirdName} {_License.LastName}";
            NationalNo = _License.NationalNo;
            DateOfBirth = _License.DateOfBirth.ToString("dd/MM/yyyy");
            Gender = _License.PersonGender;
            Class = clsLicenseClass.Find(_License.LicenseClassID).ClassName;  // مثال: لازم يكون عندك كلاس للـ Class
            IssueDate = _License.IssueDate.ToString("dd/MM/yyyy");
            ExpirationDate = _License.ExpirationDate.ToString("dd/MM/yyyy");
            IsActive = _License.IsActive ? "Yes" : "No";
            IsDetained = _License.IsDetained ? "Yes" : "No";
            IssueReason = _License.IssueReason;
            Notes = _License.Notes;

            if (!string.IsNullOrEmpty(_License.ImagePath) && File.Exists(_License.ImagePath))
                ImagePath = _License.ImagePath;
            else
                ImagePerson = null;
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

        public string LicenseID
        {
            get => LblNumberLicenseID.Text;
            set => LblNumberLicenseID.Text = value;
        }

        public string DriverID
        {
            get => LblvalueDriverID.Text;
            set => LblvalueDriverID.Text = value;
        }

        public string FullName
        {
            get => LblFullName.Text;
            set => LblFullName.Text = value;
        }

        public string NationalNo
        {
            get => LblValueNationalNo.Text;
            set => LblValueNationalNo.Text = value;
        }

        public string DateOfBirth
        {
            get => LblvalueDateOfBirth.Text;
            set => LblvalueDateOfBirth.Text = value;
        }

        public string Gender
        {
            get => LblvalueGender.Text;
            set => LblvalueGender.Text = value;
        }

        public string Class
        {
            get => LblValueClass.Text;
            set => LblValueClass.Text = value;
        }

        public string IssueDate
        {
            get => LblvalueIssueDate.Text;
            set => LblvalueIssueDate.Text = value;
        }

        public string ExpirationDate
        {
            get => LblvalueExpirationDate.Text;
            set => LblvalueExpirationDate.Text = value;
        }

        public string IsActive
        {
            get => LblvalueIsActive.Text;
            set => LblvalueIsActive.Text = value;
        }

        public string IsDetained
        {
            get => LblvalueIsDetained.Text;
            set => LblvalueIsDetained.Text = value;
        }

        public string IssueReason
        {
            get => LblvalueIssueReason.Text;
            set => LblvalueIssueReason.Text = value;
        }

        public string Notes
        {
            get => LblvalueNotes.Text;
            set => LblvalueNotes.Text = value;
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
