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
using static DVLDShared.DVLDShared;

namespace DVLD_PresentationLayer
{
    public partial class CtrDetailsUser : UserControl
    {
        clsUser _User;
        public CtrDetailsUser()
        {
            InitializeComponent();
            ctrDetailsPerson1.PersonData = null;
        }
        public clsPerson Personinformation
        {
            set => ctrDetailsPerson1.PersonData = value;
        }
        public clsUser UserData
        {
            get => _User;
            set
            {
                _User = value;
                FillUIFromPerson();
            }
        }
        private void FillUIFromPerson()
        {
            if (_User == null)
            {
                UserID = "??";
                UserName = "??";
                LblvalueIsActive.Text = "??";
                return;
            }
            UserID = _User.ID.ToString();
            UserName = _User.UserName;
            IsActive = _User.isActive;
        }
        public string UserID
        {
            set => LblValueUserID.Text = value;
        }
        public string UserName
        {
            set => LblValueUserName.Text = value;

        }
        public ActiveStatus IsActive
        {
            set
            {
                if (value == ActiveStatus.Yes)
                    LblvalueIsActive.Text = "Yes";
                else
                    LblvalueIsActive.Text = "No";
            }
        }
    }
}
