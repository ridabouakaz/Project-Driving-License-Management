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
    public class clsTestDataAccess
    {
        public static bool GetTestInfoByID(
int ID,
          ref string TestTypeTitle, ref string TestTypeDescription,
          ref decimal TestTypeFees
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select * from TestTypes where TestTypeID=@TestTypeID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TestTypeID", ID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        TestTypeFees = (decimal)reader["TestTypeFees"];
                        TestTypeTitle = reader["TestTypeTitle"].ToString();
                        TestTypeDescription = reader["TestTypeDescription"].ToString();
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

        public static bool UpdateTest(
    int ID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE TestTypes  
                         SET
                             TestTypeTitle = @TestTypeTitle,
                             TestTypeDescription = @TestTypeDescription,
                             TestTypeFees = @TestTypeFees
                         WHERE TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", ID);
                    command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                    command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                    command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
   
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating TestType: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
        public static DataTable GetAllTestTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select TestTypeID,TestTypeTitle,TestTypeDescription,TestTypeFees from TestTypes";

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
                MessageBox.Show("Error retrieving TestTypes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }
}
