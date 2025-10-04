using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDShared.DVLDShared;

namespace DVLD_BusinessLayer
{
    
    public class clsLicenses
    {
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClass { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public ActiveStatus IsActive { set; get; }
        public int IssueReason { set; get; }
        public int CreatedByUserID { set; get; }


    }
}
