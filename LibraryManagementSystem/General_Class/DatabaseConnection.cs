using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    internal class DatabaseConnection
    {
        private string conn = "server=localhost;uid=root;password=password;database=librarymanagement";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(conn);
        }

        public MySqlCommand CreateCommand(string query, MySqlConnection connection)
        {
            return new MySqlCommand(query, connection);
        }
    }
}
