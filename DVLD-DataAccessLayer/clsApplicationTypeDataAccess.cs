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
    public class clsApplicationTypeDataAccess
    {
        public static bool GetApplicationInfoByID(
int ID,
          ref string ApplicationTypeTitle,
          ref decimal ApplicationFees
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "select * from ApplicationTypes where ApplicationTypeID=@ApplicationTypeID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationTypeID", ID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        ApplicationFees = (decimal)reader["ApplicationFees"];
                        ApplicationTypeTitle = reader["ApplicationTypeTitle"].ToString();

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


        public static bool UpdateApplication(
    int ID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE ApplicationTypes  
                         SET
                             ApplicationTypeTitle = @ApplicationTypeTitle,
                             ApplicationFees = @ApplicationFees
                         WHERE ApplicationTypeID = @ApplicationTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ID);
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
   
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating ApplicationType: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
        public static DataTable GetAllApplicationTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select ApplicationTypeID,ApplicationTypeTitle,ApplicationFees from ApplicationTypes";

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
                MessageBox.Show("Error retrieving ApplicationTypes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static decimal GetFeesById(int ApplicationTypeID)
        {
            decimal fee = 0m;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
           SELECT ApplicationTypes.ApplicationFees from  ApplicationTypes WHERE ApplicationTypes.ApplicationTypeID = @ApplicationTypeID
";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        fee = Convert.ToDecimal(result);
                    }
                }
            }
            return fee;
        }
        public static string GetTitleById(int id)
        {
            string Title = "";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"
            SELECT TOP 1 ApplicationTypes.ApplicationTypeTitle
            FROM Applications
            INNER JOIN ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
            WHERE ApplicationTypes.ApplicationTypeID = @ApplicationTypeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", id);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        Title = result.ToString();
                    }
                }
            }
            return Title;
        }
    }
}
