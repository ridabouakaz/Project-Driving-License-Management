using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BusinessLayer
{
    public class clsDrivers
    {
        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }

        public clsDrivers()
        {
            DriverID = -1;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Today;
        }

        private clsDrivers(
       int DriverID,
       int PersonID, int CreatedByUserID,
       DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }
        private bool _AddDriver()
        {
            //call DataAccess Layer 
            this.DriverID = clsDriverDataAccess.AddNewDriver(
        this.PersonID,
         this.CreatedByUserID,
        this.CreatedDate
             );
            return (this.DriverID != -1);
        }
        public bool Save()
        {
            return _AddDriver();
        }
    }
}
