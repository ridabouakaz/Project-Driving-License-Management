using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsPerson : UserControl
    {
        public CtrDetailsPerson()
        {
            InitializeComponent();
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
