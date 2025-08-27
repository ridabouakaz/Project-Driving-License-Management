using DVLD_BusinessLayer;
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
    public partial class FOUserInfo : Form
    {
        private int _UserID;
        private clsUser _User;
        private clsPerson _Person;

        public FOUserInfo()
        {
            InitializeComponent();
        }

        public FOUserInfo(int userID) : this()
        {
            _UserID = userID;
        }
        private bool TryLoadUserData(int userID)
        {
            _User = clsUser.Find(userID);
            if (_User == null)
                return false;

            _Person = clsPerson.Find(_User.PersonID);
            return _Person != null;
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FOUserInfo_Load(object sender, EventArgs e)
        {
            if (!TryLoadUserData(_UserID))
            {
                MessageBox.Show($"This form will be closed because no user found with ID = {_UserID}",
                                "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            ctrDetailsUser1.LoadUserInfo(_User, _Person);
        }
    }
}
