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
            _LoadData(User);
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            _Person = clsPerson.Find(_User.PersonID);
            if (_UserID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _UserID);
                this.Close();

                return;
            }
            ctrDetailsUser1.Personinformation = _Person;
            ctrDetailsUser1.UserData= _User;
        }
        private void _LoadData(clsUser User)
        {
            _User = User;
            _Person = clsPerson.Find(_User.PersonID);
            if (_UserID == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _UserID);
                this.Close();

                return;
            }
            ctrDetailsUser1.Personinformation = _Person;
            ctrDetailsUser1.UserData = _User;
        }
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
