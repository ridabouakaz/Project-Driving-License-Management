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
        public enum enMode { Update = 1 };
        private enMode _Mode;
        int _UserID;
        clsUser _User;
        clsPerson _Person;
        public FOUserInfo()
        {
            InitializeComponent();
        }
        public FOUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
            _LoadData();
        }
        public FOUserInfo(clsUser User)
        {
            InitializeComponent();
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            _Person=clsPerson.Find(_User.PersonID);
            if (_UserID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                this.Close();

                return;
            }
            ctrDetailsUser1.PersonData = _Person;
        }
    }
}
