using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsManageApplicationTypes
    {
        public int ID { set; get; }
        public string ApplicationTypeTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        private bool _UpdateApplication()
        {
            //call DataAccess Layer 
            return clsApplicationDataAccess.UpdateApplication(
                    this.ID,
                    this.ApplicationTypeTitle,
                    this.ApplicationFees

                );

        }
        public bool Save()
        { 
                    return _UpdateApplication();
        }
        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationDataAccess.GetAllApplicationTypes();

        }
    }
}
