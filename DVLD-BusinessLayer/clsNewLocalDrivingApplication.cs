using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsApplications;

namespace DVLD_BusinessLayer
{
    public class clsNewLocalDrivingApplication
    {
 
        public int ID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public clsApplications applications { set; get; }
        public clsNewLocalDrivingApplication()
        {
            ID = -1;
            ApplicationID = 0;
            LicenseClassID = 0;
        }
        private clsNewLocalDrivingApplication(
       int ID,
       int ApplicationID,
              int LicenseClassID)
        {
            this.ID = ID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }
        private bool _AddNewLocalDrivingApplication()
        {
            //call DataAccess Layer 
            this.ID = clsLocalDrivingApplicationDataAccess.AddNewLocalDrivingApplication(
        this.ApplicationID,
         this.LicenseClassID
             );
            return (this.ID != -1);
        }
        public static bool DoesApplicationExistForPerson(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDrivingApplicationDataAccess.DoesApplicationExistForPerson(ApplicantPersonID, LicenseClassID);
        }
        public bool Save()
        {
            return _AddNewLocalDrivingApplication();
        }
        public static DataTable GetAllLocalDrivingApplications()
        {
            return clsLocalDrivingApplicationDataAccess.GetAllLocalDrivingApplications();

        }

    }
}
