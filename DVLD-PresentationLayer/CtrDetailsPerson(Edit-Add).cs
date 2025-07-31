using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using DVLDShared;
using static DVLDShared.DVLDShared;
namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsPerson_Edit_Add_ : UserControl
    {
        public CtrDetailsPerson_Edit_Add_()
        {
            InitializeComponent();
        }

        public string ImagePath
        {
            get => PBImagePerson.ImageLocation;
            set => PBImagePerson.ImageLocation = value;
        }
        public Image PersonImage
        {
            get { return PBImagePerson.Image; }
            set { PBImagePerson.Image = value; }
        }
        public Image UserImage { get; private set; }
        private void LLSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        public string FirstName
        {
            get => TBFirstName.Text.Trim();
            set => TBFirstName.Text = value;
        }
        public TextBox FirstNameTextBox => TBFirstName;

        public string SecondName
        {
            get => TBSecondName.Text.Trim();
            set => TBSecondName.Text = value;
        }
        public TextBox SecondNameTextBox => TBSecondName;

        public string ThirdName
        {
            get => TBThirdName.Text.Trim();
            set => TBThirdName.Text = value;
        }
        public TextBox ThirdNameTextBox => TBThirdName;

        public string LastName

        {
            get => TBLastName.Text.Trim();
            set => TBLastName.Text = value;
        }
        public TextBox LastNameTextBox => TBLastName;

        public string NationalNo
        {
            get => TBNationalNo.Text.Trim();
            set => TBNationalNo.Text = value;
        }
        public TextBox NationalNumberTextBox => TBNationalNo;

        public string Phone
        {
            get => TBPhone.Text.Trim();
            set => TBPhone.Text = value;
        }

        public string Email
        {
            get => TBEmail.Text.Trim();
            set => TBEmail.Text = value;
        }
        public TextBox EmailTextBox => TBEmail;

        public string Country

        {
            get => CBCountry.Text;
            set => CBCountry.Text = value;
        }
        public ComboBox CountryComboBox => CBCountry;

        private void _defaultCBCountry()
        {
            CBCountry.SelectedIndex = 2;
            CBCountry.DropDownHeight = CBCountry.ItemHeight * 5;
        }
        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {

                CBCountry.Items.Add(row["CountryName"]);

            }

        }
        public DateTime BirthDate
        {
            get => DTPcontroluser.Value;
            set => DTPcontroluser.Value = value;
        }
        private void _defaultBirthDate()
        {
            DTPcontroluser.Value = DateTime.Today;
            DTPcontroluser.MaxDate = DateTime.Today.AddYears(-18);
        }
        public string Address
        {
            get => TBAddress.Text.Trim();
            set => TBAddress.Text = value;
        }
        public Gender SelectedGender
        {
            get => RBMale.Checked ? Gender.Male : Gender.Female;
            set
            {
                if (value == Gender.Male)
                    RBMale.Checked = true;
                else
                    RBFemale.Checked = true;
            }
        }

        private void RBMale_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMale.Checked)
            {
                PersonImage = Image.FromFile(@"E:\DVLD\packagesImages\ControlUser(Edit-Add)PackagesImages\Male.png");
            }
        }
        private void RBFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RBFemale.Checked)
            {
                PersonImage = Image.FromFile(@"E:\DVLD\packagesImages\ControlUser(Edit-Add)PackagesImages\FeMale.png");
            }
        }
        public event CancelEventHandler NationalNumberValidating;
        private void TBNationalNo_Validating(object sender, CancelEventArgs e)
        {
            NationalNumberValidating?.Invoke(this, e);
        }
        public event CancelEventHandler EmailValidating;
        private void TBEmail_Validating(object sender, CancelEventArgs e)
        {
            EmailValidating?.Invoke(this, e);

        }
        public event EventHandler SaveButtonClick;
        private void BtnAddSave_Click(object sender, EventArgs e)
        {
            SaveButtonClick?.Invoke(this, EventArgs.Empty);

        }
        public event EventHandler CloseButtonClick;

        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            CloseButtonClick?.Invoke(this, EventArgs.Empty);
        }
        private void CtrDetailsPerson_Edit_Add__Load(object sender, EventArgs e)
        {
            _FillCountriesInComoboBox();
            _defaultBirthDate();
            _defaultCBCountry();

        }
        public event CancelEventHandler FirstNameValidating;
        private void TBFirstName_Validating(object sender, CancelEventArgs e)
        {
            FirstNameValidating?.Invoke(this, e);
        }
        public event CancelEventHandler SecondNameValidating;

        private void TBSecondName_Validating(object sender, CancelEventArgs e)
        {
            SecondNameValidating?.Invoke(this, e);

        }
        public event CancelEventHandler ThirdNameValidating;

        private void TBThirdName_Validating(object sender, CancelEventArgs e)
        {
            ThirdNameValidating?.Invoke(this, e);

        }
        public event CancelEventHandler LastNameValidating;

        private void TBLastName_Validating(object sender, CancelEventArgs e)
        {
            LastNameValidating?.Invoke(this, e);

        }

      
    }
}
