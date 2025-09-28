using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsApplications;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsNewLocalDrivingApplication:clsApplications
    {
 
        public int LocalDrivingLicenseApplicationID { set; get; }
        public int ApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public clsApplications applications { set; get; }
        public clsNewLocalDrivingApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = 0;
            LicenseClassID = 0;
        }

        private clsNewLocalDrivingApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicantPersonID,
    DateTime ApplicationDate, int ApplicationTypeID,
     enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
     Decimal PaidFees, clsUser CreatedByUserInfo, int CreatedByUserID, int LicenseClassID)

        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = CreatedByUserInfo;
            this.LicenseClassID = LicenseClassID;
            Mode = enMode.Update;
        }
        private bool _AddNewLocalDrivingApplication()
        {
            //call DataAccess Layer 
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingApplicationDataAccess.AddNewLocalDrivingApplication(
        this.ApplicationID,
         this.LicenseClassID
             );
            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        public static bool DoesApplicationExistForPerson(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLocalDrivingApplicationDataAccess.DoesApplicationExistForPerson(ApplicantPersonID, LicenseClassID);
        }
        public static clsNewLocalDrivingApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            // 
            int ApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingApplicationDataAccess.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                clsApplications Application = clsApplications.Find(ApplicationID);

                //we return new object of that person with the right data
                return new clsNewLocalDrivingApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserInfo, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;

        }
        public static clsNewLocalDrivingApplication FindByApplicationID(int ApplicationID)
        {
            // 
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingApplicationDataAccess.GetLocalDrivingLicenseApplicationInfoByApplicationID
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                clsApplications Application = clsApplications.Find(ApplicationID);

                //we return new object of that person with the right data
                return new clsNewLocalDrivingApplication(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicantPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserInfo, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;

        }
        public byte GetPassedTestCount()
        {
            return clsTestTypesDataAccess.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }
        public static  byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTestTypesDataAccess.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }
        public bool Save()
        {
            return _AddNewLocalDrivingApplication();
        }
        public static DataTable GetAllLocalDrivingApplications()
        {
            return clsLocalDrivingApplicationDataAccess.GetAllLocalDrivingApplications();

        }
        public static string GetClassNameById(int id)
        {
            return clsLocalDrivingApplicationDataAccess.GetClassNameById(id);
        }
    }
}
