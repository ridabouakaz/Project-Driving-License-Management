using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    
    public class clsLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public clsDrivers DriverInfo;

        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClass { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public ActiveStatus IsActive { set; get; }
        public IssueReason IssueReason { set; get; }
        public int CreatedByUserID { set; get; }
        public clsPerson Person
        {
            get
            {
                return clsPerson.Find(clsApplications.Find(ApplicationID).ApplicantPersonID);
            }
        }
        public clsLicenses()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.Today;
            ExpirationDate = DateTime.Today;
            Notes = string.Empty;
            PaidFees = 0.0m;
            IsActive = ActiveStatus.Yes;
            IssueReason = IssueReason.FirstTime;
            CreatedByUserID = 0;
        }

        private clsLicenses(int LicenseID,
     int applicationID,
     int driverID,
     int licenseClass,
     DateTime issueDate,
     DateTime expirationDate,
     string notes,
     decimal paidFees,
     ActiveStatus isActive,
     IssueReason issueReason,
     int createdByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;
            this.DriverInfo = clsDrivers.FindByDriverID(this.DriverID);
        }
        private bool _AddNewLicense()
        {

            this.LicenseID = clsLicensesDataAccess.AddNewLicense(
        this.ApplicationID,
        this.DriverID,
        this.LicenseClass,
        this.IssueDate,
        this.ExpirationDate,
        this.Notes,
        this.PaidFees,
        this.IsActive,
        this.IssueReason,
        this.CreatedByUserID
             );
            return (this.LicenseID != -1);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return false;

            }
            return false;
        }
        public static clsLicenses FindByLicenseID(int LicenseID)
        {
            int applicationID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            string notes = "";
            decimal paidFees = 0;
            ActiveStatus isActive = ActiveStatus.Yes;
            IssueReason issueReason = IssueReason.FirstTime;
            int createdByUserID = -1;
            bool isFound = clsLicensesDataAccess.GetLicenseInfoByLicenseID  (
           LicenseID,
          ref applicationID,
          ref driverID,
          ref licenseClass,
          ref issueDate,
          ref expirationDate,
          ref notes,
          ref paidFees,
          ref isActive,
          ref issueReason,
          ref createdByUserID
      );

            if (isFound)
            {
                return new clsLicenses(
                    LicenseID,
                    applicationID,
                    driverID,
                    licenseClass,
                    issueDate,
                    expirationDate,
                    notes,
                    paidFees,
                    isActive,
                    issueReason,
                    createdByUserID
                );
            }
            else
                return null;

        }
        public static clsLicenses FindByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            int licenseID = 0;
            int applicationID = -1;
            int driverID = -1;
            int licenseClass = -1;
            DateTime issueDate = DateTime.MinValue;
            DateTime expirationDate = DateTime.MinValue;
            string notes = "";
            decimal paidFees = 0;
            ActiveStatus isActive = ActiveStatus.Yes;
            IssueReason issueReason = IssueReason.FirstTime;
            int createdByUserID = -1;
            bool isFound = clsLicensesDataAccess.GetLicensesInfoByID(
                LocalDrivingLicenseApplicationID,
                ref licenseID,
                ref applicationID,
                ref driverID,
                ref licenseClass,
                ref issueDate,
                ref expirationDate,
                ref notes,
                ref paidFees,
                ref isActive,
                ref issueReason,
                ref createdByUserID
            );

            if (isFound)
            {
                return new clsLicenses(
                    licenseID,
                    applicationID,
                    driverID,
                    licenseClass,
                    issueDate,
                    expirationDate,
                    notes,
                    paidFees,
                    isActive,
                    issueReason,
                    createdByUserID
                );
            }
            else
                return null;
        }
        public static int GetDefaultValidityLengthById(int LicenseClassID)
        {
            return clsLicensesDataAccess.GetDefaultValidityLengthById(LicenseClassID);
        }
        public static bool HasIssuedLicense(int LocalDrivingLicenseApplicationID)
        {
            return clsLicensesDataAccess.HasIssuedLicense(
                    LocalDrivingLicenseApplicationID);
        }
        public static string GetClassNameById(int LicenseClass)
        {
            return clsLicensesDataAccess.GetClassNameById(LicenseClass);
        }
    }
}
