using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsManageApplicationTypes
    {
        public int ID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        private clsManageApplicationTypes(int ID,
        string ApplicationTypeTitle,
        decimal ApplicationFees)
        {
            this.ID = ID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }
        private bool _UpdateApplication()
        {
            //call DataAccess Layer 
            return clsApplicationTypeDataAccess.UpdateApplication(
                    this.ID,
                    this.ApplicationTypeTitle,
                    this.ApplicationFees

                );

        }

        public static clsManageApplicationTypes Find(int ID)
        {
            string ApplicationTypeTitle = "";
            decimal ApplicationFees =1;

            bool isFound = clsApplicationTypeDataAccess.GetApplicationInfoByID(
                ID,
                ref ApplicationTypeTitle,
                ref ApplicationFees
            );

            if (isFound)
            {
                return new clsManageApplicationTypes(
                    ID,
                     ApplicationTypeTitle,
                 ApplicationFees
                );
            }
            else
                return null;
        }
        public bool Save()
        { 
          return _UpdateApplication();
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeDataAccess.GetAllApplicationTypes();

        }
    }
}
