using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
//Super secret connection for server hopefully no one finds this!
namespace DefendersSecureNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "149.56.143.57";
            string database = "mysql";
            string username = "root";
            string password = "your_password";
            int port = 3306;

            string connectionString = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password};";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to the database.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
