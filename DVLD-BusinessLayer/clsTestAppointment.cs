using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public byte IsLocked { set; get; }
        public int? RetakeTestApplicationID { set; get; }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Today;
            TestAppointmentID = 0;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = 0;
            RetakeTestApplicationID = 0;
        }
        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, byte IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.TestAppointmentID = TestAppointmentID;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
        }
        private bool _AddNewAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentDataAccess.AddNewAppointment(
        this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees,
         this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID
             );
            return (this.TestAppointmentID != -1);
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
    }
}
