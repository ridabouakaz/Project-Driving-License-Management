using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsUser;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum ActiveStatus { Yes = 0, No = 1 };
        public IsActive isActive = IsActive.Yes;
        public enMode Mode = enMode.AddNew;
        public int ID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public clsUser()

        {
            this.ID = -1;
            this.PersonID = 1;
            this.UserName = "";
            this.Password = "";
            Active = IsActive.AddNew;

            Mode = enMode.AddNew;

        }

    }
}
