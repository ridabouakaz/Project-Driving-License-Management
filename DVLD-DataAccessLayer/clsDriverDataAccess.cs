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
        public static DataTable GetAllDrivers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Drivers.DriverID, Drivers.PersonID ,People.NationalNo,\r\nPeople.FirstName + ' ' +People.SecondName + ' ' + ISNULL(People.ThirdName, ' ') + ' ' + People.LastName AS FullName,\r\nDrivers.CreatedDate,Licenses.IsActive\r\nfrom Drivers inner join People on Drivers.PersonID=People.PersonID INNER join Licenses on Licenses.DriverID=Drivers.DriverID";

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
    }
}
