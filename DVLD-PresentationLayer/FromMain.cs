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
    }
}
