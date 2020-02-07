using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace OnlineTourismManagement
{
    public static class AdminRepository
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        static SqlConnection connection = connection = new SqlConnection(connectionString);
        public static DataTable ViewPackage()
        {
            string procedure = "usp_Package_View";
            DataTable table;
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                table = new DataTable();
                dataAdapter.Fill(table);
            }
            return table;
        }
        public static void DeletePackage(int packageId)
        {
            string procedure = "usp_Package_Delete";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@packageId", packageId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdatePackage(int packageId, int packagePrice)
        {
            string procedure = "usp_Package_Update";
            using (SqlCommand command = new SqlCommand(procedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@packageId", packageId);
                command.Parameters.AddWithValue("@packagePrice", packagePrice);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}