using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Applications.International_License;
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
    public partial class FOmain : Form
    {
        private clsUser _currentUser;   
        public FOmain(clsUser currentUser)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1600, 850);
            _currentUser = currentUser;
        }
        private void SMItempeople_Click(object sender, EventArgs e)
        {
            FOManagePeople frm = new FOManagePeople();
            frm.ShowDialog();
        }
        private void FOmain_Load(object sender, EventArgs e)
        {
            MSMain.Renderer = new MyRenderer();
        }
        private void SMItemCurrentUserInfo_Click(object sender, EventArgs e)
        {
            FOUserInfo frm = new FOUserInfo(_currentUser.ID);
            frm.ShowDialog();
        }

        private void SMItemusers_Click(object sender, EventArgs e)
        {
            FOManageUsers frm = new FOManageUsers();
            frm.ShowDialog();
        }

        private void SMItemSingOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOLoginScreen frm = new FOLoginScreen();
            frm.ShowDialog();
        }

        private void SMItemchangePassword_Click(object sender, EventArgs e)
        {
            FOChangePasswordUser frm = new FOChangePasswordUser(_currentUser.ID);
            frm.ShowDialog();
        }
        private void SMItemManageApplicationTypes_Click(object sender, EventArgs e)
        {
            FOManageApplicationTypes frm = new FOManageApplicationTypes();
            frm.ShowDialog();
        }

        private void SMItemManageTestTypes_Click(object sender, EventArgs e)
        {
            FOManageTestTypes frm = new FOManageTestTypes();
            frm.ShowDialog();
        }
        private void SMItemNewDrivingLocalLicenses_Click(object sender, EventArgs e)
        {
            FONewLocalDrivingApplication frm = new FONewLocalDrivingApplication(_currentUser);
            frm.ShowDialog();
        }

        private void SMItemlocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            FOManageLocalDrivingApplication frm = new FOManageLocalDrivingApplication(_currentUser);
            frm.ShowDialog();
        }

        private void SMItemdrivers_Click(object sender, EventArgs e)
        {
            FOManageDrivers frm = new FOManageDrivers();
            frm.ShowDialog();
        }

        private void SMItemInternationalLicenseApplications_Click(object sender, EventArgs e)
        {
            FONewInternationalLicenseApplication frm = new FONewInternationalLicenseApplication();
            frm.ShowDialog();
        }
        private void SMItemRetakeTest_Click(object sender, EventArgs e)
        {
            FOManageLocalDrivingApplication frm = new FOManageLocalDrivingApplication(_currentUser);
            frm.ShowDialog();
        }

        private void SMItemRenewDrivingLicenses_Click(object sender, EventArgs e)
        {
            FORenewLocalDrivingLicenseApplication frm = new FORenewLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void SMItemReplacementForLostOrDamagedLicenses_Click(object sender, EventArgs e)
        {
            FOReplaceLostOrDamagedLicenseApplication frm = new FOReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }
    }
}
