using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Preschool_Nutrition.Utilities
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "mysql://349U3FBRT6ZmZme.root:PFx7weh2AOTODDH3@gateway01.ap-southeast-1.prod.aws.tidbcloud.com:4000/DACN";

        // Mở kết nối
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return connection;
        }

        // Đóng kết nối
        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
