using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using TourismManagement.Entity;
using System;

namespace TourismManagement.DAL
{
    public static class AdminRepository
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        static SqlConnection connection;
        public static DataTable ViewPackage()
        {
            string procedure = "usp_Package_View";
            DataTable table;
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
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
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@packageId", packageId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdatePackage(int packageId, int packagePrice)
        {
            string procedure = "usp_Package_Update";
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@packageId", packageId);
                command.Parameters.AddWithValue("@packagePrice", packagePrice);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void InsertPackage(Package package)
        {
            string procedure = "usp_Package_Add";
            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(procedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.AddWithValue("@packageId",package.PackageId);
                command.Parameters.AddWithValue("@packageName", package.PackageName);
                command.Parameters.AddWithValue("@packageType", package.PackageType);
                command.Parameters.AddWithValue("@packagePrice", package.PackagePrice);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}