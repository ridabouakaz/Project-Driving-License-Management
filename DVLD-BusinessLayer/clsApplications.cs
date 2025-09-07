using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public string ApplicantFullName
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID).FullName;
            }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public enApplicationStatus ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo;
        public clsApplications()
        {
            ApplicationID = -1;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Today;
            ApplicationTypeID = 0;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Today;
            PaidFees = 0.0m;
            CreatedByUserID = 0;
        }

        private clsApplications(
       int id,
       int applicantPersonID,
       DateTime applicationDate,
       int applicationTypeID,
       enApplicationStatus applicationStatus,
       DateTime lastStatusDate,
       decimal paidFees,
       int createdByUserID)
        {
            this.ApplicationID = id;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
            this.CreatedByUserInfo = clsUser.Find(CreatedByUserID);
        }

        private bool _AddNewApplication()
        {
            //call DataAccess Layer 
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(
        this.ApplicantPersonID,
         this.ApplicationDate,
        this.ApplicationTypeID,
        (int)this.ApplicationStatus,
        this.LastStatusDate,
        this.PaidFees,
        this.CreatedByUserID
             );
            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplication()
        {
            //call DataAccess Layer 
            return clsApplicationDataAccess.UpdateApplication(
                    this.ApplicationID,
                    (int)this.ApplicationStatus,
                    this.LastStatusDate
                );

        }
        public static clsApplications Find(int ID)
        {
            int ApplicantPersonID = 1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = 1;
            enApplicationStatus ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 1;
            int CreatedByUserID = 1;

            bool isFound = clsApplicationDataAccess.GetApplicationInfoByID(
                ID,
                ref ApplicantPersonID,
                ref ApplicationDate,
                ref ApplicationTypeID,
                ref ApplicationStatus,
                ref LastStatusDate,
                ref PaidFees,
                ref CreatedByUserID
            );

            if (isFound)
            {
                return new clsApplications(
                    ID,
                    ApplicantPersonID,
                 ApplicationDate,
                 ApplicationTypeID,
                 ApplicationStatus,
                   LastStatusDate,
                 PaidFees,
                 CreatedByUserID
                );
            }
            else
                return null;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }
            return false;
        }
      
    }
}
