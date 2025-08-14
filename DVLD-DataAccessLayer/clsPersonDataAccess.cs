using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDShared;
using static DVLDShared.DVLDShared;
namespace DVLD_DataAccessLayer
{
    public class clsPersonDataAccess
    {
        public static bool GetPersonInfoByID(
    int ID,
    ref string FirstName,
    ref string SecondName,
    ref string ThirdName,
    ref string LastName,
    ref string NationalNo,
    ref string Email,
    ref string Phone,
    ref string Address,
    ref DateTime DateOfBirth,
    ref int NationalityCountryID,
    ref string ImagePath,
    ref Gender Gender
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM People WHERE PersonID = @PersonID";

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
                        ThirdName = reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        NationalNo = reader["NationalNo"].ToString();
                        Email = reader["Email"].ToString();
                        Phone = reader["Phone"].ToString();
                        Address = reader["Address"].ToString();
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                        ImagePath = reader["ImagePath"] != DBNull.Value
                                    ? reader["ImagePath"].ToString()
                                    : "";
                        Gender = reader["Gender"] != DBNull.Value
         ? (Gender)Convert.ToInt32(reader["Gender"])
         : Gender.Male; // Default: Male


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
        public static bool GetPersonInfoByNationalNo(
   string NationalNo,
   ref string FirstName,
   ref string SecondName,
   ref string ThirdName,
   ref string LastName,
   ref int ID,
   ref string Email,
   ref string Phone,
   ref string Address,
   ref DateTime DateOfBirth,
   ref int NationalityCountryID,
   ref string ImagePath,
   ref Gender Gender
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NationalNo", NationalNo);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;
                        ID= Convert.ToInt32(reader["PersonID"]);
                        FirstName = reader["FirstName"].ToString();
                        SecondName = reader["SecondName"].ToString();
                        ThirdName = reader["ThirdName"].ToString();
                        LastName = reader["LastName"].ToString();
                        NationalNo = reader["NationalNo"].ToString();
                        Email = reader["Email"].ToString();
                        Phone = reader["Phone"].ToString();
                        Address = reader["Address"].ToString();
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                        ImagePath = reader["ImagePath"] != DBNull.Value
                                    ? reader["ImagePath"].ToString()
                                    : "";
                        Gender = reader["Gender"] != DBNull.Value
         ? (Gender)Convert.ToInt32(reader["Gender"])
         : Gender.Male; // Default: Male


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


        public static int AddNewPerson(
    string FirstName, string SecondName, string ThirdName, string LastName,
    string NationalNo, string Email, string Phone, string Address,
    DateTime DateOfBirth, int NationalityCountryID, string ImagePath, Gender Gender)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO People 
                        (FirstName, SecondName, ThirdName, LastName, NationalNo, 
                         Email, Phone, Address, DateOfBirth, NationalityCountryID, ImagePath, Gender)
                        VALUES 
                        (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, 
                         @Email, @Phone, @Address, @DateOfBirth, @NationalityCountryID, @ImagePath, @Gender);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    command.Parameters.AddWithValue("@Gender", Gender);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            PersonID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding new person: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return PersonID;
        }
        public static bool UpdatePerson(
    int ID, string FirstName, string SecondName, string ThirdName, string LastName,
    string NationalNo, string Email, string Phone, string Address,
    DateTime DateOfBirth, int NationalityCountryID, string ImagePath, Gender Gender)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE People  
                         SET FirstName = @FirstName,
                             SecondName = @SecondName,
                             ThirdName = @ThirdName,
                             LastName = @LastName,
                             NationalNo = @NationalNo,
                             Email = @Email, 
                             Phone = @Phone, 
                             Address = @Address, 
                             DateOfBirth = @DateOfBirth,
                             NationalityCountryID = @NationalityCountryID,
                             ImagePath = @ImagePath,
                             Gender = @Gender
                         WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", ID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                    command.Parameters.AddWithValue("@Gender", Gender);

                    if (!string.IsNullOrEmpty(ImagePath))
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating person: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }
        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select PersonID,NationalNo,FirstName, SecondName, ThirdName, LastName,CASE \r\n        WHEN Gender = 0 THEN 'Male'\r\n        WHEN Gender = 1 THEN 'Female'\r\n        ELSE 'Unknown'\r\n    END AS Gender,DateOfBirth,Countries.CountryName as Nationality,Phone,Email from People\r\n INNER JOIN\r\n                         Countries ON People.NationalityCountryID = Countries.CountryID ";

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
        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"DELETE FROM People 
                         WHERE PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting person: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return (rowsAffected > 0);
        }
        public static string GetFilePathById(int id)
        {
            string path = string.Empty;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT ImagePath FROM People WHERE PersonID = @PersonID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonID", id);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        path = result.ToString();
                    }
                }
            }

            return path;
        }
        public static bool IsPersonExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if person exists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsNationalNoExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if person exists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
