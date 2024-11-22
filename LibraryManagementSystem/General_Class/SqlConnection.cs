using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem.General_Class
{
    internal class SqlConnection
    {
        MySqlConnection connection;
        MySqlCommand cmd;

        string conn = "server=localhost;uid=root;password=password;database=librarymanagement";
      
        public void Login(string user, string password)
        {
            string query = "SELECT user_id, user_level FROM user_accounts WHERE email = @email AND password = @password";
            
            
            try
            {
                connection = new MySqlConnection(conn);
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                
                cmd.Parameters.AddWithValue("@email", user);
                cmd.Parameters.AddWithValue ("@password", password); 
                MySqlDataReader result = cmd.ExecuteReader();

                if (result.Read())
                {
                    openForm(result.GetString(1).ToLower());
                    int id = result.GetInt32(0);
                    connection.Close();
                    logHistory(id);
                }
                else
                {
                    MessageBox.Show("Account not found!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void openForm(string userLevel)
        {
            Form target;
            F_Login form = new F_Login();

            switch (userLevel)
            {
                case "admin":
                    target = new F_Admin();
                    break;
                case "librarian":
                    target = new F_Library();
                    break;
                default:
                    return;
            }

            form.Hide();
            target.ShowDialog();
        }

        public void logHistory(int id)
        {
            connection.Open();
            try
            {
                string history = "INSERT into user_history(user_id, created_by, updated_by) VALUES (@user_id, NOW(), NOW())";
                cmd = new MySqlCommand(history, connection);
                cmd.Parameters.AddWithValue("@user_id", id);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }
    }
}
