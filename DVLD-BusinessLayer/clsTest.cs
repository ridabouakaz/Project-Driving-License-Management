using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public Result TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = 0;
            TestResult = 0;
            Notes = "";
            CreatedByUserID = 0;
        }
        private clsTest(int TestID, int TestAppointmentID, byte TestResult, string Notes
            , int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }
        private bool _TakeTest()
        {
            this.TestID = clsTestDataAccess.TakeTest(
        this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID
             );
            return (this.TestAppointmentID != -1);
        }
        public bool Save()
        {
            return _TakeTest();
        }

        public static bool  HasPersonAlreadyFailedTest(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestDataAccess.HasPersonAlreadyFailedTest(TestTypeID, LocalDrivingLicenseApplicationID);
        }
    }
}
