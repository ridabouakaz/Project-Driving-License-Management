using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public int TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }
        public static bool  HasPersonAlreadyFailedTest(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTestDataAccess.HasPersonAlreadyFailedTest(TestTypeID, LocalDrivingLicenseApplicationID);
        }
    }
}
