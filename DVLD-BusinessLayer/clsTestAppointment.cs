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
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public IsLocked IsLocked { set; get; }
        public int? RetakeTestApplicationID { set; get; }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Today;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = 0;
            RetakeTestApplicationID = 0;
        }
        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, IsLocked IsLocked, int? RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID ?? 0;
        }
        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID =0;
            int LocalDrivingLicenseApplicationID = 1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 1;
            int CreatedByUserID = 1;
            IsLocked IsLocked = IsLocked.No;
            int? RetakeTestApplicationID = 0;

            bool isFound = clsTestAppointmentDataAccess.GetTestAppointmentInfoByID(
                TestAppointmentID,
                ref TestTypeID,
                ref LocalDrivingLicenseApplicationID,
                ref AppointmentDate,
                ref PaidFees,
                ref CreatedByUserID,
                ref IsLocked,
                ref RetakeTestApplicationID
            );

            if (isFound)
            {
                return new clsTestAppointment(
                  TestAppointmentID,
                 TestTypeID,
                 LocalDrivingLicenseApplicationID,
                AppointmentDate,
                PaidFees,
                 CreatedByUserID,
                    IsLocked,
                 RetakeTestApplicationID
                );
            }
            else
                return null;
        }
        private bool _AddNewAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccess.AddNewAppointment(
        this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees,
         this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID
             );
            return (this.TestAppointmentID != -1);
        }
        public bool LockedAppointment()
        {
            return clsTestAppointmentDataAccess.LockedAppointment(
                    this.TestAppointmentID,
                    this.IsLocked,
                    this.CreatedByUserID
             );
        }
        private bool _EditTimeAppointment()
        {
            //call DataAccess Layer 
            return clsTestAppointmentDataAccess.EditTimeAppointment(
                    this.TestAppointmentID,
                    this.AppointmentDate,
                    this.CreatedByUserID
             );

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _EditTimeAppointment();

            }
            return false;
        }
        public static DataTable GetAllAppointments(int TestTypeID)
        {
            return clsTestAppointmentDataAccess.GetAllAppointments(TestTypeID);

        }
        public static bool IsLockedAppointment(int TestAppointmentID)
        {
            return clsTestAppointmentDataAccess.IsLockedAppointment(
                    TestAppointmentID
             );
        }
    }
}
