using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLDShared.DVLDShared;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD_DataAccessLayer
{
    public class clsUserDataAccess
    {
        public static bool GetUserInfoByID(
 int  ID,
                ref int PersonID,
                ref string UserName,
                ref string Password,
                ref ActiveStatus isActive
)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Users WHERE UserID = @UserID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", ID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        PersonID = (int)reader["PersonID"];
                        UserName = reader["SecondName"].ToString();
                        Password = reader["ThirdName"].ToString();
                        isActive = reader["isActive"] != DBNull.Value? (ActiveStatus)Convert.ToInt32(reader["isActive"]): ActiveStatus.Yes; 

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
        
//        public static bool GetUserInfoByNationalNo(
//   string NationalNo,
//   ref string FirstName,
//   ref string SecondName,
//   ref string ThirdName,
//   ref string LastName,
//   ref int ID,
//   ref string Email,
//   ref string Phone,
//   ref string Address,
//   ref DateTime DateOfBirth,
//   ref int NationalityCountryID,
//   ref string ImagePath,
//   ref Gender Gender
//)
//        {
//            bool isFound = false;

//            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
//            {
//                string query = "SELECT * FROM Users WHERE NationalNo = @NationalNo";

//                SqlCommand command = new SqlCommand(query, connection);
//                command.Parameters.AddWithValue("@NationalNo", NationalNo);

//                try
//                {
//                    connection.Open();
//                    SqlDataReader reader = command.ExecuteReader();

//                    if (reader.Read())
//                    {
//                        isFound = true;
//                        ID = Convert.ToInt32(reader["UserID"]);
//                        FirstName = reader["FirstName"].ToString();
//                        SecondName = reader["SecondName"].ToString();
//                        ThirdName = reader["ThirdName"].ToString();
//                        LastName = reader["LastName"].ToString();
//                        NationalNo = reader["NationalNo"].ToString();
//                        Email = reader["Email"].ToString();
//                        Phone = reader["Phone"].ToString();
//                        Address = reader["Address"].ToString();
//                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
//                        NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);

//                        ImagePath = reader["ImagePath"] != DBNull.Value
//                                    ? reader["ImagePath"].ToString()
//                                    : "";
//                        Gender = reader["Gender"] != DBNull.Value
//         ? (Gender)Convert.ToInt32(reader["Gender"])
//         : Gender.Male; // Default: Male


//                    }
//                }
//                catch (Exception ex)
//                {
//                    // Handle error (log or throw)
//                    isFound = false;
//                }
//            }

//            return isFound;
//        }


        public static int AddNewUser(
    int PersonID,
                 string UserName,
                 string Password,
                 ActiveStatus isActive)
        {
            int UserID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Users 
                        (PersonID, UserName, Password, isActive)
                        VALUES 
                        (@PersonID, @UserName, @Password,@isActive);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@isActive", isActive);
     
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            UserID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding new User: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return UserID;
        }
        public static bool UpdateUser(
    int ID, int PersonID,
                 string UserName,
                 string Password,
                 ActiveStatus isActive)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE Users  
                         SET PersonID = @PersonID,
                             UserName = @UserName,
                             Password = @Password,
                             isActive = @isActive,WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@isActive", isActive);
      
                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating User: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select users.UserID,users.PersonID, (people.FirstName+' '+people.SecondName+' '+people.ThirdName+' '+people.LastName) as 'Full Name',Users.UserName,Users.IsActive from users\r\ninner join people on  users.PersonID =people.PersonID";

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
                MessageBox.Show("Error retrieving Users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"DELETE FROM Users 
                         WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting User: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return (rowsAffected > 0);
        }

        public static bool IsUserExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking if User exists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool IsUserExistByPersonID(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

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
                MessageBox.Show("Error checking if User exists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
