using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
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
        public clsPerson PersonInfo;
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }
       
        public clsDrivers()
        {
            DriverID = -1;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Today;
            this.PersonInfo = clsPerson.Find(PersonID);
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
            this.PersonInfo = clsPerson.Find(PersonID);
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

        public static clsDrivers FindByPersonID(int PersonID)
        {
            int DriverID = 1;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;

            bool isFound = clsDriverDataAccess.GetDriverInfoByPersonID(
                PersonID,
                ref DriverID,
                ref CreatedByUserID,
                ref CreatedDate
            );

            if (isFound)
            {
                return new clsDrivers(
                   DriverID,
                     PersonID,
                 CreatedByUserID,
                 CreatedDate
                );
            }
            else
                return null;
        }
        public static clsDrivers FindByDriverID(int DriverID)
        {
            int PersonID = 1;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;

            bool isFound = clsDriverDataAccess.GetDriverInfoByDriverID(
                DriverID,
                ref PersonID,
                ref CreatedByUserID,
                ref CreatedDate
            );

            if (isFound)
            {
                return new clsDrivers(
                   DriverID,
                     PersonID,
                 CreatedByUserID,
                 CreatedDate
                );
            }
            else
                return null;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();

        }
        public static bool IsDriverExistsForPerson(int PersonID)
        {
            return clsDriverDataAccess.IsDriverExistsForPerson(PersonID);

        }
        public static DataTable GetLicenses(int DriverID)
        {
            return clsLicenses.GetDriverLicenses(DriverID);
        }
        public static DataTable GetInternationalLicenses(int DriverID)
        {
            return clsInternationalLicense.GetDriverInternationalLicenses(DriverID);
        }
    }
}
