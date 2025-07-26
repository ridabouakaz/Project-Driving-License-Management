using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsPerson_Edit_Add_ : UserControl
    {
        public CtrDetailsPerson_Edit_Add_()
        {
            InitializeComponent();
        }
        public enum Gender
        {
            Male,
            Female
        }

        public Image PersonImage
        {
            get { return PBImagePerson.Image; }
            set { PBImagePerson.Image = value; }
        }
        public Image UserImage { get; private set; }
        private void LLSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Images|*.png;*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    UserImage = Image.FromFile(ofd.FileName);
                    PBImagePerson.Image = UserImage;
                }
            }
        }

        public string FirstName
        {
            get => TBFirstName.Text;
            set => TBFirstName.Text = value;
        }
        public string SecondName
        {
            get => TBSecondName.Text;
            set => TBSecondName.Text = value;
        }
        public string LastName

        {
            get => TBLastName.Text;
            set => TBLastName.Text = value;
        }
        public string NationalNo
        {
            get => TBNationalNo.Text;
            set => TBNationalNo.Text = value;
        }
        public TextBox NationalNumberTextBox => TBNationalNo;

        public string Phone
        {
            get => TBPhone
.Text;
            set => TBPhone
.Text = value;
        }

        public string Email
        {
            get => TBEmail.Text;
            set => TBEmail.Text = value;
        }
        public string Country

        {
            get => CBCountry.Text;
            set => CBCountry.Text = value;
        }
        public DateTime BirthDate
        {
            get => DTPcontroluser.Value;
            set => DTPcontroluser.Value = value;
        }
        public string Address
        {
            get => TBAddress.Text;
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
    }
}
