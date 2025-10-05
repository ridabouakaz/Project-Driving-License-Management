using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static int AddNewLicense(
     int ApplicationID,
     int DriverID,
     int LicenseClass,
     DateTime IssueDate,
     DateTime ExpirationDate,
     string Notes,
     decimal PaidFees,
     ActiveStatus IsActive,
     IssueReason IssueReason,
     int CreatedByUserID)
        {
            int LicenseID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Licenses 
                        (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, 
                         Notes, PaidFees,IsActive,IssueReason,CreatedByUserID)
                        VALUES 
                        (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, 
                         @Notes, @PaidFees,@IsActive, @IssueReason, @CreatedByUserID);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                    command.Parameters.AddWithValue("@IssueDate", IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    command.Parameters.AddWithValue("@Notes", Notes);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@IssueReason", IssueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            LicenseID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding new Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return LicenseID;
        }



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

        public static bool HasIssuedLicense(int LocalDrivingLicenseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from Licenses inner join LocalDrivingLicenseApplications on\r\nLicenses.ApplicationID=LocalDrivingLicenseApplications.ApplicationID where\r\nLocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if Applications exists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
