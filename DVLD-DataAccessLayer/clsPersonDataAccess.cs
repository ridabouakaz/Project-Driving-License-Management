using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonInfoByID(
    int ID,
    ref string FirstName,
    ref string SecondName,
    ref string ThridName,
    ref string LastName,
    ref string NationalNo,
    ref string Email,
    ref string Phone,
    ref string Address,
    ref DateTime DateOfBirth,
    ref int CountryID,
    ref string ImagePath,
    ref int Gender
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Contacts WHERE PersonID = @PersonID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PersonID", ID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThridName = reader["ThridName"].ToString();
                        LastName = reader["LastName"].ToString();
                        NationalNo = reader["NationalNo"].ToString();
                        Email = reader["Email"].ToString();
                        Phone = reader["Phone"].ToString();
                        Address = reader["Address"].ToString();
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        CountryID = Convert.ToInt32(reader["CountryID"]);

                        ImagePath = reader["ImagePath"] != DBNull.Value
                                    ? reader["ImagePath"].ToString()
                                    : "";

                        Gender = reader["Gender"] != DBNull.Value
                                 ? Convert.ToInt32(reader["Gender"])
                                 : 0; // Default: Male
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

    }
}
