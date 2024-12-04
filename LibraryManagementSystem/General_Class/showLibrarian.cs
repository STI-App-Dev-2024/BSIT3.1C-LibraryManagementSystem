using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.General_Class
{
    class showLibrarian
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";

        public showLibrarian(Label lbl, int id)
        {
            string query = "SELECT CONCAT(first_name, ' ', last_name) " +
                "FROM user_accounts " +
                "WHERE user_id = @user";

            try
            {
                
                connection = new MySqlConnection(conn);
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@user", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lbl.Text = "Welcome, " + reader.GetString(0) + "!";
                }
            }catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
