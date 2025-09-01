using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsApplications
    {
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public clsApplications.enApplicationStatus ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsApplications()
        {
            ID = -1;
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
            this.ID = id;
            this.ApplicantPersonID = applicantPersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = applicationStatus;
            this.LastStatusDate = lastStatusDate;
            this.PaidFees = paidFees;
            this.CreatedByUserID = createdByUserID;
        }
        private bool _AddNewApplication()
        {
            //call DataAccess Layer 
            this.ID = clsApplicationDataAccess.AddNewApplication(
        this.ApplicantPersonID,
         this.ApplicationDate,
        this.ApplicationTypeID,
        (int)this.ApplicationStatus,
        this.LastStatusDate,
        this.PaidFees,
        this.CreatedByUserID
             );
            return (this.ID != -1);
        }
        private bool _UpdateApplication()
        {
            //call DataAccess Layer 
            return clsApplicationDataAccess.UpdateApplication(
                    this.ID,
                    (int)this.ApplicationStatus,
                    this.LastStatusDate
                );

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
