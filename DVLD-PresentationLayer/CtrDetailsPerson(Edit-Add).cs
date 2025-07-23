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
        public Image PersonImage
        {
            get { return PBImagePerson.Image; }
            set { PBImagePerson.Image = value; }
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
    }
}
