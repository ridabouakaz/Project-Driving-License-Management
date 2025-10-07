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
                LblvalueGender.Text = "[????????]";
                Class = "[????????]";
                IssueDate = "[????????]";
                ExpirationDate = "[????????]";
                LblvalueIsActive.Text = "[????????]";
                IsDetained = "[????????]";
                LblvalueIssueReason.Text = "[????????]";
                Notes = "[????????]";
                ImagePerson = null;
                return;
            }

            LicenseID = _License.LicenseID.ToString();
            DriverID = _License.DriverID.ToString();
            FullName = _License.Person.FullName;
            NationalNo = _License.Person.NationalNo;
            DateOfBirth = _License.Person.DateOfBirth.ToString("dd/MM/yyyy");
            Gender = _License.Person.PersonGender;
            Class = clsLicenses.GetClassNameById(_License.LicenseClass);
            IssueDate = _License.IssueDate.ToString("dd/MM/yyyy");
            ExpirationDate = _License.ExpirationDate.ToString("dd/MM/yyyy");
            IsActive = _License.IsActive;
            IsDetained = "No";
            IssueReason = _License.IssueReason;
            Notes = _License.Notes;
            if (!string.IsNullOrEmpty(_License.Person.ImagePath) && File.Exists(_License.Person.ImagePath))
            {
                PBImagePerson.ImageLocation = _License.Person.ImagePath;
            }
            else
            {
                ImagePerson = null;
            }
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
        public Gender Gender
        {
            set
            {
                if (value == Gender.Male)
                    LblvalueGender.Text = "Male";
                else
                    LblvalueGender.Text = "Female";
            }
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
      
        public ActiveStatus IsActive
        {
            set
            {
                if (value == ActiveStatus.Yes)
                    LblvalueIsActive.Text = "Yes";
                else
                    LblvalueIsActive.Text = "No";
            }
        }

        public string IsDetained
        {
            get => LblvalueIsDetained.Text;
            set => LblvalueIsDetained.Text = value;
        }

        public IssueReason IssueReason
        {
            set
            {

                if (value == IssueReason.FirstTime)
                    LblvalueIssueReason.Text = "FirstTime";
                else if (value == IssueReason.Renew)
                    LblvalueIssueReason.Text = "Renew";
                else if (value == IssueReason.ReplacementforDamaged)
                    LblvalueIssueReason.Text = "ReplacementforDamaged";
                else
                    LblvalueIssueReason.Text = "ReplacementforLost";
            }
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
