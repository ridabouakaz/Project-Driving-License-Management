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
            LoadUserData(UserID);
        }
        public void LoadUserData(int userID)
        {
            _UserID = userID;
            _LoadData();
        }
        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);
            _Person = clsPerson.Find(_User.PersonID);
            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _UserID);
                this.Close();

                return;
            }
            ctrDetailsUser1.Personinformation = _Person;
            ctrDetailsUser1.UserData= _User;
        }
    
        private void BtnAddClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
