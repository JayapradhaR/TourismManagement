using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using TourismManagement.Entity;

namespace TourismManagement.DAL
{
    public static class UserRepository
    {
        static SqlConnection connection;
        static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        static public int AddCustomer(UserDetails user)
        {
            string procedure = "usp_Customer_Signup";
            int rows;
            connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@firstName";
                param.Value = user.FirstName;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@lastName";
                param.Value = user.LastName;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mobileNumber";
                param.Value = user.MobileNumber;
                param.SqlDbType = System.Data.SqlDbType.BigInt;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@dateOfBirth";
                param.Value = user.DateOfBirth;
                param.SqlDbType = SqlDbType.Date;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@gender";
                param.Value = user.Gender;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@mailId";
                param.Value = user.MailId;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = user.Password;
                param.SqlDbType = System.Data.SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@customerRole";
                if (user.Role == 1)
                    param.Value = "User";
                else if (user.Role == 2)
                    param.Value = "Admin";
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            return rows;
        }
        static public bool ValidateLogin(string username, string password)
        {
            bool isValue = false;
            string procedure = "usp_Customer_Signin";
            connection = new SqlConnection(connectionString);
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@mailId";
                param.Value = username;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@password";
                param.Value = password;
                param.SqlDbType = SqlDbType.VarChar;
                command.Parameters.Add(param);

                //param = new SqlParameter();
                //param.ParameterName = "@customerRole";
                //param.Direction = ParameterDirection.Output;
                //command.Parameters.Add(param);

                connection.Open();
                SqlDataReader data = command.ExecuteReader();
                if (data.HasRows)
                    isValue = true;
            }
            return isValue;
        }
    }
}