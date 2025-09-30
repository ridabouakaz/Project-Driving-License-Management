using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;

namespace DVLD_DataAccessLayer
{
    public class clsTestAppointmentDataAccess
    {
        public static bool GetTestAppointmentInfoByID(
    int TestAppointmentID,
    ref int TestTypeID,
    ref int LocalDrivingLicenseApplicationID,
    ref DateTime AppointmentDate,
    ref decimal PaidFees,
    ref int CreatedByUserID,
    ref IsLocked IsLocked,
    ref int? RetakeTestApplicationID // Make nullable
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        TestTypeID = Convert.ToInt32(reader["TestTypeID"]);
                        LocalDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                        AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                        PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                        CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                        RetakeTestApplicationID = reader["RetakeTestApplicationID"] != DBNull.Value
                            ? Convert.ToInt32(reader["RetakeTestApplicationID"])
                            : (int?)null;

                        IsLocked = reader["IsLocked"] != DBNull.Value
                            ? (IsLocked)Convert.ToInt32(reader["IsLocked"])
                            : IsLocked.No;
                    }
                }
                catch (Exception ex)
                {
                    // Log or rethrow as needed
                    isFound = false;
                }
            }

            return isFound;
        }

        public static int AddNewAppointment(
   int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate,
   decimal PaidFees, int CreatedByUserID, IsLocked IsLocked, int? RetakeTestApplicationID)
        {
            int TestAppointmentID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO TestAppointments 
                        (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, 
                         IsLocked, RetakeTestApplicationID)
                        VALUES 
                        (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, 
                         @IsLocked, @RetakeTestApplicationID);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@IsLocked", IsLocked);
                    command.Parameters.AddWithValue("@RetakeTestApplicationID",
                        RetakeTestApplicationID.HasValue ? (object)RetakeTestApplicationID.Value : DBNull.Value);
                        try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            TestAppointmentID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding new Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return TestAppointmentID;
        }
        public static bool LockedAppointment(
int TestAppointmentID, IsLocked IsLocked,
         int CreatedByUserID
         )
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE TestAppointments  
                         SET IsLocked = @IsLocked,
                             CreatedByUserID = @CreatedByUserID
                            WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    command.Parameters.AddWithValue("@AppointmentDate", IsLocked);
                    command.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = (IsLocked == IsLocked.Yes);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static bool IsLockedAppointment(
int TestAppointmentID
   )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from TestAppointments where IsLocked=1 and \r\nTestAppointmentID=@TestAppointmentID ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
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
        public static bool EditTimeAppointment(
   int TestAppointmentID, DateTime AppointmentDate,
                int CreatedByUserID
                )
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"	UPDATE TestAppointments  
                         SET AppointmentDate = @AppointmentDate,
                             CreatedByUserID = @CreatedByUserID
                            WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static DataTable GetAllAppointments(int testTypeId)
        {
            const string query = @"
        SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked 
        FROM TestAppointments 
        WHERE TestTypeID = @TestTypeID";

            var dataTable = new DataTable();

            using (var connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = testTypeId;

                try
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dataTable;
        }

    }
}
