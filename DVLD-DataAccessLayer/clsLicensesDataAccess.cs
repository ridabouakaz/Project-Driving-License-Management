using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static int GetDefaultValidityLengthById(int LicenseClassID)
        {
            int DefaultValidityLength = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
             select DefaultValidityLength from LicenseClasses where LicenseClassID=@LicenseClassID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        DefaultValidityLength = Convert.ToInt32(result);
                    }
                }
            }
            return DefaultValidityLength;
        }
    }
}
