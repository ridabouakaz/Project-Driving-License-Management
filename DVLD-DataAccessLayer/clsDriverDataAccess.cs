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
    public class clsDriverDataAccess
    {
        public static int AddNewDriver(
  int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO drivers 
                        (PersonID, CreatedByUserID, CreatedDate)
                        VALUES 
                        (@PersonID, @CreatedByUserID, @CreatedDate);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DriverID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding new Application: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return DriverID;
        }
        public static bool GetDriverInfoByPersonID(
        int PersonID,
                ref int DriverID,
                ref int CreatedByUserID,
                ref DateTime CreatedDate)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select * from drivers where PersonID =@PersonID\r\n";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;
                        DriverID = Convert.ToInt32(reader["DriverID"]);
                        CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                        CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    }
                }
                catch (Exception ex)
                {
                    // Handle error (log or throw)
                    isFound = false;
                }
            }

            return isFound;
        }
        public static DataTable GetAllDrivers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select distinct Drivers.DriverID, Drivers.PersonID ,People.NationalNo,\r\nPeople.FirstName + ' ' +People.SecondName + ' ' + ISNULL(People.ThirdName, ' ') + ' ' + People.LastName AS FullName,\r\nDrivers.CreatedDate ,case WHEN Licenses.IsActive = 0 THEN 'Yes'        WHEN Licenses.IsActive = 1 THEN 'No'ELSE 'Unknown'    END AS [Active Licenses]\r\nfrom Drivers inner join People on Drivers.PersonID=People.PersonID INNER join Licenses on Licenses.DriverID=Drivers.DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving people: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static bool IsDriverExistsForPerson(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Found=1 from drivers where PersonID =@PersonID\r\n";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if drivers exists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
