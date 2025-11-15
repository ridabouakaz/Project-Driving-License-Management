using DVLD_BusinessLayer;
using DVLD_PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsApplications;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsDriverInternationalLicenseApplication : UserControl
    {
        private clsInternationalLicense _InternationalLicense;
        private int _InternationalLicenseID;
        public CtrDetailsDriverInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = clsInternationalLicense.Find(_InternationalLicenseID);
            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not find License ID = " + _InternationalLicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }
            InternationalLicenseData = _InternationalLicense;
        }
        public clsInternationalLicense SelectedLicenseInfo
        { get { return _InternationalLicense; } }
        public clsInternationalLicense InternationalLicenseData
        {
            get => _InternationalLicense;
            set
            {
                _InternationalLicense = value;
                FillUIFromPerson();
            }
        }
        private void FillUIFromPerson()
        {
            if (_InternationalLicense == null)
            {
                IntLicenseID = "[????????]";
                ApplicationID = "[????????]";
                LicenseID = "[????????]";
                IssueDate = "[????????]";
                ExpirationDate = "[????????]";
                LblvalueIsActive.Text = "[????????]";
                DriverID = "[????????]";
                NamePerson = "[????????]";
                NationalNo = "[????????]";
                DateOfBirth = "[????????]";
                LblValueGendor.Text = "[????????]";
                ImagePerson = null;
                return;
            }

            IntLicenseID = _InternationalLicense.InternationalLicenseID.ToString();
            ApplicationID = _InternationalLicense.ApplicationID.ToString();
            LicenseID = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            IssueDate = _InternationalLicense.IssueDate.ToString("dd/MM/yyyy");
            ExpirationDate = _InternationalLicense.ExpirationDate.ToString("dd/MM/yyyy");
            IsActive = _InternationalLicense.IsActive;
            NamePerson = _InternationalLicense.DriverInfo.PersonInfo.FullName;
            NationalNo = _InternationalLicense.DriverInfo.PersonInfo.NationalNo;
            DateOfBirth = _InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            DriverID= _InternationalLicense.DriverID.ToString();
            Gender = _InternationalLicense.DriverInfo.PersonInfo.PersonGender;
            if (!string.IsNullOrEmpty(_InternationalLicense.DriverInfo.PersonInfo.ImagePath) && File.Exists(_InternationalLicense.DriverInfo.PersonInfo.ImagePath))
            {
                PBImagePerson.ImageLocation = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;
            }
            else
            {
                ImagePerson = null;
            }
        }
        public string NamePerson
        {
            set => LblValueNameperson.Text = value;
        }
        public string IntLicenseID
        {
            set => LblValueIntLicenseID.Text = value;
        }
        public string LicenseID
        {
            set => LblValueLicenseID.Text = value;
        }
        public string NationalNo
        {
            set => LblValueNationalNo.Text = value;
        }

        public Gender Gender
        {
            set
            {
                if (value == Gender.Male)
                    LblValueGendor.Text = "Male";
                else
                    LblValueGendor.Text = "Female";
            }
        }
        public string IssueDate
        {
            set => LblValueIssueDate.Text = value;
        }
        public string ApplicationID
        {
            set => LblvalueApplicationID.Text = value;
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

        public string DateOfBirth
        {
            set => LblvalueDateOfBirth.Text = value;
        }
        public string DriverID
        {
            set => LblvalueDriverID.Text = value;
        }
        public string ExpirationDate
        {
            set => LblvalueExpirationDate.Text = value;
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
    }
}
